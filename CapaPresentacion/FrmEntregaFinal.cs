using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmEntregaFinal : Form
    {
        // Capa de negocio: este formulario instancia Tramites y lee/escribe el archivo
        private Tramites tramites = new Tramites();
        private int posActual = -1;          // posición del trámite cargado en el vector (-1 = ninguno)
        private bool cargando = false;       // evita recalcular mientras se rellena el formulario

        // Orden = posiciones de Tramites.Req... (0..6)
        private CheckBox[] requisitos;

        private readonly Color colBotonActivo = Color.FromArgb(25, 193, 227);
        private readonly Color colBotonBloqueado = Color.FromArgb(154, 167, 182);
        private readonly Color colAvisoFaltaFondo = Color.FromArgb(253, 236, 236);
        private readonly Color colAvisoFaltaBorde = Color.FromArgb(198, 40, 40);
        private readonly Color colAvisoFaltaTexto = Color.FromArgb(138, 28, 28);
        private readonly Color colAvisoOkFondo = Color.FromArgb(232, 245, 233);
        private readonly Color colAvisoOkBorde = Color.FromArgb(46, 125, 50);
        private readonly Color colAvisoOkTexto = Color.FromArgb(27, 94, 32);

        public FrmEntregaFinal()
        {
            InitializeComponent();
            EstiloUI.Aplicar(this, 5);
            tsbNuevo.Visible = false;


            requisitos = new CheckBox[]
            {
                chkActaImpresa, chkComprobanteCopia, chkDocsIniciales,
                chkResolucion, chkPlacasMetalicas, chkRuat, chkPolizaOriginal
            };
            foreach (CheckBox c in requisitos)
                c.CheckedChanged += Requisito_CheckedChanged;

            // tsbCerrar y tsbActa ya están conectados en el Designer; el resto se conecta aquí
            btnFinalizarEntrega.Click += btnFinalizarEntrega_Click;
            tsbNuevo.Click += tsbNuevo_Click;
            tsbLimpiar.Click += tsbNuevo_Click;
            tsbGuardar.Click += tsbGuardar_Click;
            tsbModificar.Click += tsbModificar_Click;
            tsbEliminar.Click += tsbEliminar_Click;
            tsbBuscar.Click += tsbBuscar_Click;
            txtBuscar.KeyDown += txtBuscar_KeyDown;
            dgvEntregas.CellClick += dgvEntregas_CellClick;

            txtChasis.ReadOnly = true;
            txtPlaca.ReadOnly = true;
            dgvEntregas.ReadOnly = true;
            dgvEntregas.AllowUserToAddRows = false;
            dgvEntregas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            tramites.Archivo_VectorTramites();
            LlenarGrilla();
            LimpiarFormulario();
        }

        // Permite que otro formulario cargue un trámite por chasis
        public void CargarTramite(string chasis, string placa, string modalidad)
        {
            int p = tramites.BuscarChasis(chasis);
            if (p >= 0) CargarEnFormulario(p);
            else { txtChasis.Text = chasis; txtPlaca.Text = placa; txtModalidad.Text = modalidad; }
        }

        #region "GRILLA"
        // Muestra los trámites En tránsito (por entregar) y Entregado
        private void LlenarGrilla()
        {
            dgvEntregas.Rows.Clear();
            List<int> lista = tramites.Posiciones(Tramites.EnTransito, Tramites.Entregado);
            foreach (int p in lista)
            {
                Tramite t = tramites.Obtener(p);
                int fila = dgvEntregas.Rows.Add(
                    t.Chasis, t.Placa, t.Cliente, t.Modalidad,
                    SiNo(Tramites.Requisito(t, Tramites.ReqResolucion)),
                    SiNo(Tramites.Requisito(t, Tramites.ReqPlacasMetalicas)),
                    SiNo(Tramites.Requisito(t, Tramites.ReqRuat)),
                    SiNo(Tramites.Requisito(t, Tramites.ReqActaImpresa)),
                    t.Estado == Tramites.Entregado ? t.FechaEntrega.ToString("dd/MM/yyyy HH:mm") : "Pendiente");
                dgvEntregas.Rows[fila].Tag = p;
            }
        }
        private string SiNo(bool v) { return v ? "✓" : "—"; }

        private void dgvEntregas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvEntregas.Rows[e.RowIndex].Tag == null) return;
            CargarEnFormulario((int)dgvEntregas.Rows[e.RowIndex].Tag);
        }
        #endregion

        #region "FORMULARIO"
        private void CargarEnFormulario(int pos)
        {
            Tramite t = tramites.Obtener(pos);
            if (t == null) return;
            cargando = true;
            posActual = pos;
            txtChasis.Text = t.Chasis;
            txtPlaca.Text = t.Placa;
            txtModalidad.Text = t.Modalidad;
            for (int i = 0; i < requisitos.Length; i++)
                requisitos[i].Checked = Tramites.Requisito(t, i);
            txtEntregadoA.Text = t.EntregadoA ?? "";
            if (t.Estado == Tramites.Entregado) dtpFechaEntrega.Value = t.FechaEntrega;
            else dtpFechaEntrega.Value = DateTime.Now;
            cargando = false;
            AplicarBloqueo();
            ActualizarBotonFinalizar();
        }

        private void LimpiarFormulario()
        {
            cargando = true;
            posActual = -1;
            txtChasis.Clear(); txtPlaca.Clear(); txtModalidad.Clear(); txtEntregadoA.Clear();
            foreach (CheckBox c in requisitos) c.Checked = false;
            dtpFechaEntrega.Value = DateTime.Now;
            cargando = false;
            AplicarBloqueo();
            ActualizarBotonFinalizar();
        }

        // Entregado = solo lectura. Sin trámite cargado = todo bloqueado.
        private void AplicarBloqueo()
        {
            Tramite t = posActual >= 0 ? tramites.Obtener(posActual) : null;
            bool editable = t != null && t.Estado == Tramites.EnTransito;
            bool iniciada = editable && Tramites.EntregaIniciada(t);

            foreach (CheckBox c in requisitos) c.Enabled = editable;
            txtEntregadoA.ReadOnly = !editable;
            tsbGuardar.Enabled = editable && !iniciada;
            tsbModificar.Enabled = iniciada;
            tsbEliminar.Enabled = iniciada;
            
        }

        private string TextoRequisitos()
        {
            char[] r = new char[7];
            for (int i = 0; i < 7; i++) r[i] = requisitos[i].Checked ? '1' : '0';
            return new string(r);
        }

        private bool TodosMarcados()
        {
            foreach (CheckBox c in requisitos) if (!c.Checked) return false;
            return true;
        }

        private void Requisito_CheckedChanged(object sender, EventArgs e)
        {
            if (!cargando) ActualizarBotonFinalizar();
        }

        private void ActualizarBotonFinalizar()
        {
            Tramite t = posActual >= 0 ? tramites.Obtener(posActual) : null;
            bool ok = TodosMarcados();
            bool puede = ok && t != null && t.Estado == Tramites.EnTransito;
            btnFinalizarEntrega.Enabled = puede;
            btnFinalizarEntrega.BackColor = puede ? colBotonActivo : colBotonBloqueado;
            btnFinalizarEntrega.ForeColor = Color.White;

            pnlAviso.BackColor = ok ? colAvisoOkFondo : colAvisoFaltaFondo;
            pnlBordeAviso.BackColor = ok ? colAvisoOkBorde : colAvisoFaltaBorde;
            lblAviso.ForeColor = ok ? colAvisoOkTexto : colAvisoFaltaTexto;
            lblAviso.Text = ok
                ? "✓ Documentación completa"
                : "✕ Sin resolución, placas y RUAT no se puede entregar";
        }

        private void Aviso(string msg, MessageBoxIcon icono)
        {
            MessageBox.Show(msg, "GDCON Legal System", MessageBoxButtons.OK, icono);
        }

        private void Guardar_Archivo() { tramites.VectorTramites_Archivo(); }
        #endregion

        #region "ACCIONES"
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            txtBuscar.Text = "";
            dgvEntregas.ClearSelection();
        }

        // Guardar / Modificar: registra los requisitos marcados y a quién se entrega
        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (posActual < 0) { Aviso("Selecciona un trámite de la lista.", MessageBoxIcon.Information); return; }
            string msg;
            if (!tramites.GuardarEntrega(posActual, TextoRequisitos(), txtEntregadoA.Text, out msg))
            { Aviso(msg, MessageBoxIcon.Warning); return; }
            Guardar_Archivo();
            LlenarGrilla();
            AplicarBloqueo();
            Aviso("Registro de entrega guardado.", MessageBoxIcon.Information);
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            tsbGuardar_Click(sender, e);
        }

        // Eliminar = deshacer el registro de entrega (el trámite sigue En tránsito)
        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (posActual < 0) return;
            if (MessageBox.Show("¿Deshacer el registro de entrega de este trámite?", "GDCON Legal System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            string msg;
            if (!tramites.DeshacerEntrega(posActual, out msg)) { Aviso(msg, MessageBoxIcon.Warning); return; }
            Guardar_Archivo();
            LlenarGrilla();
            CargarEnFormulario(posActual);
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();
            if (texto == "") { LlenarGrilla(); return; }
            int p = tramites.Buscar(texto);
            if (p < 0) { Aviso("No se encontró ningún trámite con ese dato.", MessageBoxIcon.Information); return; }
            Tramite t = tramites.Obtener(p);
            if (t.Estado != Tramites.EnTransito && t.Estado != Tramites.Entregado)
            {
                Aviso("El trámite está " + t.Estado + ". Solo llega a Entrega cuando está En tránsito.", MessageBoxIcon.Information);
                return;
            }
            CargarEnFormulario(p);
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; tsbBuscar_Click(sender, e); }
        }

        private void btnFinalizarEntrega_Click(object sender, EventArgs e)
        {
            if (posActual < 0 || !TodosMarcados()) return;
            if (string.IsNullOrWhiteSpace(txtEntregadoA.Text))
            {
                Aviso("Indica a quién se entrega la carpeta.", MessageBoxIcon.Information);
                txtEntregadoA.Focus();
                return;
            }
            if (MessageBox.Show("¿Confirmas la entrega final del trámite? Después ya no se podrá modificar.",
                "GDCON Legal System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            string msg;
            if (!tramites.GuardarEntrega(posActual, TextoRequisitos(), txtEntregadoA.Text, out msg)
                || !tramites.FinalizarEntrega(posActual, out msg))
            { Aviso(msg, MessageBoxIcon.Warning); return; }

            Guardar_Archivo();
            LlenarGrilla();
            CargarEnFormulario(posActual);
            Aviso("Entrega registrada. El trámite quedó Entregado.", MessageBoxIcon.Information);
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbActa_Click(object sender, EventArgs e)
        {
            var menu = this.ParentForm as FrmMenuPrincipal;
            if (menu == null) return;

            Tramite t = posActual >= 0 ? tramites.Obtener(posActual) : null;
            if (t == null)
            {
                Aviso("Selecciona un trámite de la lista primero.", MessageBoxIcon.Information);
                return;
            }

            string m = (t.Modalidad ?? "").Trim();
            if (m.Equals("Crédito", StringComparison.OrdinalIgnoreCase) || m.Equals("Credito", StringComparison.OrdinalIgnoreCase))
                menu.AbrirFormulario(new FrmActaCredito(t));
            else
                menu.AbrirFormulario(new FrmActaContado(t));
        }
        #endregion
    }
}
