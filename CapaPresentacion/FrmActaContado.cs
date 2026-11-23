using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Windows.Forms;
using CapaNegocio;
using QRCoder;

namespace CapaPresentacion
{
    public partial class FrmActaContado : Form
    {
        public FrmActaContado()
        {
            InitializeComponent();
            EstiloUI.SoloBarra(this);
            CargarEjemplo();
        }

        public FrmActaContado(Tramite t) : this()
        {
            if (t != null) CargarTramite(t);
        }

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
            lblDoc9.Text = "9. PAR DE PLACAS N° 1234ABC (Originales)";
        }

        public void CargarTramite(Tramite t)
        {
            string placa = string.IsNullOrWhiteSpace(t.Placa) ? "S/P" : t.Placa;
            string modelo = ((t.TipoVehiculo ?? "") + " " + (t.Anio ?? "")).Trim();
            if (modelo == "") modelo = "-";

            if (!string.IsNullOrWhiteSpace(t.Empresa))
                lblLogo.Text = t.Empresa.ToUpper();

            lblClienteV.Text = string.IsNullOrWhiteSpace(t.Cliente) ? "-" : t.Cliente;
            lblNitCiV.Text = string.IsNullOrWhiteSpace(t.NitCi) ? "-" : t.NitCi;
            lblNitCiFirma.Text = "NIT/CI: " + (string.IsNullOrWhiteSpace(t.NitCi) ? "-" : t.NitCi);
            lblPlaca.Text = "Placa: " + placa;
            lblModelo.Text = "Modelo: " + modelo;
            lblMarca.Text = "Marca: " + (string.IsNullOrWhiteSpace(t.Marca) ? "-" : t.Marca);
            lblColor.Text = "Color: " + (string.IsNullOrWhiteSpace(t.Color) ? "-" : t.Color);
            lblClase.Text = "Clase: " + (string.IsNullOrWhiteSpace(t.Clase) ? "-" : t.Clase);
            lblChasis.Text = "Chasis: " + (string.IsNullOrWhiteSpace(t.Chasis) ? "-" : t.Chasis);
            lblDoc9.Text = "9. PAR DE PLACAS N° " + placa + " (Originales)";

            DateTime fecha = (t.FechaEntrega == DateTime.MinValue) ? DateTime.Now : t.FechaEntrega;
            lblLugarFecha.Text = "Santa Cruz, " + fecha.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("es-BO"));

            string datosQr = "GDCON | " + t.NroTramite + " | " + t.Empresa +
                             " | Chasis: " + t.Chasis + " | Placa: " + placa +
                             " | Modalidad: CONTADO | Cliente: " + t.Cliente;
            GenerarQr(datosQr);
        }

        private void GenerarQr(string texto)
        {
            using (QRCodeGenerator gen = new QRCodeGenerator())
            using (QRCodeData data = gen.CreateQrCode(texto, QRCodeGenerator.ECCLevel.Q))
            using (QRCode qr = new QRCode(data))
            {
                picQr.Image = qr.GetGraphic(5);
            }
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

        private void tsBarra_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
    }
}