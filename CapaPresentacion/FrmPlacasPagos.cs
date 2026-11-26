using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmPlacasPagos : Form
    {
        private readonly Tramites tramites = new Tramites();
        private int posActual = -1;
        private bool cargando = false;

        private readonly Color colSoloLecturaFondo = Color.FromArgb(238, 242, 246);
        private readonly Color colSoloLecturaTexto = Color.FromArgb(75, 90, 107);
        private readonly Color colEditableFondo = Color.White;
        private readonly Color colEditableTexto = Color.FromArgb(27, 39, 51);

        private readonly Color colAvisoAlertaFondo = Color.FromArgb(255, 246, 224);
        private readonly Color colAvisoAlertaBorde = Color.FromArgb(249, 168, 37);
        private readonly Color colAvisoAlertaTexto = Color.FromArgb(109, 74, 0);

        private readonly Color colAvisoOkFondo = Color.FromArgb(232, 245, 233);
        private readonly Color colAvisoOkBorde = Color.FromArgb(46, 125, 50);
        private readonly Color colAvisoOkTexto = Color.FromArgb(27, 94, 32);

        private readonly Color colAvisoInfoFondo = Color.FromArgb(232, 244, 253);
        private readonly Color colAvisoInfoBorde = Color.FromArgb(25, 118, 210);
        private readonly Color colAvisoInfoTexto = Color.FromArgb(13, 71, 161);

        public FrmPlacasPagos()
        {
            InitializeComponent();
            EstiloUI.Aplicar(this, 3);
            tsbNuevo.Visible = false;

            ConfigurarControles();
            ConectarEventos();

            tramites.Archivo_VectorTramites();
#if DEBUG
            if (tramites.Cantidad() == 0)
            {
                tramites.CargarDemo();
                tramites.VectorTramites_Archivo();
            }
#endif
            LlenarGrilla();
            LimpiarFormulario();
        }

        private void ConfigurarControles()
        {
            txtChasis.ReadOnly = true;
            txtChasis.BackColor = colSoloLecturaFondo;
            txtChasis.ForeColor = colSoloLecturaTexto;
            txtChasis.TabStop = false;

            txtCliente.ReadOnly = true;
            txtModalidad.ReadOnly = true;
            dtpFechaAsignacion.Enabled = false;

            dgvPlacas.ReadOnly = true;
            dgvPlacas.AllowUserToAddRows = false;
            dgvPlacas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPlacas.MultiSelect = false;
        }

        private void ConectarEventos()
        {
            tsbGuardar.Click += tsbGuardar_Click;
            tsbModificar.Click += tsbModificar_Click;
            tsbEliminar.Click += tsbEliminar_Click;
            tsbLimpiar.Click += tsbLimpiar_Click;
            tsbBuscar.Click += tsbBuscar_Click;
            tsbCerrar.Click += tsbCerrar_Click;
            btnSalir.Click += tsbCerrar_Click;
            txtBuscar.KeyDown += txtBuscar_KeyDown;
            dgvPlacas.CellClick += dgvPlacas_CellClick;

            txtPlaca.TextChanged += CampoEntrada_Changed;
            chkRuat.CheckedChanged += CampoEntrada_Changed;
            txtComprobante.TextChanged += CampoEntrada_Changed;
            txtMonto.TextChanged += CampoEntrada_Changed;
            chkPago.CheckedChanged += CampoEntrada_Changed;
            txtMonto.KeyPress += txtMonto_KeyPress;
        }

        #region "GRILLA (SOBRECARGA)"
        private void LlenarGrilla()
        {
            LlenarGrilla("");
        }

        private void LlenarGrilla(string filtro)
        {
            dgvPlacas.Rows.Clear();
            string criterio = (filtro ?? "").Trim();

            List<int> lista = tramites.Posiciones(
                Tramites.Despachado,
                Tramites.ConPlacaPago,
                Tramites.EnTransito,
                Tramites.Entregado);

            foreach (int p in lista)
            {
                Tramite t = tramites.Obtener(p);
                if (t == null) continue;

                if (criterio != "" && !CoincideFiltro(t, criterio))
                    continue;

                string textoPlaca = string.IsNullOrWhiteSpace(t.Placa) ? "Pendiente" : t.Placa;
                string textoComp = string.IsNullOrWhiteSpace(t.Comprobante) ? "—" : t.Comprobante;
                string textoMonto = t.MontoPago > 0
                    ? t.MontoPago.ToString("0.00", CultureInfo.InvariantCulture)
                    : "—";
                string textoPago = TextoEstadoPago(t);

                int fila = dgvPlacas.Rows.Add(
                    t.Chasis,
                    t.Cliente,
                    t.Modalidad,
                    textoPlaca,
                    t.Ruat ? "✓" : "—",
                    textoComp,
                    textoMonto,
                    textoPago);

                dgvPlacas.Rows[fila].Tag = p;
            }

            dgvPlacas.ClearSelection();
        }

        private bool CoincideFiltro(Tramite t, string criterio)
        {
            return Contiene(t.Chasis, criterio)
                || Contiene(t.Cliente, criterio)
                || Contiene(t.Placa, criterio)
                || Contiene(t.Comprobante, criterio)
                || Contiene(t.NroTramite, criterio)
                || Contiene(t.NitCi, criterio);
        }

        private bool Contiene(string origen, string texto)
        {
            if (string.IsNullOrEmpty(origen)) return false;
            return origen.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        private string TextoEstadoPago(Tramite t)
        {
            if (t.Estado == Tramites.Despachado) return "Pendiente";
            if (t.Estado == Tramites.ConPlacaPago) return t.PagoRealizado ? "Pagado" : "Pendiente";
            return t.Estado;
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
            epValidacion.Clear();

            txtChasis.Clear();
            txtCliente.Clear();
            txtModalidad.Clear();
            dtpFechaAsignacion.Value = DateTime.Now;
            chkRuat.Checked = false;
            txtPlaca.Clear();
            txtComprobante.Clear();
            txtMonto.Clear();
            chkPago.Checked = false;

            cargando = false;
            AplicarBloqueo();
        }

        private void CargarEnFormulario(int pos)
        {
            Tramite t = tramites.Obtener(pos);
            if (t == null) return;

            cargando = true;
            posActual = pos;
            epValidacion.Clear();

            txtChasis.Text = t.Chasis ?? "";
            txtCliente.Text = t.Cliente ?? "";
            txtModalidad.Text = t.Modalidad ?? "";

            DateTime fechaRef = (t.FechaDespacho >= dtpFechaAsignacion.MinDate &&
                                 t.FechaDespacho <= dtpFechaAsignacion.MaxDate)
                ? t.FechaDespacho
                : DateTime.Now;
            dtpFechaAsignacion.Value = fechaRef;

            chkRuat.Checked = t.Ruat;
            txtPlaca.Text = t.Placa ?? "";
            txtComprobante.Text = t.Comprobante ?? "";
            txtMonto.Text = t.MontoPago > 0
                ? t.MontoPago.ToString("0.00", CultureInfo.InvariantCulture)
                : "";
            chkPago.Checked = t.PagoRealizado;

            cargando = false;
            AplicarBloqueo();
        }

        private void AplicarBloqueo()
        {
            Tramite t = posActual >= 0 ? tramites.Obtener(posActual) : null;
            bool esDespachado = t != null && t.Estado == Tramites.Despachado;
            bool esConPlaca = t != null && t.Estado == Tramites.ConPlacaPago;
            bool editable = esDespachado || esConPlaca;

            chkRuat.Enabled = editable;
            ConfigurarTextBoxEditable(txtPlaca, editable);

            tsbGuardar.Enabled = esDespachado;
            tsbModificar.Enabled = esConPlaca;
            tsbEliminar.Enabled = esConPlaca;

            ActualizarReglaPlacaPago(t, editable);
        }

        private void ActualizarReglaPlacaPago(Tramite t, bool editable)
        {
            if (t == null)
            {
                ConfigurarTextBoxEditable(txtComprobante, false);
                ConfigurarTextBoxEditable(txtMonto, false);
                chkPago.Enabled = false;
                MostrarAviso("⚠  Selecciona un trámite despachado de la lista.",
                    colAvisoAlertaFondo, colAvisoAlertaBorde, colAvisoAlertaTexto);
                return;
            }

            if (!editable)
            {
                ConfigurarTextBoxEditable(txtComprobante, false);
                ConfigurarTextBoxEditable(txtMonto, false);
                chkPago.Enabled = false;
                MostrarAviso("ℹ  Trámite " + t.Estado + " (solo lectura en esta etapa).",
                    colAvisoInfoFondo, colAvisoInfoBorde, colAvisoInfoTexto);
                return;
            }

            bool tienePlaca = !string.IsNullOrWhiteSpace(txtPlaca.Text);
            ConfigurarTextBoxEditable(txtComprobante, tienePlaca);
            ConfigurarTextBoxEditable(txtMonto, tienePlaca);
            chkPago.Enabled = tienePlaca;

            if (!tienePlaca)
            {
                if (chkPago.Checked)
                {
                    cargando = true;
                    chkPago.Checked = false;
                    cargando = false;
                }
                MostrarAviso("⚠  Sin placa no se puede registrar el pago.",
                    colAvisoAlertaFondo, colAvisoAlertaBorde, colAvisoAlertaTexto);
                return;
            }

            double monto;
            bool completo = chkRuat.Checked
                && !string.IsNullOrWhiteSpace(txtComprobante.Text)
                && IntentarParsearMonto(txtMonto.Text, out monto)
                && chkPago.Checked;

            if (completo)
            {
                string accion = t.Estado == Tramites.Despachado
                    ? "✓  Datos completos. Listo para guardar placa y pago."
                    : "✓  Placa y pago registrados. Puedes modificar o deshacer.";
                MostrarAviso(accion, colAvisoOkFondo, colAvisoOkBorde, colAvisoOkTexto);
            }
            else
            {
                MostrarAviso("⚠  Completa RUAT, comprobante, monto y marca Pago realizado.",
                    colAvisoAlertaFondo, colAvisoAlertaBorde, colAvisoAlertaTexto);
            }
        }

        private void ConfigurarTextBoxEditable(TextBox txt, bool editable)
        {
            txt.ReadOnly = !editable;
            txt.BackColor = editable ? colEditableFondo : colSoloLecturaFondo;
            txt.ForeColor = editable ? colEditableTexto : colSoloLecturaTexto;
            txt.TabStop = editable;
        }

        private void MostrarAviso(string texto, Color fondo, Color borde, Color colorTexto)
        {
            pnlAviso.BackColor = fondo;
            pnlBordeAviso.BackColor = borde;
            lblAviso.ForeColor = colorTexto;
            lblAviso.Text = texto;
        }

        private void CampoEntrada_Changed(object sender, EventArgs e)
        {
            if (cargando) return;
            epValidacion.SetError((Control)sender, "");
            Tramite t = posActual >= 0 ? tramites.Obtener(posActual) : null;
            bool editable = t != null && (t.Estado == Tramites.Despachado || t.Estado == Tramites.ConPlacaPago);
            ActualizarReglaPlacaPago(t, editable);
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) return;

            if ((e.KeyChar == '.' || e.KeyChar == ',') &&
                txtMonto.Text.IndexOf('.') < 0 && txtMonto.Text.IndexOf(',') < 0)
            {
                return;
            }

            e.Handled = true;
        }

        private bool IntentarParsearMonto(string texto, out double monto)
        {
            monto = 0;
            if (string.IsNullOrWhiteSpace(texto)) return false;
            string limpio = texto.Trim().Replace(',', '.');
            return double.TryParse(limpio, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out monto)
                && monto > 0;
        }

        private bool ValidarCampos(out double monto)
        {
            epValidacion.Clear();
            monto = 0;
            Control primero = null;

            if (!chkRuat.Checked)
            {
                epValidacion.SetError(chkRuat, "Falta verificar en la web del RUAT.");
                if (primero == null) primero = chkRuat;
            }

            if (string.IsNullOrWhiteSpace(txtPlaca.Text))
            {
                epValidacion.SetError(txtPlaca, "Ingresa la placa asignada.");
                if (primero == null) primero = txtPlaca;
            }

            if (string.IsNullOrWhiteSpace(txtComprobante.Text))
            {
                epValidacion.SetError(txtComprobante, "Ingresa el N° de comprobante del banco.");
                if (primero == null) primero = txtComprobante;
            }

            if (!IntentarParsearMonto(txtMonto.Text, out monto))
            {
                epValidacion.SetError(txtMonto, "Ingresa un monto válido mayor a cero.");
                if (primero == null) primero = txtMonto;
            }

            if (!chkPago.Checked)
            {
                epValidacion.SetError(chkPago, "Marca 'Pago realizado' para confirmar el pago.");
                if (primero == null) primero = chkPago;
            }

            if (primero != null)
            {
                primero.Focus();
                return false;
            }

            return true;
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
                Aviso("Selecciona un trámite despachado de la lista.", MessageBoxIcon.Information);
                return;
            }

            double monto;
            if (!ValidarCampos(out monto))
            {
                Aviso("Revisa los campos marcados antes de guardar.", MessageBoxIcon.Warning);
                return;
            }

            string msg;
            if (!tramites.RegistrarPlacaPago(posActual, txtPlaca.Text, chkRuat.Checked, txtComprobante.Text, monto, out msg))
            {
                if (msg.IndexOf("placa", StringComparison.OrdinalIgnoreCase) >= 0)
                    epValidacion.SetError(txtPlaca, msg);
                Aviso(msg, MessageBoxIcon.Warning);
                return;
            }

            tramites.VectorTramites_Archivo();
            LlenarGrilla(txtBuscar.Text);
            CargarEnFormulario(posActual);
            SeleccionarFilaPorPos(posActual);
            Aviso("Placa y pago registrados correctamente. El trámite pasó a 'Con placa y pago'.", MessageBoxIcon.Information);
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            if (posActual < 0)
            {
                Aviso("Selecciona un trámite de la lista.", MessageBoxIcon.Information);
                return;
            }

            double monto;
            if (!ValidarCampos(out monto))
            {
                Aviso("Revisa los campos marcados antes de modificar.", MessageBoxIcon.Warning);
                return;
            }

            string msg;
            if (!tramites.ModificarPlacaPago(posActual, txtPlaca.Text, chkRuat.Checked, txtComprobante.Text, monto, out msg))
            {
                if (msg.IndexOf("placa", StringComparison.OrdinalIgnoreCase) >= 0)
                    epValidacion.SetError(txtPlaca, msg);
                Aviso(msg, MessageBoxIcon.Warning);
                return;
            }

            tramites.VectorTramites_Archivo();
            LlenarGrilla(txtBuscar.Text);
            CargarEnFormulario(posActual);
            SeleccionarFilaPorPos(posActual);
            Aviso("Datos de placa y pago modificados correctamente.", MessageBoxIcon.Information);
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (posActual < 0) return;

            Tramite t = tramites.Obtener(posActual);
            if (t == null) return;

            DialogResult r = MessageBox.Show(
                "¿Deshacer el registro de placa y pago del chasis " + t.Chasis + "?\nEl trámite volverá a estado Despachado.",
                "GDCON Legal System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes) return;

            string msg;
            if (!tramites.DeshacerPlacaPago(posActual, out msg))
            {
                Aviso(msg, MessageBoxIcon.Warning);
                return;
            }

            tramites.VectorTramites_Archivo();
            LlenarGrilla(txtBuscar.Text);
            CargarEnFormulario(posActual);
            SeleccionarFilaPorPos(posActual);
            Aviso("Registro deshecho. El trámite regresó a estado Despachado.", MessageBoxIcon.Information);
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

            int p = tramites.Buscar(texto);
            if (p >= 0)
            {
                Tramite t = tramites.Obtener(p);
                if (t.Estado == Tramites.Recibido)
                {
                    Aviso("El trámite está Recibido. Primero debe despacharse en Recepción y Despacho.", MessageBoxIcon.Information);
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
        #endregion
    }
}