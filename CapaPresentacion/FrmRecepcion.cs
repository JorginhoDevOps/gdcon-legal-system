using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmRecepcion : Form
    {
        private readonly Recepciones recepciones = new Recepciones();
        private readonly Empresas empresas = new Empresas();
        private int indiceSeleccionado = -1;
        private string tramiteActual = "";

        public FrmRecepcion()
        {
            InitializeComponent();
            EstiloUI.Aplicar(this, 1, 2);
        }

        private void FrmRecepcion_Load(object sender, EventArgs e)
        {
            CargarEmpresas();
            mostrarRecepciones();
            limpiarFormulario();
            OcultarAviso();
        }

        private void CargarEmpresas()
        {
            empresas.Archivo_VectorEmpresas();
            cmbEmpresa.Items.Clear();
            string[] nombres = empresas.Nombres();
            for (int i = 0; i < nombres.Length; i++)
                cmbEmpresa.Items.Add(nombres[i]);

            if (cmbEmpresa.Items.Count > 0)
                cmbEmpresa.SelectedIndex = 0;
        }

        #region "GRILLA Y BUSQUEDA (SOBRECARGA)"
        public void mostrarRecepciones()
        {
            mostrarRecepciones("");
        }

        public void mostrarRecepciones(string filtro)
        {
            List<Tramite> listaTramites = recepciones.ObtenerTodos();
            dgvRecepciones.Rows.Clear();

            if (listaTramites == null || listaTramites.Count == 0)
                return;

            string criterio = (filtro ?? "").Trim();

            for (int i = 0; i < listaTramites.Count; i++)
            {
                Tramite t = listaTramites[i];
                if (t == null) continue;

                if (criterio != "" && !CoincideFiltro(t, criterio))
                    continue;

                int fila = dgvRecepciones.Rows.Add(
                    t.Chasis,
                    t.Cliente,
                    t.Modalidad,
                    t.Marca,
                    t.Poliza,
                    t.FechaIngreso.ToString("dd/MM/yyyy HH:mm"),
                    t.Estado);

                dgvRecepciones.Rows[fila].Tag = i;
            }

            dgvRecepciones.ClearSelection();
        }

        private bool CoincideFiltro(Tramite t, string criterio)
        {
            return Contiene(t.Chasis, criterio)
                || Contiene(t.Cliente, criterio)
                || Contiene(t.Poliza, criterio)
                || Contiene(t.NroContrato, criterio)
                || Contiene(t.NroTramite, criterio)
                || Contiene(t.NitCi, criterio)
                || Contiene(t.Marca, criterio)
                || Contiene(t.Estado, criterio);
        }

        private bool Contiene(string origen, string texto)
        {
            if (string.IsNullOrEmpty(origen)) return false;
            return origen.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        private void dgvRecepciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvRecepciones.Rows[e.RowIndex].Tag == null)
                return;

            int posReal = (int)dgvRecepciones.Rows[e.RowIndex].Tag;
            string mensaje;
            Tramite tramite = recepciones.ObtenerParaEditar(posReal, out mensaje);

            if (tramite == null)
            {
                MostrarAviso(mensaje, EstiloUI.AvisoAlertaFondo, EstiloUI.AvisoAlertaBorde, EstiloUI.AvisoAlertaTexto);
                limpiarFormulario();
                return;
            }

            OcultarAviso();
            indiceSeleccionado = posReal;
            tramiteActual = tramite.NroTramite;
            mostrarDatosEditar(tramite);

            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = (tramite.Estado == Tramites.Recibido);
        }
        #endregion

        #region "ACCIONES CRUD E IMPORTACION EXCEL"
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensajeError;
            Control controlConError;
            if (!ValidarCamposTramite(out mensajeError, out controlConError))
            {
                MostrarAviso(mensajeError, EstiloUI.AvisoAlertaFondo, EstiloUI.AvisoAlertaBorde, EstiloUI.AvisoAlertaTexto);
                if (controlConError != null) controlConError.Focus();
                return;
            }

            Tramite nuevoTramite = ArmarObjetoDesdeFormulario();
            nuevoTramite.DespachoAlcaldia = false;

            List<KeyValuePair<string, string>> errores = recepciones.GuardarRecepcion(nuevoTramite);
            if (errores.Count > 0)
            {
                MostrarAviso(errores[0].Value, EstiloUI.AvisoAlertaFondo, EstiloUI.AvisoAlertaBorde, EstiloUI.AvisoAlertaTexto);
                return;
            }

            mostrarRecepciones(txtBuscar.Text);
            limpiarFormulario();
            MostrarAviso("Registro guardado exitosamente.", EstiloUI.AvisoOkFondo, EstiloUI.AvisoOkBorde, EstiloUI.AvisoOkTexto);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (indiceSeleccionado < 0 || string.IsNullOrWhiteSpace(tramiteActual))
            {
                MostrarAviso("Selecciona un trámite de la tabla para modificar.", EstiloUI.AvisoAlertaFondo, EstiloUI.AvisoAlertaBorde, EstiloUI.AvisoAlertaTexto);
                return;
            }

            string mensajeError;
            Control controlConError;
            if (!ValidarCamposTramite(out mensajeError, out controlConError))
            {
                MostrarAviso(mensajeError, EstiloUI.AvisoAlertaFondo, EstiloUI.AvisoAlertaBorde, EstiloUI.AvisoAlertaTexto);
                if (controlConError != null) controlConError.Focus();
                return;
            }

            Tramite datosEditados = ArmarObjetoDesdeFormulario();
            string msgNegocio;

            if (recepciones.EditarRecepcion(datosEditados, out msgNegocio))
            {
                mostrarRecepciones(txtBuscar.Text);
                limpiarFormulario();
                MostrarAviso("Actualización exitosa.", EstiloUI.AvisoOkFondo, EstiloUI.AvisoOkBorde, EstiloUI.AvisoOkTexto);
            }
            else
            {
                MostrarAviso(string.IsNullOrWhiteSpace(msgNegocio) ? "No se pudo actualizar." : msgNegocio,
                    EstiloUI.AvisoAlertaFondo, EstiloUI.AvisoAlertaBorde, EstiloUI.AvisoAlertaTexto);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (indiceSeleccionado < 0)
            {
                MostrarAviso("Seleccione un trámite para eliminar.", EstiloUI.AvisoAlertaFondo, EstiloUI.AvisoAlertaBorde, EstiloUI.AvisoAlertaTexto);
                return;
            }

            DialogResult result = MessageBox.Show(
                "¿Está seguro de que desea eliminar el trámite seleccionado?",
                "GDCON Legal System",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            string msgError;
            if (recepciones.EliminarRecepcion(indiceSeleccionado, out msgError))
            {
                mostrarRecepciones(txtBuscar.Text);
                limpiarFormulario();
                MostrarAviso("Trámite eliminado correctamente.", EstiloUI.AvisoOkFondo, EstiloUI.AvisoOkBorde, EstiloUI.AvisoOkTexto);
            }
            else
            {
                MostrarAviso(msgError, EstiloUI.AvisoAlertaFondo, EstiloUI.AvisoAlertaBorde, EstiloUI.AvisoAlertaTexto);
            }
        }

        private void btnImportarExcel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Seleccionar archivo Excel de trámites";
                dlg.Filter = "Archivos de Excel (*.xlsx;*.xlsm)|*.xlsx;*.xlsm|Todos los archivos (*.*)|*.*";
                dlg.Multiselect = false;

                if (dlg.ShowDialog(this) != DialogResult.OK)
                    return;

                string empresaSeleccionada = cmbEmpresa.SelectedItem != null
                    ? cmbEmpresa.SelectedItem.ToString()
                    : "IMCRUZ";

                DialogResult respuestaDespacho = MessageBox.Show(
                    "Se importarán los trámites para la empresa '" + empresaSeleccionada + "'.\n\n" +
                    "¿Deseas despachar automáticamente los trámites completos a Alcaldía y Diprove?\n\n" +
                    "• Sí: importa y despacha (quedan listos en Placas y Pagos).\n" +
                    "• No: importa únicamente en estado 'Recibido'.\n" +
                    "• Cancelar: cancela la importación.",
                    "Importar desde Excel — GDCON Legal System",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (respuestaDespacho == DialogResult.Cancel)
                    return;

                bool despachar = (respuestaDespacho == DialogResult.Yes);

                try
                {
                    Cursor = Cursors.WaitCursor;
                    ResultadoImportacionExcel resultado = GestorExcel.ImportarTramites(
                        dlg.FileName,
                        empresaSeleccionada,
                        despachar);

                    txtBuscar.Text = "";
                    mostrarRecepciones();
                    limpiarFormulario();

                    if (resultado.Importados > 0)
                    {
                        MostrarAviso(
                            "Importados: " + resultado.Importados + " | Omitidos: " + resultado.Omitidos,
                            EstiloUI.AvisoOkFondo, EstiloUI.AvisoOkBorde, EstiloUI.AvisoOkTexto);
                    }
                    else
                    {
                        MostrarAviso(
                            "No se importaron registros nuevos (omitidos: " + resultado.Omitidos + ").",
                            EstiloUI.AvisoAlertaFondo, EstiloUI.AvisoAlertaBorde, EstiloUI.AvisoAlertaTexto);
                    }

                    MessageBox.Show(
                        resultado.ConstruirResumen(),
                        "GDCON Legal System",
                        MessageBoxButtons.OK,
                        resultado.Importados > 0 ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MostrarAviso("Error al importar el archivo Excel.", EstiloUI.AvisoAlertaFondo, EstiloUI.AvisoAlertaBorde, EstiloUI.AvisoAlertaTexto);
                    MessageBox.Show(
                        "No se pudo importar el archivo Excel:\n" + ex.Message,
                        "GDCON Legal System",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    Cursor = Cursors.Default;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = txtBuscar.Text.Trim();
            if (criterio == "")
            {
                mostrarRecepciones();
                OcultarAviso();
                return;
            }

            mostrarRecepciones(criterio);
            if (dgvRecepciones.Rows.Count == 0)
            {
                MostrarAviso("No se encontraron trámites con ese criterio.", EstiloUI.AvisoInfoFondo, EstiloUI.AvisoInfoBorde, EstiloUI.AvisoInfoTexto);
                txtBuscar.Text = "";
                mostrarRecepciones();
            }
            else
            {
                OcultarAviso();
            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnBuscar_Click(sender, e);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            mostrarRecepciones();
            limpiarFormulario();
            OcultarAviso();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
            OcultarAviso();
            txtChasis.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region "FORMULARIO Y VALIDACIONES"
        private void mostrarDatosEditar(Tramite tramite)
        {
            if (tramite == null) return;

            errorProvider1.Clear();
            bool esRecibido = tramite.Estado == Tramites.Recibido;

            txtChasis.Text = tramite.Chasis ?? "";
            txtContrato.Text = tramite.NroContrato ?? "";
            txtDocumento.Text = tramite.NitCi ?? "";
            txtPropietario.Text = tramite.Cliente ?? "";
            cbMarca.Text = tramite.Marca ?? "";
            txtClase.Text = tramite.Clase ?? "";
            txtTipoVehiculo.Text = tramite.TipoVehiculo ?? "";
            txtPoliza.Text = tramite.Poliza ?? "";
            txtYear.Text = tramite.Anio ?? "";
            txtColor.Text = tramite.Color ?? "";

            rbContado.Checked = string.Equals(tramite.Modalidad, "Contado", StringComparison.OrdinalIgnoreCase);
            rbCredito.Checked = string.Equals(tramite.Modalidad, "Crédito", StringComparison.OrdinalIgnoreCase)
                             || string.Equals(tramite.Modalidad, "Credito", StringComparison.OrdinalIgnoreCase);

            if (!string.IsNullOrWhiteSpace(tramite.Empresa))
            {
                int idx = cmbEmpresa.FindStringExact(tramite.Empresa);
                if (idx >= 0) cmbEmpresa.SelectedIndex = idx;
                else
                {
                    cmbEmpresa.Items.Add(tramite.Empresa);
                    cmbEmpresa.SelectedItem = tramite.Empresa;
                }
            }

            chkDespacho.Checked = tramite.DespachoAlcaldia || tramite.Estado != Tramites.Recibido;
            chkDespacho.Enabled = esRecibido;
            chkDespacho.Visible = true;

            AplicarSoloLecturaCampo(txtChasis, !esRecibido);
            AplicarSoloLecturaCampo(txtPoliza, !esRecibido);
            rbContado.Enabled = esRecibido;
            rbCredito.Enabled = esRecibido;
            cmbEmpresa.Enabled = esRecibido;
        }

        private void limpiarFormulario()
        {
            indiceSeleccionado = -1;
            tramiteActual = "";
            errorProvider1.Clear();

            txtChasis.Clear();
            txtContrato.Clear();
            txtDocumento.Clear();
            txtPropietario.Clear();
            cbMarca.SelectedIndex = -1;
            cbMarca.Text = "";
            txtClase.Clear();
            txtTipoVehiculo.Clear();
            txtPoliza.Clear();
            txtYear.Clear();
            txtColor.Clear();
            rbContado.Checked = false;
            rbCredito.Checked = false;

            if (cmbEmpresa.Items.Count > 0)
                cmbEmpresa.SelectedIndex = 0;

            chkDespacho.Checked = false;
            chkDespacho.Enabled = true;
            chkDespacho.Visible = false;

            AplicarSoloLecturaCampo(txtChasis, false);
            AplicarSoloLecturaCampo(txtPoliza, false);
            rbContado.Enabled = true;
            rbCredito.Enabled = true;
            cmbEmpresa.Enabled = true;

            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

            dgvRecepciones.ClearSelection();
        }

        private void AplicarSoloLecturaCampo(TextBox txt, bool soloLectura)
        {
            txt.ReadOnly = soloLectura;
            txt.BackColor = soloLectura ? EstiloUI.SoloLecturaFondo : EstiloUI.EditableFondo;
            txt.ForeColor = soloLectura ? EstiloUI.SoloLecturaTexto : EstiloUI.EditableTexto;
        }

        private void MostrarAviso(string texto, Color fondo, Color borde, Color colorTexto)
        {
            pnlAviso.BackColor = fondo;
            pnlBordeAviso.BackColor = borde;
            lblAviso.ForeColor = colorTexto;
            lblAviso.Text = texto;
            lblAviso.Visible = true;
            pnlAviso.Visible = true;
        }

        private void OcultarAviso()
        {
            pnlAviso.Visible = false;
            lblAviso.Visible = false;
        }

        private Tramite ArmarObjetoDesdeFormulario()
        {
            string empresa = cmbEmpresa.SelectedItem != null ? cmbEmpresa.SelectedItem.ToString() : "IMCRUZ";
            string modalidad = recepciones.obtenerContrato(rbContado, rbCredito);

            return new Tramite
            {
                NroTramite = tramiteActual,
                Empresa = empresa,
                NroContrato = txtContrato.Text.Trim(),
                Chasis = txtChasis.Text.Trim().ToUpperInvariant(),
                NitCi = txtDocumento.Text.Trim(),
                Cliente = txtPropietario.Text.Trim(),
                Marca = cbMarca.Text.Trim().ToUpperInvariant(),
                Clase = txtClase.Text.Trim().ToUpperInvariant(),
                TipoVehiculo = txtTipoVehiculo.Text.Trim(),
                Poliza = txtPoliza.Text.Trim(),
                Anio = txtYear.Text.Trim(),
                Color = txtColor.Text.Trim(),
                Modalidad = modalidad,
                Honorario = empresas.Honorario(empresa, modalidad),
                DespachoAlcaldia = chkDespacho.Checked
            };
        }

        private bool ValidarCamposTramite(out string mensajeError, out Control controlConError)
        {
            errorProvider1.Clear();
            controlConError = null;

            var reglas = new (Control control, string valor, string mensaje)[]
            {
                (txtChasis, txtChasis.Text, "Ingrese el número de chasis."),
                (txtContrato, txtContrato.Text, "Ingrese el número de contrato."),
                (txtDocumento, txtDocumento.Text, "Ingrese el NIT o CI."),
                (txtPropietario, txtPropietario.Text, "Ingrese el nombre del propietario o cliente."),
                (cbMarca, cbMarca.Text, "Seleccione o ingrese la marca."),
                (txtClase, txtClase.Text, "Ingrese la clase del vehículo."),
                (txtTipoVehiculo, txtTipoVehiculo.Text, "Ingrese el tipo de vehículo."),
                (txtPoliza, txtPoliza.Text, "Ingrese el número de póliza."),
                (txtYear, txtYear.Text, "Ingrese el año del vehículo."),
                (txtColor, txtColor.Text, "Ingrese el color del vehículo.")
            };

            foreach (var regla in reglas)
            {
                if (string.IsNullOrWhiteSpace(regla.valor))
                {
                    errorProvider1.SetError(regla.control, regla.mensaje);
                    mensajeError = regla.mensaje;
                    controlConError = regla.control;
                    return false;
                }
            }

            if (!rbContado.Checked && !rbCredito.Checked)
            {
                errorProvider1.SetError(rbCredito, "Seleccione la modalidad (Contado o Crédito).");
                mensajeError = "Seleccione la modalidad (Contado o Crédito).";
                controlConError = rbContado;
                return false;
            }

            if (cmbEmpresa.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbEmpresa, "Seleccione la empresa.");
                mensajeError = "Seleccione la empresa.";
                controlConError = cmbEmpresa;
                return false;
            }

            mensajeError = string.Empty;
            return true;
        }
        #endregion
    }
}