using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmListadoDespacho : Form
    {
        public FrmListadoDespacho()
        {
            InitializeComponent();
            lblFecha.Text = "Fecha: " + DateTime.Now.ToString("dd/MM/yyyy");
            CargarEjemplo();
        }

        // Datos de EJEMPLO (ficticios). Luego vendrán de los trámites registrados en Recepción.
        private void CargarEjemplo()
        {
            dgvContado.Rows.Clear();
            dgvCredito.Rows.Clear();

            dgvContado.Rows.Add("1", "Cliente de ejemplo 1", "CHASIS-EJEMPLO-001", "POL-0001", "Alcaldía / Diprove");
            dgvContado.Rows.Add("2", "Cliente de ejemplo 2", "CHASIS-EJEMPLO-002", "POL-0002", "Alcaldía / Diprove");
            dgvCredito.Rows.Add("1", "Cliente de ejemplo 3", "CHASIS-EJEMPLO-003", "POL-0003", "Alcaldía / Diprove");

            ActualizarTotal();
        }

        private void ActualizarTotal()
        {
            lblTotalDespachados.Text = "Total despachados: " + (dgvContado.Rows.Count + dgvCredito.Rows.Count);
        }

        // ---------- Impresión ----------
        private PrintDocument CrearDocumento()
        {
            var doc = new PrintDocument();
            doc.DefaultPageSettings.Landscape = true;
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
            using (var dlg = new PrintPreviewDialog { Document = CrearDocumento(), Width = 1000, Height = 720 })
                dlg.ShowDialog();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
