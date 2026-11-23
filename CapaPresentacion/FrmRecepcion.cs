using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmRecepcion : Form
    {
        public FrmRecepcion()
        {
            InitializeComponent();
            EstiloUI.Aplicar(this, 1, 2);
        }

        private void FrmRecepcion_Load(object sender, EventArgs e)
        {

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
    }
}
