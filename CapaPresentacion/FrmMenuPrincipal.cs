using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing;

namespace CapaPresentacion
{
    public partial class FrmMenuPrincipal : Form
    {
        private Form formularioActual;
        private bool cerrandoSesion;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            BarraTitulo.Aplicar(this, Color.White, Color.FromArgb(9, 26, 58));
        }

        // Muestra un formulario dentro del panel contenedor
        public void AbrirFormulario(Form frm)
        {
            if (formularioActual != null) formularioActual.Close();
            formularioActual = frm;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.FormClosed += (s, e) =>
            {
                if (formularioActual == frm)
                {
                    formularioActual = null;
                    MostrarPanelGeneral();
                }
            };
            pnlPanelGeneral.Visible = false;
            pnlContenedor.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void MostrarPanelGeneral()
        {
            pnlPanelGeneral.Visible = true;
            pnlPanelGeneral.BringToFront();
        }

        private void btnPanelGeneral_Click(object sender, EventArgs e)
        {
            if (formularioActual != null) formularioActual.Close();
            else MostrarPanelGeneral();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            cerrandoSesion = true;
            Application.OpenForms["FrmLogin"].Show();
            this.Close();
        }

        private void FrmMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!cerrandoSesion) Application.Exit();
        }

        private void btnEntrega_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmEntregaFinal());
        }

        private void btnPlacas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPlacasPagos());
        }

        private void btnPagosBanco_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmListadoBanco());
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmUsuarios());
        }

        private void btnListadoEntrega_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmConsolidado());
        }

        private void btnDiprove_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmTransito());
        }

        private void btnSeguimiento_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmSeguimiento());
        }

        private void btnListadoDespacho_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmListadoDespacho());
        }

        private void btnRecepcion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmRecepcion());
        }
    }
}