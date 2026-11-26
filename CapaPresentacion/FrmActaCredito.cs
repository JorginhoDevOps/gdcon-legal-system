using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using CapaNegocio;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using QRCoder;

namespace CapaPresentacion
{
    public partial class FrmActaCredito : Form
    {
        private string nroTramiteActual = "EJEMPLO";

        public FrmActaCredito()
        {
            InitializeComponent();
            BloquearCasillasConformidad(pnlHoja);
            AgregarBotonPdf();
            EstiloUI.SoloBarra(this);
            CargarEjemplo();
        }
        private void BloquearCasillasConformidad(Control contenedor)
        {
            foreach (Control c in contenedor.Controls)
            {
                CheckBox chk = c as CheckBox;
                if (chk != null)
                {
                    chk.Checked = false;
                    chk.AutoCheck = false;
                    chk.TabStop = false;
                }
                if (c.HasChildren)
                    BloquearCasillasConformidad(c);
            }
        }

        public FrmActaCredito(Tramite t) : this()
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
            lblDoc4.Text = "4. PAR DE PLACAS N° 1234ABC (Original)";
        }

        public void CargarTramite(Tramite t)
        {
            if (!string.IsNullOrWhiteSpace(t.NroTramite))
                nroTramiteActual = t.NroTramite;

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
            lblDoc4.Text = "4. PAR DE PLACAS N° " + placa + " (Original)";

            DateTime fecha = (t.FechaEntrega == DateTime.MinValue) ? DateTime.Now : t.FechaEntrega;
            lblLugarFecha.Text = "Santa Cruz, " + fecha.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("es-BO"));

            DocumentoActa acta = new ActaCreditoDocumento(t);
            string datosQr = acta.ConstruirContenidoQr();
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

        private void AgregarBotonPdf()
        {
            ToolStripButton tsbPdf = new ToolStripButton();
            tsbPdf.Name = "tsbExportarPdf";
            tsbPdf.Text = "Exportar PDF";
            tsbPdf.Image = Properties.Resources.PDF;
            tsbPdf.Click += new EventHandler(tsbExportarPdf_Click);
            tsBarra.Items.Insert(2, tsbPdf);
        }

        private void tsbExportarPdf_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Title = "Guardar Acta de Entrega (Crédito) en PDF";
                dlg.Filter = "Archivo PDF (*.pdf)|*.pdf";
                dlg.FileName = "Acta_Credito_" + nroTramiteActual + ".pdf";

                if (dlg.ShowDialog() != DialogResult.OK) return;

                try
                {
                    ExportarHojaPdf(dlg.FileName);
                    MessageBox.Show("Acta exportada correctamente en PDF:\n" + dlg.FileName,
                        "GDCON Legal System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo generar el PDF:\n" + ex.Message,
                        "GDCON Legal System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ExportarHojaPdf(string rutaArchivo)
        {
            using (Bitmap bmp = new Bitmap(pnlHoja.Width, pnlHoja.Height))
            {
                pnlHoja.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));

                using (MemoryStream ms = new MemoryStream())
                {
                    bmp.Save(ms, ImageFormat.Png);
                    ms.Position = 0;

                    using (PdfDocument pdf = new PdfDocument())
                    {
                        pdf.Info.Title = "Acta de Entrega - " + nroTramiteActual;
                        PdfPage pagina = pdf.AddPage();
                        pagina.Size = PageSize.Letter;

                        using (XGraphics gfx = XGraphics.FromPdfPage(pagina))
                        using (XImage img = XImage.FromStream(ms))
                        {
                            double margen = 30;
                            double anchoDisp = pagina.Width.Point - (margen * 2);
                            double altoDisp = pagina.Height.Point - (margen * 2);
                            double escala = Math.Min(anchoDisp / img.PixelWidth, altoDisp / img.PixelHeight);

                            double anchoFinal = img.PixelWidth * escala;
                            double altoFinal = img.PixelHeight * escala;
                            double x = (pagina.Width.Point - anchoFinal) / 2;

                            gfx.DrawImage(img, x, margen, anchoFinal, altoFinal);
                        }

                        pdf.Save(rutaArchivo);
                    }
                }
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
    }
}