using System;
using System.Collections.Generic;
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

namespace CapaPresentacion
{
    public partial class FrmListadoBanco : Form
    {
        private readonly Tramites tramites = new Tramites();
        private string codigoReporteActual = "";

        public FrmListadoBanco()
        {
            InitializeComponent();
            AgregarBotonPdf();
            EstiloUI.SoloBarra(this);

            ConfigurarControles();
            ConectarEventos();
            CargarDatosDesdeArchivo();
        }

        private void AgregarBotonPdf()
        {
            ToolStripButton tsbPdf = new ToolStripButton();
            tsbPdf.Name = "tsbExportarPdf";
            tsbPdf.Text = "Exportar PDF";
            tsbPdf.ToolTipText = "Exportar PDF";
            tsbPdf.Image = Properties.Resources.PDF;
            tsbPdf.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            tsbPdf.TextImageRelation = TextImageRelation.ImageBeforeText;
            tsbPdf.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            tsbPdf.Click += tsbExportarPdf_Click;
            tsAcciones.Items.Insert(2, tsbPdf);
        }

        private void ConfigurarControles()
        {
            dgvPagos.ReadOnly = true;
            dgvPagos.AllowUserToAddRows = false;
            dgvPagos.AllowUserToDeleteRows = false;
            dgvPagos.MultiSelect = false;
            dgvPagos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            ActualizarEncabezadoReporte();
        }

        private void ConectarEventos()
        {
            tsbImprimir.Click += tsbImprimir_Click;
            tsbVistaPrevia.Click += tsbVistaPrevia_Click;
            tsbLimpiar.Click += tsbLimpiar_Click;
            tsbBuscar.Click += tsbBuscar_Click;
            tsbCerrar.Click += tsbCerrar_Click;
            txtBuscar.KeyDown += txtBuscar_KeyDown;
        }

        private void ActualizarEncabezadoReporte()
        {
            DateTime hoy = DateTime.Now;
            codigoReporteActual = "BAN-" + hoy.ToString("yyyy-MMdd");
            lblCodigoReporte.Text = "Reporte N°: " + codigoReporteActual;
            lblFechaEmision.Text = "Fecha de emisión: " + hoy.ToString("dd/MM/yyyy");
        }

        private void CargarDatosDesdeArchivo()
        {
            tramites.Archivo_VectorTramites();
            CargarListado();
        }

        #region "LISTADO, FILTRO (SOBRECARGA) Y TOTAL (RECURSIVIDAD)"
        private void CargarListado()
        {
            CargarListado("");
        }

        private void CargarListado(string filtro)
        {
            dgvPagos.Rows.Clear();
            string criterio = (filtro ?? "").Trim();

            List<Tramite> pagados = ObtenerPagosFiltrados(criterio);

            for (int i = 0; i < pagados.Count; i++)
            {
                Tramite t = pagados[i];
                dgvPagos.Rows.Add(
                    (i + 1).ToString(),
                    t.Cliente ?? "",
                    t.Placa ?? "",
                    t.Modalidad ?? "",
                    t.MontoPago.ToString("N2", CultureInfo.InvariantCulture));
            }

            double total = CalcularTotalRecursivo(pagados, 0);
            lblMontoTotal.Text = "Bs " + total.ToString("N2", CultureInfo.InvariantCulture);
            dgvPagos.ClearSelection();
        }

        private List<Tramite> ObtenerPagosFiltrados(string criterio)
        {
            List<Tramite> resultado = new List<Tramite>();
            List<int> posiciones = tramites.Posiciones(
                Tramites.ConPlacaPago,
                Tramites.EnTransito,
                Tramites.Entregado);

            foreach (int p in posiciones)
            {
                Tramite t = tramites.Obtener(p);
                if (t == null || !t.PagoRealizado || t.MontoPago <= 0) continue;

                if (criterio != "" && !CoincideFiltro(t, criterio))
                    continue;

                resultado.Add(t);
            }

            return resultado;
        }

