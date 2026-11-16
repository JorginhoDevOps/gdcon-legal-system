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
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.OpenForms["FrmLogin"].Show();

            this.Close();
        }

        private void btnPlacas_Click(object sender, EventArgs e)
        {
            // 1. Verificamos si el formulario ya está abierto para no abrirlo dos veces
            Form formularioAbierto = Application.OpenForms["FrmPlacasPagos"];

            if (formularioAbierto != null)
            {
                // Si ya está abierto, lo traemos al frente
                formularioAbierto.BringToFront();
            }
            else
            {
                // Si no está abierto, creamos uno nuevo
                FrmPlacasPagos frmPlacas = new FrmPlacasPagos();

                // Le decimos que su "padre" es este Menú Principal (MDI)
                frmPlacas.MdiParent = this;

                // Le quitamos el marco de arriba para que parezca incrustado
                frmPlacas.FormBorderStyle = FormBorderStyle.None;
                frmPlacas.Dock = DockStyle.Fill;

                // Lo mostramos
                frmPlacas.Show();
            }
        }

        private void btnPagosBanco_Click(object sender, EventArgs e)
        {
            // 1. Verificamos si el formulario ya está abierto
            Form formularioAbierto = Application.OpenForms["FrmListadoBanco"];

            if (formularioAbierto != null)
            {
                // Si ya está abierto, lo traemos al frente
                formularioAbierto.BringToFront();
            }
            else
            {
                // Si no está abierto, creamos la instancia
                FrmListadoBanco frmBanco = new FrmListadoBanco();

                // Le indicamos que su contenedor principal es este Menú (MDI)
                frmBanco.MdiParent = this;

                // Configuramos bordes y relleno para que encaje perfecto
                frmBanco.FormBorderStyle = FormBorderStyle.None;
                frmBanco.Dock = DockStyle.Fill;

                // Lo mostramos en pantalla
                frmBanco.Show();
            }
        }

        private void FrmMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
