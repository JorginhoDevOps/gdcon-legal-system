using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmRecepcion : Form
    {
        int indiceSeleccionado = -1;
        bool modoEdicion = false;
        public FrmRecepcion()
        {
            InitializeComponent();
            EstiloUI.Aplicar(this, 1, 2);
            tramites.Archivo_VectorTramites();
        }
        Tramites tramites = new Tramites();
        Recepciones recepciones = new Recepciones();
        string tramiteActual = "";
        private ErrorProvider errorProvider1 = new ErrorProvider();


        private void FrmRecepcion_Load(object sender, EventArgs e)
        {
            mostrarRecepciones();
            chkDespacho.Visible = false;
            pnlAviso.Visible = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnPanelGeneral_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal menu = new FrmMenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void btnPlacas_Click(object sender, EventArgs e)
        {
            FrmPlacasPagos placas = new FrmPlacasPagos();
            placas.Show();
            this.Hide();
        }

        private void btnDiprove_Click(object sender, EventArgs e)
        {
            FrmPlacasPagos placasPagos = new FrmPlacasPagos();
            placasPagos.Show();
            this.Hide();
        }

        private void tlpCampos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            tramites.Incrementar();
            Tramite nuevoTramite = new Tramite();

            nuevoTramite.Chasis = txtChasis.Text;
            nuevoTramite.NroContrato = txtContrato.Text;
            nuevoTramite.NitCi = txtDocumento.Text;
            nuevoTramite.Cliente = txtPropietario.Text;
            nuevoTramite.Marca = cbMarca.Text;
            nuevoTramite.Clase = txtClase.Text;
            nuevoTramite.TipoVehiculo = txtTipoVehiculo.Text;
            nuevoTramite.Poliza = txtPoliza.Text;
            nuevoTramite.Anio = (txtYear.Text);
            nuevoTramite.Color = txtColor.Text;
            nuevoTramite.Modalidad = recepciones.obtenerContrato(rbContado, rbCredito);
            nuevoTramite.DespachoAlcaldia = chkDespacho.Checked;
            tramites.Guardar(nuevoTramite);

            mostrarRecepciones();
        }

        public void mostrarRecepciones()
        {
            List<Tramite> ListaTramites = recepciones.ObtenerTodos();
            dgvRecepciones.Rows.Clear();

            if (ListaTramites == null || ListaTramites.Count == 0)
                return;

            dgvRecepciones.RowCount = ListaTramites.Count;

            for (int V = 0; V < ListaTramites.Count; V++)
            {
                dgvRecepciones[0, V].Value = ListaTramites[V].Chasis;
                dgvRecepciones[1, V].Value = ListaTramites[V].Cliente;
                dgvRecepciones[2, V].Value = ListaTramites[V].Modalidad;
                dgvRecepciones[3, V].Value = ListaTramites[V].Marca;
                dgvRecepciones[4, V].Value = ListaTramites[V].Poliza;
                dgvRecepciones[5, V].Value = ListaTramites[V].FechaIngreso.ToString("dd/MM/yyyy HH:mm");
                dgvRecepciones[6, V].Value = ListaTramites[V].Estado;
            }
        }

        private void dgvRecepciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceSeleccionado = e.RowIndex;
            Tramite tramite = recepciones.ObtenerParaEditar(indiceSeleccionado, out string mensaje);
            if (tramite == null)
            {
                MostrarAviso("Edición de datos no permitida", PaletaColores.AvisoAlertaFondo, PaletaColores.AvisoAlertaBorde, PaletaColores.AvisoAlertaTexto);
                return;
            }
            OcultarAviso();
            mostrarDatosEditar(tramite);
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            tramiteActual = tramite.NroTramite;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            Tramite datosEditados = ArmarObjetoDesdeFormulario();

            if (recepciones.EditarRecepcion(datosEditados)) {
                MostrarAviso("Actualización exitosa", PaletaColores.AvisoOkFondo, PaletaColores.AvisoOkBorde, PaletaColores.AvisoOkTexto);
            }
            else
            {
                MostrarAviso("No se pudo actualizar", PaletaColores.AvisoAlertaFondo, PaletaColores.AvisoAlertaBorde, PaletaColores.AvisoAlertaTexto);

            }
            mostrarRecepciones();
            limpiarFormulario();
        }

        private void mostrarDatosEditar(Tramite tramite)
        {
            if (tramite != null)
            {
                txtChasis.Text = tramite.Chasis;
                txtContrato.Text = tramite.NroContrato;
                txtDocumento.Text = tramite.NitCi;
                txtPropietario.Text = tramite.Cliente;
                cbMarca.Text = tramite.Marca;
                txtClase.Text = tramite.Clase;
                txtTipoVehiculo.Text = tramite.TipoVehiculo;
                txtPoliza.Text = tramite.Poliza;
                txtYear.Text = tramite.Anio;
                txtColor.Text = tramite.Color;

                rbContado.Checked = tramite.Modalidad == "Contado";
                rbCredito.Checked = tramite.Modalidad == "Crédito";

                chkDespacho.Checked = tramite.DespachoAlcaldia;
                chkDespacho.Enabled = tramite.Estado == Tramites.Recibido;
                chkDespacho.Visible = true;
                txtChasis.ReadOnly = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (indiceSeleccionado >= 0)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar el trámite seleccionado?", "Confirmar eliminación", buttons, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    /*recepciones.Eliminar(indiceSeleccionado);
                    ListaTramites.RemoveAt(indiceSeleccionado);
                    actualizarGrilla();*/
                }
            }
            else
            {
                MostrarAviso("Seleccione un trámite para eliminar.", PaletaColores.AvisoAlertaFondo, PaletaColores.AvisoInfoBorde, PaletaColores.AvisoAlertaTexto);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
            txtChasis.ReadOnly = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
            chkDespacho.Visible = false;
            txtChasis.ReadOnly = false;
        }

        private void limpiarFormulario()
        {
            txtChasis.Clear();
            txtContrato.Clear();
            txtDocumento.Clear();
            txtPropietario.Clear();
            cbMarca.SelectedIndex = -1;
            txtClase.Clear();
            txtTipoVehiculo.Clear();
            txtPoliza.Clear();
            txtYear.Clear();
            txtColor.Clear();
            rbContado.Checked = false;
            rbCredito.Checked = false;
            chkDespacho.Checked = false;
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
            return new Tramite
            {
                NroTramite = tramiteActual,
                Chasis = txtChasis.Text.Trim(),
                NitCi = txtDocumento.Text.Trim(),
                Cliente = txtPropietario.Text.Trim(),
                Marca = cbMarca.Text.Trim(),
                Clase = txtClase.Text.Trim(),
                TipoVehiculo = txtTipoVehiculo.Text.Trim(),
                Poliza = txtPoliza.Text.Trim(),
                Anio = txtYear.Text.Trim(),
                Color = txtColor.Text.Trim(),
                Modalidad = rbContado.Checked ? "Contado" : "Crédito",
                Estado = (chkDespacho.Checked == true) ? "Despachado" : "Recibido"
            };
        }
    }
}
