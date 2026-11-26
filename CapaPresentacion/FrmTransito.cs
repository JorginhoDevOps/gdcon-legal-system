using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmTransito : Form
    {
        private readonly Tramites tramites = new Tramites();
        private int posActual = -1;
        private bool cargando = false;

        public FrmTransito()
        {
            InitializeComponent();
            EstiloUI.Aplicar(this, 4);
            tsbNuevo.Visible = false;
            ConfigurarControles();
            ConectarEventos();

            tramites.Archivo_VectorTramites();
            LlenarGrilla();
            LimpiarFormulario();
        }

        private void ConfigurarControles()
        {
            ConfigurarSoloLectura(txtChasis);
            ConfigurarSoloLectura(txtPlaca);
            ConfigurarSoloLectura(txtContado);
            ConfigurarSoloLectura(txtComprobantePago);
            ConfigurarSoloLectura(txtFechaEnvioTransito);

            dgvPlacas.ReadOnly = true;
            dgvPlacas.AllowUserToAddRows = false;
            dgvPlacas.AllowUserToDeleteRows = false;
            dgvPlacas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPlacas.MultiSelect = false;
        }

        private void ConfigurarSoloLectura(TextBox txt)
        {
            txt.ReadOnly = true;
            txt.BackColor = EstiloUI.SoloLecturaFondo;
            txt.ForeColor = EstiloUI.SoloLecturaTexto;
            txt.TabStop = false;
        }

        private void ConfigurarEditable(TextBox txt, bool editable)
        {
            txt.ReadOnly = !editable;
            txt.BackColor = editable ? EstiloUI.EditableFondo : EstiloUI.SoloLecturaFondo;
            txt.ForeColor = editable ? EstiloUI.EditableTexto : EstiloUI.SoloLecturaTexto;
            txt.TabStop = editable;
        }

        private void ConectarEventos()
        {
            tsbGuardar.Click += tsbGuardar_Click;
            btnEnviarTransito.Click += tsbGuardar_Click;
            tsbModificar.Click += tsbModificar_Click;
            tsbEliminar.Click += tsbEliminar_Click;
            tsbLimpiar.Click += tsbLimpiar_Click;
            tsbBuscar.Click += tsbBuscar_Click;
            tsbCerrar.Click += tsbCerrar_Click;
            btnSalir.Click += tsbCerrar_Click;
            txtBuscar.KeyDown += txtBuscar_KeyDown;
            dgvPlacas.CellClick += dgvPlacas_CellClick;
            txtNroInforme.TextChanged += txtNroInforme_TextChanged;
        }

        #region "GRILLA Y BUSQUEDA (SOBRECARGA)"
        private void LlenarGrilla()
        {
            LlenarGrilla("");
        }

        private void LlenarGrilla(string filtro)
        {
            dgvPlacas.Rows.Clear();
            string criterio = (filtro ?? "").Trim();

            List<int> lista = tramites.Posiciones(
                Tramites.ConPlacaPago,
                Tramites.EnTransito,
                Tramites.Entregado);

            foreach (int p in lista)
            {
                Tramite t = tramites.Obtener(p);
                if (t == null) continue;

                if (criterio != "" && !CoincideFiltro(t, criterio))
                    continue;

                string informe = string.IsNullOrWhiteSpace(t.InformeDiprove) ? "Pendiente" : t.InformeDiprove;
                string retorno = t.FechaRetorno == DateTime.MinValue ? "—" : t.FechaRetorno.ToString("dd/MM/yyyy");
                string envio = t.FechaEnvioTransito == DateTime.MinValue ? "—" : t.FechaEnvioTransito.ToString("dd/MM/yyyy HH:mm");

                int fila = dgvPlacas.Rows.Add(
                    t.Chasis,
                    t.Placa,
                    t.Modalidad,
                    informe,
                    retorno,
                    envio,
                    t.Estado);

                dgvPlacas.Rows[fila].Tag = p;
            }

            dgvPlacas.ClearSelection();
        }

        private bool CoincideFiltro(Tramite t, string criterio)
        {
            return Contiene(t.Chasis, criterio)
                || Contiene(t.Placa, criterio)
                || Contiene(t.Cliente, criterio)
                || Contiene(t.InformeDiprove, criterio)
                || Contiene(t.Comprobante, criterio)
                || Contiene(t.NroTramite, criterio)
                || Contiene(t.NitCi, criterio);
        }

        private bool Contiene(string origen, string texto)
        {
            if (string.IsNullOrEmpty(origen)) return false;
            return origen.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        private void SeleccionarFilaPorPos(int pos)
        {
            dgvPlacas.ClearSelection();
            foreach (DataGridViewRow row in dgvPlacas.Rows)
            {
                if (row.Tag != null && (int)row.Tag == pos)
                {
                    row.Selected = true;
                    dgvPlacas.CurrentCell = row.Cells[0];
                    break;
                }
            }
        }

        private void dgvPlacas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvPlacas.Rows[e.RowIndex].Tag == null) return;
            CargarEnFormulario((int)dgvPlacas.Rows[e.RowIndex].Tag);
        }
        #endregion

        #region "FORMULARIO Y REGLAS"
        private void LimpiarFormulario()
        {
            cargando = true;
            posActual = -1;
            txtChasis.Clear();
            txtPlaca.Clear();
            txtContado.Clear();
            txtComprobantePago.Clear();
            txtNroInforme.Clear();
            dtpFechaRetorno.Value = DateTime.Now;
            txtFechaEnvioTransito.Clear();
            cargando = false;

            AplicarBloqueo();
        }

        private void CargarEnFormulario(int pos)
        {
            Tramite t = tramites.Obtener(pos);
            if (t == null) return;

            cargando = true;
            posActual = pos;
            txtChasis.Text = t.Chasis ?? "";
            txtPlaca.Text = t.Placa ?? "";
            txtContado.Text = t.Modalidad ?? "";
            txtComprobantePago.Text = t.Comprobante ?? "";
            txtNroInforme.Text = t.InformeDiprove ?? "";

            if (t.FechaRetorno >= dtpFechaRetorno.MinDate && t.FechaRetorno <= dtpFechaRetorno.MaxDate)
                dtpFechaRetorno.Value = t.FechaRetorno;
            else
                dtpFechaRetorno.Value = DateTime.Now;

            txtFechaEnvioTransito.Text = t.FechaEnvioTransito == DateTime.MinValue
                ? "Pendiente de envío"
                : t.FechaEnvioTransito.ToString("dd/MM/yyyy HH:mm");

            cargando = false;
            AplicarBloqueo();
        }

        private void AplicarBloqueo()
        {
            Tramite t = posActual >= 0 ? tramites.Obtener(posActual) : null;
            bool esConPlaca = t != null && t.Estado == Tramites.ConPlacaPago;
            bool esEnTransitoEditable = t != null && t.Estado == Tramites.EnTransito && !Tramites.EntregaIniciada(t);
            bool editable = esConPlaca || esEnTransitoEditable;

            ConfigurarEditable(txtNroInforme, editable);
            dtpFechaRetorno.Enabled = editable;

            tsbGuardar.Enabled = esConPlaca;
            tsbModificar.Enabled = esEnTransitoEditable;
            tsbEliminar.Enabled = esEnTransitoEditable;

            ActualizarEstadoEnvio(t, esConPlaca, esEnTransitoEditable);
        }

        private void ActualizarEstadoEnvio(Tramite t, bool esConPlaca, bool esEnTransitoEditable)
        {
            if (t == null)
            {
                ConfigurarBotonEnviar(false);
                MostrarAviso("⚠  Selecciona un trámite con placa y pago de la lista.",
                    EstiloUI.AvisoAlertaFondo, EstiloUI.AvisoAlertaBorde, EstiloUI.AvisoAlertaTexto);
                return;
            }

            if (esConPlaca)
            {
                bool tieneInforme = !string.IsNullOrWhiteSpace(txtNroInforme.Text);
                bool tieneComprobante = t.PagoRealizado && !string.IsNullOrWhiteSpace(t.Comprobante);
                bool listo = tieneInforme && tieneComprobante;

                ConfigurarBotonEnviar(listo);

                if (listo)
                {
                    MostrarAviso("✓  Datos completos. Listo para enviar a Tránsito.",
                        EstiloUI.AvisoOkFondo, EstiloUI.AvisoOkBorde, EstiloUI.AvisoOkTexto);
                }
                else
                {
                    MostrarAviso("⚠  Ingresa el N° de informe técnico de Diprove para enviar a Tránsito.",
                        EstiloUI.AvisoAlertaFondo, EstiloUI.AvisoAlertaBorde, EstiloUI.AvisoAlertaTexto);
                }
                return;
            }

            ConfigurarBotonEnviar(false);

            if (esEnTransitoEditable)
            {
                MostrarAviso("✓  Enviado a Tránsito. Puedes modificar el informe o deshacer el envío.",
                    EstiloUI.AvisoOkFondo, EstiloUI.AvisoOkBorde, EstiloUI.AvisoOkTexto);
            }
            else
            {
                string motivo = t.Estado == Tramites.Entregado
                    ? "ℹ  Trámite Entregado (solo lectura)."
                    : "ℹ  La entrega final ya fue iniciada (solo lectura en esta etapa).";
                MostrarAviso(motivo,
                    EstiloUI.AvisoInfoFondo, EstiloUI.AvisoInfoBorde, EstiloUI.AvisoInfoTexto);
            }
        }

        private void ConfigurarBotonEnviar(bool activo)
        {
            btnEnviarTransito.Enabled = activo;
            btnEnviarTransito.BackColor = activo ? EstiloUI.Cian : EstiloUI.Gris;
            btnEnviarTransito.ForeColor = Color.White;
        }

        private void MostrarAviso(string texto, Color fondo, Color borde, Color colorTexto)
        {
            pnlAviso.BackColor = fondo;
            pnlBordeAviso.BackColor = borde;
            lblAviso.ForeColor = colorTexto;
            lblAviso.Text = texto;
        }

        private void txtNroInforme_TextChanged(object sender, EventArgs e)
        {
            if (cargando) return;
            Tramite t = posActual >= 0 ? tramites.Obtener(posActual) : null;
            bool esConPlaca = t != null && t.Estado == Tramites.ConPlacaPago;
            bool esEnTransitoEditable = t != null && t.Estado == Tramites.EnTransito && !Tramites.EntregaIniciada(t);
            ActualizarEstadoEnvio(t, esConPlaca, esEnTransitoEditable);
        }

        private void Aviso(string msg, MessageBoxIcon icono)
        {
            MessageBox.Show(msg, "GDCON Legal System", MessageBoxButtons.OK, icono);
        }
        #endregion

        #region "ACCIONES"
        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (posActual < 0)
            {
                Aviso("Selecciona un trámite con placa y pago de la lista.", MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNroInforme.Text))
            {
                Aviso("Ingresa el N° de informe técnico de Diprove.", MessageBoxIcon.Warning);
                txtNroInforme.Focus();
                return;
            }

            string msg;
            if (!tramites.RegistrarTransito(posActual, txtNroInforme.Text, dtpFechaRetorno.Value, out msg))
            {
                Aviso(msg, MessageBoxIcon.Warning);
                return;
            }

            tramites.VectorTramites_Archivo();
            LlenarGrilla(txtBuscar.Text);
            CargarEnFormulario(posActual);
            SeleccionarFilaPorPos(posActual);
            Aviso("Trámite enviado a Tránsito correctamente. Ya está disponible en Entrega Final.", MessageBoxIcon.Information);
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            if (posActual < 0)
            {
                Aviso("Selecciona un trámite de la lista.", MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNroInforme.Text))
            {
                Aviso("Ingresa el N° de informe técnico de Diprove.", MessageBoxIcon.Warning);
                txtNroInforme.Focus();
                return;
            }

            string msg;
            if (!tramites.ModificarTransito(posActual, txtNroInforme.Text, dtpFechaRetorno.Value, out msg))
            {
                Aviso(msg, MessageBoxIcon.Warning);
                return;
            }

            tramites.VectorTramites_Archivo();
            LlenarGrilla(txtBuscar.Text);
            CargarEnFormulario(posActual);
            SeleccionarFilaPorPos(posActual);
            Aviso("Datos de Diprove y Tránsito modificados correctamente.", MessageBoxIcon.Information);
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (posActual < 0) return;
            Tramite t = tramites.Obtener(posActual);
            if (t == null) return;

            DialogResult r = MessageBox.Show(
                "¿Deshacer el envío a Tránsito del chasis " + t.Chasis + "?\nEl trámite volverá a estado 'Con placa y pago'.",
                "GDCON Legal System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes) return;

            string msg;
            if (!tramites.DeshacerTransito(posActual, out msg))
            {
                Aviso(msg, MessageBoxIcon.Warning);
                return;
            }

            tramites.VectorTramites_Archivo();
            LlenarGrilla(txtBuscar.Text);
            CargarEnFormulario(posActual);
            SeleccionarFilaPorPos(posActual);
            Aviso("Envío deshecho. El trámite regresó a 'Con placa y pago'.", MessageBoxIcon.Information);
        }

        private void tsbLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            LlenarGrilla();
            LimpiarFormulario();
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();
            if (texto == "")
            {
                LlenarGrilla();
                return;
            }

            // Uso de la sobrecarga Buscar(texto, estado) y búsqueda general
            int p = tramites.Buscar(texto, Tramites.ConPlacaPago);
            if (p < 0) p = tramites.Buscar(texto, Tramites.EnTransito);
            if (p < 0) p = tramites.Buscar(texto);

            if (p >= 0)
            {
                Tramite t = tramites.Obtener(p);
                if (t.Estado == Tramites.Recibido || t.Estado == Tramites.Despachado)
                {
                    Aviso("El trámite está " + t.Estado + ". Primero debe completar Placas y Pagos.", MessageBoxIcon.Information);
                    return;
                }
                LlenarGrilla(texto);
                CargarEnFormulario(p);
                SeleccionarFilaPorPos(p);
                return;
            }

            LlenarGrilla(texto);
            if (dgvPlacas.Rows.Count == 0)
            {
                Aviso("No se encontró ningún trámite con ese dato.", MessageBoxIcon.Information);
                LlenarGrilla();
                return;
            }

            if (dgvPlacas.Rows.Count == 1 && dgvPlacas.Rows[0].Tag != null)
            {
                int posUnico = (int)dgvPlacas.Rows[0].Tag;
                CargarEnFormulario(posUnico);
                SeleccionarFilaPorPos(posUnico);
            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                tsbBuscar_Click(sender, e);
            }
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Manejadores enlazados en FrmTransito.Designer.cs
        private void lblAviso_Click_1(object sender, EventArgs e) { }
        private void lblPlaca_Click(object sender, EventArgs e) { }
        #endregion
    }
}