        private double CalcularTotalRecursivo(List<Tramite> lista, int indice)
        {
            if (lista == null || indice >= lista.Count)
                return 0;

            return lista[indice].MontoPago + CalcularTotalRecursivo(lista, indice + 1);
        }

        private bool CoincideFiltro(Tramite t, string criterio)
        {
            return Contiene(t.Cliente, criterio)
                || Contiene(t.Placa, criterio)
                || Contiene(t.Modalidad, criterio)
                || Contiene(t.Chasis, criterio)
                || Contiene(t.NroTramite, criterio)
                || Contiene(t.Comprobante, criterio)
                || Contiene(t.NitCi, criterio);
        }

        private bool Contiene(string origen, string texto)
        {
            if (string.IsNullOrEmpty(origen)) return false;
            return origen.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        private void Aviso(string msg, MessageBoxIcon icono)
        {
            MessageBox.Show(msg, "GDCON Legal System", MessageBoxButtons.OK, icono);
        }
        #endregion

        #region "IMPRESION Y EXPORTACION PDF"
        private Bitmap CapturarHoja()
        {
            dgvPagos.ClearSelection();
            pnlHoja.Refresh();

            Bitmap bmp = new Bitmap(pnlHoja.Width, pnlHoja.Height);
            pnlHoja.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            return bmp;
        }

        private PrintDocument CrearDocumento()
        {
            PrintDocument doc = new PrintDocument();
            doc.DocumentName = "Listado_Banco_" + codigoReporteActual;
            doc.DefaultPageSettings.Landscape = true;
            doc.PrintPage += (s, e) =>
            {
                using (Bitmap bmp = CapturarHoja())
                {
                    float esc = Math.Min(
                        (float)e.MarginBounds.Width / bmp.Width,
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
                    pdf.Info.Title = "Listado para el Banco - " + codigoReporteActual;
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
        #endregion

        #region "ACCIONES DE BARRA"
        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            string criterio = txtBuscar.Text.Trim();
            if (criterio == "")
            {
                CargarListado();
                return;
            }

            CargarListado(criterio);
            if (dgvPagos.Rows.Count == 0)
            {
                Aviso("No se encontraron pagos que coincidan con '" + criterio + "'.", MessageBoxIcon.Information);
                txtBuscar.Text = "";
                CargarListado();
            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                tsbBuscar_Click(sender, e);
            }
        }

        private void tsbLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            ActualizarEncabezadoReporte();
            CargarDatosDesdeArchivo();
        }

        private void tsbVistaPrevia_Click(object sender, EventArgs e)
        {
            if (dgvPagos.Rows.Count == 0)
            {
                Aviso("No hay pagos registrados para previsualizar.", MessageBoxIcon.Information);
                return;
            }

            using (PrintDocument doc = CrearDocumento())
            using (PrintPreviewDialog dlg = new PrintPreviewDialog { Document = doc, Width = 1000, Height = 720 })
            {
                dlg.ShowDialog(this);
            }
        }

        private void tsbImprimir_Click(object sender, EventArgs e)
        {
            if (dgvPagos.Rows.Count == 0)
            {
                Aviso("No hay pagos registrados para imprimir.", MessageBoxIcon.Information);
                return;
            }

            using (PrintDocument doc = CrearDocumento())
            using (PrintDialog dlg = new PrintDialog { Document = doc })
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                    doc.Print();
            }
        }

        private void tsbExportarPdf_Click(object sender, EventArgs e)
        {
            if (dgvPagos.Rows.Count == 0)
            {
                Aviso("No hay pagos registrados para exportar a PDF.", MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Title = "Guardar Listado para el Banco en PDF";
                dlg.Filter = "Archivo PDF (*.pdf)|*.pdf";
                dlg.FileName = "Listado_Banco_" + codigoReporteActual + ".pdf";

                if (dlg.ShowDialog(this) != DialogResult.OK) return;

                try
                {
                    ExportarHojaPdf(dlg.FileName);
                    Aviso("Listado exportado correctamente en PDF:\n" + dlg.FileName, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Aviso("No se pudo generar el PDF:\n" + ex.Message, MessageBoxIcon.Error);
                }
            }
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}