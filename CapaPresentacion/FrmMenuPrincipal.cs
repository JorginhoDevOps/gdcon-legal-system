using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmMenuPrincipal : Form
    {
        private Form formularioActual;
        private bool cerrandoSesion;

        private readonly Color colNormal = Color.FromArgb(9, 26, 58);
        private readonly Color colActivo = Color.FromArgb(20, 40, 75);
        private readonly Color colHover = Color.FromArgb(14, 33, 68);
        private readonly Color colTextoNormal = Color.White;
        private readonly Color colTextoActivo = Color.FromArgb(25, 193, 227);

        private Button[] botonesMenu;
        private Button botonActivo;

        public Usuario UsuarioActual;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            BarraTitulo.Aplicar(this, Color.White, Color.FromArgb(9, 26, 58));
            RedondearAvatar();

            botonesMenu = new Button[]
            {
                btnPanelGeneral, btnRecepcion, btnPlacas, btnDiprove, btnEntrega,
                btnSeguimiento, btnPagosBanco, btnListadoDespacho, btnListadoEntrega,
                btnConfiguracion, btnEmpresas
            };

            foreach (Button b in botonesMenu)
            {
                b.FlatAppearance.MouseOverBackColor = colHover;
                b.FlatAppearance.MouseDownBackColor = colActivo;
            }

            MarcarActivo(btnPanelGeneral);
            CargarPanelGeneral();
        }

        public bool EsAdministrador()
        {
            return UsuarioActual != null && UsuarioActual.Rol == "Administrador";
        }

        public FrmMenuPrincipal(Usuario usuario) : this()
        {
            UsuarioActual = usuario;
            AplicarPermisosUsuario();
        }

        private void AplicarPermisosUsuario()
        {
            if (UsuarioActual == null) return;

            lblNombreUsuario.AutoSize = false;
            lblNombreUsuario.Width = pnlUsuario.Width - lblNombreUsuario.Left - 8;
            lblNombreUsuario.Height = 18;
            lblNombreUsuario.AutoEllipsis = true;
            lblNombreUsuario.Text = UsuarioActual.Nombre;
            lblEmpresaUsuario.Text = "Rol: " + UsuarioActual.Rol;
            lblAvatar.Text = ObtenerIniciales(UsuarioActual.Nombre);
            lblAvatar.Invalidate();

            btnConfiguracion.Visible = EsAdministrador();
            btnEmpresas.Visible = EsAdministrador();
        }

        private string ObtenerIniciales(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre)) return "US";
            string[] partes = nombre.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (partes.Length == 1)
                return partes[0].Substring(0, Math.Min(2, partes[0].Length)).ToUpper();
            return (partes[0][0].ToString() + partes[1][0].ToString()).ToUpper();
        }

        private void CargarPanelGeneral()
        {
            // 1. Fecha actual en español
            CultureInfo esBo = new CultureInfo("es-BO");
            string fechaTexto = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy", esBo);
            lblFechaActual.Text = char.ToUpper(fechaTexto[0]) + fechaTexto.Substring(1);
            lblEncabezadoResumen.Text = "Resumen general — " + DateTime.Now.ToString("dd/MM/yyyy");

            // 2. Cargar trámites reales desde Tramites.json
            Tramites tramites = new Tramites();
            tramites.Archivo_VectorTramites();

            int enTiempo = 0;
            int porVencer = 0;
            int vencidos = 0;

            int recibidos = 0;
            int despachados = 0;
            int placaPago = 0;
            int transito = 0;
            int entregados = 0;
            int actasContado = 0;
            int actasCredito = 0;

            for (int i = 0; i < tramites.Cantidad(); i++)
            {
                Tramite t = tramites.Obtener(i);
                if (t == null) continue;

                // Contadores por semáforo (solo trámites activos)
                string sem = Tramites.Semaforo(t);
                if (sem == "Verde") enTiempo++;
                else if (sem == "Ámbar") porVencer++;
                else if (sem == "Rojo") vencidos++;

                // Contadores por etapa
                if (t.Estado == Tramites.Recibido) recibidos++;
                else if (t.Estado == Tramites.Despachado) despachados++;
                else if (t.Estado == Tramites.ConPlacaPago) placaPago++;
                else if (t.Estado == Tramites.EnTransito) transito++;
                else if (t.Estado == Tramites.Entregado)
                {
                    entregados++;
                    if (string.Equals(t.Modalidad, "Crédito", StringComparison.OrdinalIgnoreCase))
                        actasCredito++;
                    else
                        actasContado++;
                }
            }

            // 3. Mostrar valores en las tarjetas KPI y el panel Resumen
            lblKpiValorEnTiempo.Text = enTiempo.ToString();
            lblKpiValorPorVencer.Text = porVencer.ToString();
            lblKpiValorVencidos.Text = vencidos.ToString();

            lblResumenRecibidosValor.Text = recibidos.ToString();
            lblResumenDespachadosValor.Text = despachados.ToString();
            lblResumenPlacaPagoValor.Text = placaPago.ToString();
            lblResumenTransitoValor.Text = transito.ToString();
            lblResumenEntregadosValor.Text = entregados.ToString();
            lblResumenActasContadoValor.Text = actasContado.ToString();
            lblResumenActasCreditoValor.Text = actasCredito.ToString();

            // 4. Llenar la tabla de trámites recientes (del más nuevo al más antiguo)
            dgvRecientes.Rows.Clear();
            int total = tramites.Cantidad();
            if (total == 0) return;

            dgvRecientes.RowCount = total;
            int fila = 0;
            for (int i = total - 1; i >= 0; i--)
            {
                Tramite t = tramites.Obtener(i);
                string sem = Tramites.Semaforo(t);
                int horas = (int)Math.Max(0, Math.Round(Tramites.Horas(t)));

                dgvRecientes[0, fila].Value = t.Chasis;
                dgvRecientes[1, fila].Value = t.Cliente;
                dgvRecientes[2, fila].Value = t.Modalidad;
                dgvRecientes[3, fila].Value = t.Estado;
                dgvRecientes[4, fila].Value = (t.Estado == Tramites.Entregado) ? "Cerrado" : horas + " h";
                dgvRecientes[5, fila].Value = sem;

                // Color visual en la celda Semáforo
                DataGridViewCell celdaSem = dgvRecientes[5, fila];
                celdaSem.Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                if (sem == "Verde")
                    celdaSem.Style.ForeColor = Color.FromArgb(46, 125, 50);
                else if (sem == "Ámbar")
                    celdaSem.Style.ForeColor = Color.FromArgb(217, 119, 6);
                else if (sem == "Rojo")
                    celdaSem.Style.ForeColor = Color.FromArgb(198, 40, 40);
                else
                    celdaSem.Style.ForeColor = Color.FromArgb(25, 118, 210);

                fila++;
            }
            dgvRecientes.ClearSelection();
        }

        // Pinta el botón elegido como activo y deja los demás normales
        private void MarcarActivo(Button activo)
        {
            if (activo == null) return;
            botonActivo = activo;

            foreach (Button b in botonesMenu)
            {
                bool esActivo = (b == activo);
                b.BackColor = esActivo ? colActivo : colNormal;
                b.ForeColor = esActivo ? colTextoActivo : colTextoNormal;
                b.Font = new Font(b.Font, esActivo ? FontStyle.Bold : FontStyle.Regular);
            }

            // La barrita celeste baja junto con el botón activo
            pnlIndicador.Top = activo.Top;
            pnlIndicador.Height = activo.Height;
            pnlIndicador.BringToFront();
        }

        private void RedondearAvatar()
        {
            lblAvatar.BackColor = lblAvatar.Parent.BackColor;

            lblAvatar.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (SolidBrush pincel = new SolidBrush(Color.FromArgb(31, 61, 112)))
                {
                    e.Graphics.FillEllipse(pincel, 0, 0, lblAvatar.Width - 1, lblAvatar.Height - 1);
                }
                TextRenderer.DrawText(e.Graphics, lblAvatar.Text, lblAvatar.Font,
                    lblAvatar.ClientRectangle, Color.White,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            };
        }

        public void AbrirFormulario(Form frm, Button origen = null)
        {
            Form anterior = formularioActual;
            formularioActual = null;
            if (anterior != null) anterior.Close();

            formularioActual = frm;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.FormClosed += (s, e) =>
            {
                if (formularioActual == frm)
                {
                    formularioActual = null;
                    MostrarPanelGeneral();
                }
            };

            pnlPanelGeneral.Visible = false;
            pnlContenedor.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();

            if (origen != null) MarcarActivo(origen);
        }

        private void MostrarPanelGeneral()
        {
            CargarPanelGeneral();
            pnlPanelGeneral.Visible = true;
            pnlPanelGeneral.BringToFront();
            MarcarActivo(btnPanelGeneral);
        }

        private void btnPanelGeneral_Click(object sender, EventArgs e)
        {
            if (formularioActual != null) formularioActual.Close();
            else MostrarPanelGeneral();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            cerrandoSesion = true;
            Application.OpenForms["FrmLogin"].Show();
            this.Close();
        }

        private void FrmMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!cerrandoSesion) Application.Exit();
        }

        private void btnRecepcion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmRecepcion(), btnRecepcion);
        }

        private void btnPlacas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPlacasPagos(), btnPlacas);
        }

        private void btnDiprove_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmTransito(), btnDiprove);
        }

        private void btnEntrega_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmEntregaFinal(), btnEntrega);
        }

        private void btnSeguimiento_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmSeguimiento(), btnSeguimiento);
        }

        private void btnPagosBanco_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmListadoBanco(), btnPagosBanco);
        }

        private void btnListadoDespacho_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmListadoDespacho(), btnListadoDespacho);
        }

        private void btnListadoEntrega_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmConsolidado(), btnListadoEntrega);
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmUsuarios(UsuarioActual), btnConfiguracion);
        }

        private void btnEmpresas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmEmpresas(), btnEmpresas);
        }
    }
}