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
        public FrmRecepcion()
        {
            InitializeComponent();
        }
        Recepciones recepciones = new Recepciones();

        private void FrmRecepcion_Load(object sender, EventArgs e)
        {
            recepciones.cargarDocumento();
            recepciones.mostrarRecepciones(dgvRecepciones);
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
            recepciones.incrementar();
            Recepcion nuevaRecepcion = new Recepcion();

            nuevaRecepcion.chasis = txtChasis.Text;
            nuevaRecepcion.nroContrato = txtContrato.Text;
            nuevaRecepcion.documento = txtDocumento.Text;
            nuevaRecepcion.cliente = txtPropietario.Text;
            nuevaRecepcion.marca = cbMarca.Text;
            nuevaRecepcion.clase = txtClase.Text;
            nuevaRecepcion.tipoVehiculo = txtTipoVehiculo.Text;
            nuevaRecepcion.poliza = txtPoliza.Text;
            nuevaRecepcion.year = (txtYear.Text);
            nuevaRecepcion.color = txtColor.Text;
            nuevaRecepcion.modalidad = recepciones.obtenerContrato(rbContado, rbCredito);
            nuevaRecepcion.ingreso = dtpIngreso.Value;
            nuevaRecepcion.despachoAlcaldia = chkDespacho.Checked;
            nuevaRecepcion.status = "test";
            recepciones.guardar(nuevaRecepcion);
            recepciones.mostrarRecepciones(dgvRecepciones);
            recepciones.guardarDocumento();
        }
    }
}
