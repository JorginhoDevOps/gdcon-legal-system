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
    public partial class FrmEntregaFinal : Form
    {
        public FrmEntregaFinal()
        {
            InitializeComponent();
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbActa_Click(object sender, EventArgs e)
        {
            var menu = this.ParentForm as FrmMenuPrincipal;
            if (menu == null) return;

            if (cmbModalidad.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona la modalidad (Contado o Crédito).",
                    "GDCON Legal System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cmbModalidad.SelectedItem.ToString() == "Crédito")
                menu.AbrirFormulario(new FrmActaCredito());
            else
                menu.AbrirFormulario(new FrmActaContado());
        }
    }
}
