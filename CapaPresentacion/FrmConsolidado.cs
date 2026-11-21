using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmConsolidado : Form
    {
        public FrmConsolidado()
        {
            InitializeComponent();
            lblFecha.Text = "Fecha: " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void tsbImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enviando listado consolidado a impresión...", "GDCON Legal System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsbVistaPrevia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vista previa lista para impresión.", "GDCON Legal System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}