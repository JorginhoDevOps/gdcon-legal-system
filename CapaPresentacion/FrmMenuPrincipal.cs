using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmMenuPrincipal : Form
    {
        private Form formularioActual;
        private bool cerrandoSesion;

        // Colores del menú lateral
        private readonly Color colNormal = Color.FromArgb(9, 26, 58);
        private readonly Color colActivo = Color.FromArgb(20, 40, 75);
        private readonly Color colHover = Color.FromArgb(14, 33, 68);
        private readonly Color colTextoNormal = Color.White;
        private readonly Color colTextoActivo = Color.FromArgb(25, 193, 227);

        private Button[] botonesMenu;
        private Button botonActivo;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            BarraTitulo.Aplicar(this, Color.White, Color.FromArgb(9, 26, 58));

            botonesMenu = new Button[]
            {
                btnPanelGeneral, btnRecepcion, btnPlacas, btnDiprove, btnEntrega,
                btnSeguimiento, btnPagosBanco, btnListadoDespacho, btnListadoEntrega,
                btnConfiguracion
            };

            foreach (Button b in botonesMenu)
            {
                b.FlatAppearance.MouseOverBackColor = colHover;
                b.FlatAppearance.MouseDownBackColor = colActivo;
            }

            MarcarActivo(btnPanelGeneral);
        }

        // Pinta el botón elegido como activo y deja los demás normales
        private void MarcarActivo(Button activo)
        {
            if (activo == null) return;
            botonActivo = activo;

            foreach (Button b in botonesMenu)
            {
                bool esActivo = (b == activo);
                b.BackColor = esActivo ? colActivo : colNormal;
                b.ForeColor = esActivo ? colTextoActivo : colTextoNormal;
                b.Font = new Font(b.Font, esActivo ? FontStyle.Bold : FontStyle.Regular);
            }

            // La barrita celeste baja junto con el botón activo
            pnlIndicador.Top = activo.Top;
            pnlIndicador.Height = activo.Height;
            pnlIndicador.BringToFront();
        }

        // origen = botón del menú que abrió el formulario (opcional).
        // Si se abre desde otro formulario (ej. un acta), no se cambia el botón activo.
        public void AbrirFormulario(Form frm, Button origen = null)
        {
            Form anterior = formularioActual;
            formularioActual = null;            // evita que el cierre del anterior muestre el panel general
            if (anterior != null) anterior.Close();

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

            if (origen != null) MarcarActivo(origen);
        }

        private void MostrarPanelGeneral()
        {
            pnlPanelGeneral.Visible = true;
            pnlPanelGeneral.BringToFront();
            MarcarActivo(btnPanelGeneral);
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

        private void btnRecepcion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmRecepcion(), btnRecepcion);
        }

        private void btnPlacas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPlacasPagos(), btnPlacas);
        }

        private void btnDiprove_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmTransito(), btnDiprove);
        }

        private void btnEntrega_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmEntregaFinal(), btnEntrega);
        }

        private void btnSeguimiento_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmSeguimiento(), btnSeguimiento);
        }

        private void btnPagosBanco_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmListadoBanco(), btnPagosBanco);
        }

        private void btnListadoDespacho_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmListadoDespacho(), btnListadoDespacho);
        }

        private void btnListadoEntrega_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmConsolidado(), btnListadoEntrega);
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmUsuarios(), btnConfiguracion);
        }
    }
}
