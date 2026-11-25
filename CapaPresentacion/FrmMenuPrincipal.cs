using System;
using System.Drawing;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmMenuPrincipal : Form
    {
        private Form formularioActual;
        private bool cerrandoSesion;

        // Colores del menú lateral
        private readonly Color colNormal = Color.FromArgb(9, 26, 58);
        private readonly Color colActivo = Color.FromArgb(20, 40, 75);
        private readonly Color colHover = Color.FromArgb(14, 33, 68);
        private readonly Color colTextoNormal = Color.White;
        private readonly Color colTextoActivo = Color.FromArgb(25, 193, 227);

        private Button[] botonesMenu;
        private Button botonActivo;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            BarraTitulo.Aplicar(this, Color.White, Color.FromArgb(9, 26, 58));
            RedondearAvatar();

            botonesMenu = new Button[]
            {
                btnPanelGeneral, btnRecepcion, btnPlacas, btnDiprove, btnEntrega,
                btnSeguimiento, btnPagosBanco, btnListadoDespacho, btnListadoEntrega,
                btnConfiguracion
            };

            foreach (Button b in botonesMenu)
            {
                b.FlatAppearance.MouseOverBackColor = colHover;
                b.FlatAppearance.MouseDownBackColor = colActivo;
            }

            MarcarActivo(btnPanelGeneral);
        }
        public Usuario UsuarioActual;

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

            // Solo el Administrador puede entrar a Configuración
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
