using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmActaCredito : Form
    {
        public FrmActaCredito()
        {
            InitializeComponent();
            CargarEjemplo();
        }

        // Datos de EJEMPLO (ficticios). Luego se reemplazan por los del trámite entregado.
        private void CargarEjemplo()
        {
            lblClienteV.Text = "Cliente de ejemplo";
            lblNitCiV.Text = "0000000";
            lblNitCiFirma.Text = "NIT/CI: 0000000";
            lblPlaca.Text = "Placa: 1234ABC";
            lblModelo.Text = "Modelo: EJEMPLO";
            lblMarca.Text = "Marca: EJEMPLO";
            lblColor.Text = "Color: BLANCO";
            lblClase.Text = "Clase: CAMIONETA";
            lblChasis.Text = "Chasis: CHASIS-EJEMPLO-001";
            lblDoc4.Text = "4. PAR DE PLACAS N° 1234ABC (Original)";
            // QR: se genera con QRCoder (paso de NuGet) y se asigna a picQr.Image
        }

        private PrintDocument CrearDocumento()
        {
            var doc = new PrintDocument();
            doc.PrintPage += (s, e) =>
            {
                using (var bmp = new Bitmap(pnlHoja.Width, pnlHoja.Height))
                {
                    pnlHoja.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                    float esc = Math.Min((float)e.MarginBounds.Width / bmp.Width,
                                         (float)e.MarginBounds.Height / bmp.Height);
                    e.Graphics.DrawImage(bmp, e.MarginBounds.X, e.MarginBounds.Y,
                                         bmp.Width * esc, bmp.Height * esc);
                }
                e.HasMorePages = false;
            };
            return doc;
        }

        private void tsbImprimir_Click(object sender, EventArgs e)
        {
            var doc = CrearDocumento();
            using (var dlg = new PrintDialog { Document = doc })
                if (dlg.ShowDialog() == DialogResult.OK) doc.Print();
        }

        private void tsbVistaPrevia_Click(object sender, EventArgs e)
        {
            using (var dlg = new PrintPreviewDialog { Document = CrearDocumento(), Width = 900, Height = 720 })
                dlg.ShowDialog();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            var menu = this.ParentForm as FrmMenuPrincipal;
            if (menu != null)
                menu.AbrirFormulario(new FrmEntregaFinal());
            else
                this.Close();
        }
    }
}
