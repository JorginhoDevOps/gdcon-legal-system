using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using CapaNegocio;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace CapaPresentacion
{
    public partial class FrmConsolidado : Form
    {
        private readonly Tramites tramites = new Tramites();

        public FrmConsolidado()
        {
            InitializeComponent();
            AgregarBotonPdf();
            EstiloUI.SoloBarra(this);
            ConfigurarGrillas();
            lblFecha.Text = "Fecha: " + DateTime.Now.ToString("dd/MM/yyyy");
            CargarEntregados();
        }

        private void AgregarBotonPdf()
        {
            ToolStripButton tsbPdf = new ToolStripButton();
            tsbPdf.Name = "tsbExportarPdf";
            tsbPdf.Text = "Exportar PDF";
            tsbPdf.ToolTipText = "Exportar listado consolidado de entrega en PDF";
            tsbPdf.Image = Properties.Resources.PDF;
            tsbPdf.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            tsbPdf.TextImageRelation = TextImageRelation.ImageBeforeText;
            tsbPdf.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            tsbPdf.Click += tsbExportarPdf_Click;

            int idx = tsBarra.Items.IndexOf(tsbVistaPrevia);
            if (idx >= 0)
                tsBarra.Items.Insert(idx + 1, tsbPdf);
            else
                tsBarra.Items.Add(tsbPdf);
        }

        private void ConfigurarGrillas()
        {
            foreach (DataGridView dgv in new[] { dgvContado, dgvCredito })
            {
                dgv.ReadOnly = true;
                dgv.AllowUserToAddRows = false;
                dgv.AllowUserToDeleteRows = false;
                dgv.MultiSelect = false;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        private void CargarEntregados()
        {
            dgvContado.Rows.Clear();
            dgvCredito.Rows.Clear();

            tramites.Archivo_VectorTramites();
            List<int> posiciones = tramites.Posiciones(Tramites.Entregado);

            int nContado = 0;
            int nCredito = 0;

            foreach (int p in posiciones)
            {
                Tramite t = tramites.Obtener(p);
                if (t == null) continue;

                string receptor = string.IsNullOrWhiteSpace(t.EntregadoA) ? "" : t.EntregadoA;
                bool esCredito = string.Equals((t.Modalidad ?? "").Trim(), "Crédito", StringComparison.OrdinalIgnoreCase)
                              || string.Equals((t.Modalidad ?? "").Trim(), "Credito", StringComparison.OrdinalIgnoreCase);

                if (esCredito)
                {
                    nCredito++;
                    dgvCredito.Rows.Add(
                        nCredito.ToString(),
                        t.Cliente ?? "",
                        t.Chasis ?? "",
                        t.Placa ?? "",
                        receptor);
                }
                else
                {
                    nContado++;
                    dgvContado.Rows.Add(
                        nContado.ToString(),
                        t.Cliente ?? "",
                        t.Chasis ?? "",
                        t.Placa ?? "",
                        receptor);
                }
            }

            dgvContado.ClearSelection();
            dgvCredito.ClearSelection();
            lblTotalEntregados.Text = "Total entregados: " + TotalRegistros();
        }

        private int TotalRegistros()
        {
            return dgvContado.Rows.Count + dgvCredito.Rows.Count;
        }

        private Bitmap CapturarHoja()
        {
            dgvContado.ClearSelection();
            dgvCredito.ClearSelection();
            pnlHoja.Refresh();
            Bitmap bmp = new Bitmap(pnlHoja.Width, pnlHoja.Height);
            pnlHoja.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            return bmp;
        }

        private PrintDocument CrearDocumento()
        {
            var doc = new PrintDocument();
            doc.DocumentName = "Listado_Entrega_" + DateTime.Now.ToString("yyyy-MMdd");
            doc.DefaultPageSettings.Landscape = true;
            doc.PrintPage += (s, e) =>
            {
                using (var bmp = CapturarHoja())
                {
                    float esc = Math.Min((float)e.MarginBounds.Width / bmp.Width,
                                         (float)e.MarginBounds.Height / bmp.Height);
                    float anchoFinal = bmp.Width * esc;
                    float altoFinal = bmp.Height * esc;
                    float x = e.MarginBounds.X + (e.MarginBounds.Width - anchoFinal) / 2f;
                    e.Graphics.DrawImage(bmp, x, e.MarginBounds.Y, anchoFinal, altoFinal);
                }
                e.HasMorePages = false;
            };
            return doc;
        }

        private void ExportarHojaPdf(string rutaArchivo)
        {
            using (Bitmap bmp = CapturarHoja())
            using (MemoryStream ms = new MemoryStream())
            {
                bmp.Save(ms, ImageFormat.Png);
                ms.Position = 0;

                using (PdfDocument pdf = new PdfDocument())
                {
                    pdf.Info.Title = "Listado Consolidado de Entrega - " + DateTime.Now.ToString("dd/MM/yyyy");
                    PdfPage pagina = pdf.AddPage();
                    pagina.Size = PageSize.Letter;
                    pagina.Orientation = PageOrientation.Landscape;

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

        private void tsbImprimir_Click(object sender, EventArgs e)
        {
            if (TotalRegistros() == 0)
            {
                MessageBox.Show("No hay trámites entregados para imprimir.", "GDCON Legal System",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var doc = CrearDocumento();
            using (var dlg = new PrintDialog { Document = doc })
                if (dlg.ShowDialog() == DialogResult.OK) doc.Print();
        }

        private void tsbVistaPrevia_Click(object sender, EventArgs e)
        {
            if (TotalRegistros() == 0)
            {
                MessageBox.Show("No hay trámites entregados para previsualizar.", "GDCON Legal System",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (var dlg = new PrintPreviewDialog { Document = CrearDocumento(), Width = 1000, Height = 720 })
                dlg.ShowDialog();
        }

        private void tsbExportarPdf_Click(object sender, EventArgs e)
        {
            if (TotalRegistros() == 0)
            {
                MessageBox.Show("No hay trámites entregados para exportar a PDF.", "GDCON Legal System",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Title = "Guardar Listado Consolidado de Entrega en PDF";
                dlg.Filter = "Archivo PDF (*.pdf)|*.pdf";
                dlg.FileName = "Listado_Entrega_" + DateTime.Now.ToString("yyyy-MMdd") + ".pdf";
                if (dlg.ShowDialog(this) != DialogResult.OK) return;

                try
                {
                    ExportarHojaPdf(dlg.FileName);
                    MessageBox.Show("Listado exportado correctamente en PDF:\n" + dlg.FileName,
                        "GDCON Legal System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo generar el PDF:\n" + ex.Message,
                        "GDCON Legal System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}