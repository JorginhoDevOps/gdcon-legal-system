using System;
using System.Drawing;
using System.Drawing.Drawing2D;
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
    public partial class FrmSeguimiento : Form
    {
        private readonly Tramites tramites = new Tramites();
        private Tramite tramiteActual = null;
        private Label[] circulos, nombres, fechas;
        private Panel[] lineas;
        private Timer tmrPlazo;
        private int anchoObjetivo;
        private DateTime inicioAnim;
        private const int DuracionMs = 700;

        public FrmSeguimiento()
        {
            InitializeComponent();
            AgregarBotonPdf();
            EstiloUI.SoloBarra(this);

            circulos = new[] { lblCirculo1, lblCirculo2, lblCirculo3, lblCirculo4, lblCirculo5 };
            nombres = new[] { lblPaso1, lblPaso2, lblPaso3, lblPaso4, lblPaso5 };
            fechas = new[] { lblFechaPaso1, lblFechaPaso2, lblFechaPaso3, lblFechaPaso4, lblFechaPaso5 };
            lineas = new[] { pnlLinea1, pnlLinea2, pnlLinea3, pnlLinea4 };

            foreach (Label c in circulos)
            {
                var gp = new GraphicsPath();
                gp.AddEllipse(0, 0, c.Width - 1, c.Height - 1);
                c.Region = new Region(gp);
            }

            foreach (Control p in new Control[] { pnlBuscar, panel1, pnlLineaTiempo })
                p.Resize += (s, e) => ((Control)s).Invalidate();
            pnlLineaTiempo.Resize += (s, e) => PosicionarLineaTiempo();

            dgvHistorial.ReadOnly = true;
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToDeleteRows = false;
            dgvHistorial.MultiSelect = false;
            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            bntBuscar.Click += bntBuscar_Click;
            txtBuscar.KeyDown += txtBuscar_KeyDown;

            tmrPlazo = new Timer { Interval = 15 };
            tmrPlazo.Tick += tmrPlazo_Tick;
            this.VisibleChanged += (s, e) => { if (this.Visible && tramiteActual != null) IniciarAnimacionPlazo(); };
            this.FormClosed += (s, e) => { if (tmrPlazo != null) tmrPlazo.Stop(); };

            PosicionarLineaTiempo();
            CargarUltimoTramite();
        }

        private void AgregarBotonPdf()
        {
            ToolStripButton tsbPdf = new ToolStripButton();
            tsbPdf.Name = "tsbExportarPdf";
            tsbPdf.Text = "Exportar PDF";
            tsbPdf.ToolTipText = "Exportar seguimiento en PDF";
            tsbPdf.Image = Properties.Resources.PDF;
            tsbPdf.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            tsbPdf.TextImageRelation = TextImageRelation.ImageBeforeText;
            tsbPdf.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            tsbPdf.Click += tsbExportarPdf_Click;

            int idx = tsAcciones.Items.IndexOf(tsbVistaPrevia);
            if (idx >= 0)
                tsAcciones.Items.Insert(idx + 1, tsbPdf);
            else
                tsAcciones.Items.Add(tsbPdf);
        }

        private void CargarUltimoTramite()
        {
            tramites.Archivo_VectorTramites();
            if (tramites.Cantidad() > 0)
                MostrarTramite(tramites.Obtener(tramites.Cantidad() - 1));
            else
                MostrarSinDatos();
        }

        private void MostrarSinDatos()
        {
            tramiteActual = null;
            lblTramite.Text = "Sin trámites registrados";
            lblClienteV.Text = "—";
            lblVehiculoV.Text = "—";
            lblPlacaV.Text = "—";
            llbModalidadV.Text = "—";
            label6.Text = "SIN DATOS";
            lblEstadoDetalle.Text = "Registra o importa trámites desde Recepción y Despacho";
            lblHoras.Text = "0 h 0 min";
            lblSemaforo.Text = "Sin plazo activo";
            lblHoras.ForeColor = EstiloUI.Gris;
            lblPuntoSemaforo.ForeColor = EstiloUI.Gris;
            pnlPlazoRelleno.Width = 0;
            anchoObjetivo = 0;

            MostrarPasos(0, new[] { "", "", "", "", "" });
            dgvHistorial.Rows.Clear();
        }

        private void MostrarTramite(Tramite t)
        {
            if (t == null)
            {
                MostrarSinDatos();
                return;
            }

            tramiteActual = t;

            string nro = string.IsNullOrWhiteSpace(t.NroTramite) ? "S/N" : t.NroTramite;
            string chasis = string.IsNullOrWhiteSpace(t.Chasis) ? "-" : t.Chasis;
            string vehiculo = ((t.Marca ?? "") + " " + (t.Clase ?? "") + " " + (t.TipoVehiculo ?? "")).Trim();

            lblTramite.Text = "Trámite " + nro + " · " + chasis;
            lblClienteV.Text = string.IsNullOrWhiteSpace(t.Cliente) ? "-" : t.Cliente;
            lblVehiculoV.Text = string.IsNullOrWhiteSpace(vehiculo) ? "-" : vehiculo;
            lblPlacaV.Text = string.IsNullOrWhiteSpace(t.Placa) ? "Pendiente" : t.Placa;
            llbModalidadV.Text = string.IsNullOrWhiteSpace(t.Modalidad) ? "-" : t.Modalidad.ToUpperInvariant();
            label6.Text = (t.Estado ?? "").ToUpperInvariant();
            lblEstadoDetalle.Text = DescribirUbicacion(t);

            bool entregado = t.Estado == Tramites.Entregado;
            DateTime vencimiento = t.FechaIngreso.AddHours(48);
            double horas = entregado && t.FechaEntrega != DateTime.MinValue
                ? Math.Max(0, (t.FechaEntrega - t.FechaIngreso).TotalHours)
                : Math.Max(0, Tramites.Horas(t));

            ActualizarPlazo(horas, vencimiento.ToString("dd/MM/yyyy HH:mm"), entregado, t.FechaEntrega);

            int pasoActual = ObtenerNumeroPaso(t.Estado);
            string fIngreso = t.FechaIngreso != DateTime.MinValue ? t.FechaIngreso.ToString("dd/MM/yyyy HH:mm") : "";
            string fDespacho = t.FechaDespacho != DateTime.MinValue ? t.FechaDespacho.ToString("dd/MM/yyyy HH:mm") : "";
            string fPlaca = !string.IsNullOrWhiteSpace(t.Placa) ? "Placa " + t.Placa : "";
            string fTransito = t.FechaEnvioTransito != DateTime.MinValue ? t.FechaEnvioTransito.ToString("dd/MM/yyyy HH:mm") : "";
            string fEntrega = t.FechaEntrega != DateTime.MinValue ? t.FechaEntrega.ToString("dd/MM/yyyy HH:mm") : "";

            MostrarPasos(pasoActual, new[] { fIngreso, fDespacho, fPlaca, fTransito, fEntrega });
            LlenarHistorial(t);
        }

        private string DescribirUbicacion(Tramite t)
        {
            if (t.Estado == Tramites.Recibido)
                return "GDCON — Recepción (pendiente de despacho)";
            if (t.Estado == Tramites.Despachado)
                return "Alcaldía / Diprove (en espera de placa y pago)";
            if (t.Estado == Tramites.ConPlacaPago)
                return "Diprove (esperando informe técnico)";
            if (t.Estado == Tramites.EnTransito)
                return "Tránsito (espera resolución y placas)";
            if (t.Estado == Tramites.Entregado)
                return "Entregado a " + (string.IsNullOrWhiteSpace(t.EntregadoA) ? "cliente/concesionaria" : t.EntregadoA);
            return t.Estado ?? "-";
        }

        private int ObtenerNumeroPaso(string estado)
        {
            if (estado == Tramites.Recibido) return 1;
            if (estado == Tramites.Despachado) return 2;
            if (estado == Tramites.ConPlacaPago) return 3;
            if (estado == Tramites.EnTransito) return 4;
            if (estado == Tramites.Entregado) return 6;
            return 0;
        }

        private void LlenarHistorial(Tramite t)
        {
            dgvHistorial.Rows.Clear();

            if (t.FechaIngreso != DateTime.MinValue)
            {
                dgvHistorial.Rows.Add(
                    t.FechaIngreso.ToString("dd/MM/yyyy HH:mm"),
                    "Trámite recibido — Póliza " + (t.Poliza ?? "-") + " (" + (t.Empresa ?? "-") + ")",
                    "Recepción y Despacho");
            }

            if (t.FechaDespacho != DateTime.MinValue)
            {
                dgvHistorial.Rows.Add(
                    t.FechaDespacho.ToString("dd/MM/yyyy HH:mm"),
                    "Despachado a Alcaldía y Diprove",
                    "Recepción y Despacho");
            }

            if (!string.IsNullOrWhiteSpace(t.Placa))
            {
                string fechaRef = t.FechaDespacho != DateTime.MinValue
                    ? t.FechaDespacho.ToString("dd/MM/yyyy")
                    : t.FechaIngreso.ToString("dd/MM/yyyy");
                dgvHistorial.Rows.Add(
                    fechaRef,
                    "Placa asignada: " + t.Placa + (t.Ruat ? " (RUAT verificado)" : ""),
                    "Placas y Pagos");
            }

            if (t.PagoRealizado)
            {
                string fechaRef = t.FechaDespacho != DateTime.MinValue
                    ? t.FechaDespacho.ToString("dd/MM/yyyy")
                    : t.FechaIngreso.ToString("dd/MM/yyyy");
                dgvHistorial.Rows.Add(
                    fechaRef,
                    "Pago bancario registrado — Comprobante " + (t.Comprobante ?? "-") +
                    " (Bs " + t.MontoPago.ToString("N2", CultureInfo.InvariantCulture) + ")",
                    "Placas y Pagos");
            }

            if (t.FechaRetorno != DateTime.MinValue && !string.IsNullOrWhiteSpace(t.InformeDiprove))
            {
                dgvHistorial.Rows.Add(
                    t.FechaRetorno.ToString("dd/MM/yyyy"),
                    "Retorno de Diprove — Informe técnico " + t.InformeDiprove,
                    "Diprove y Tránsito");
            }

            if (t.FechaEnvioTransito != DateTime.MinValue)
            {
                dgvHistorial.Rows.Add(
                    t.FechaEnvioTransito.ToString("dd/MM/yyyy HH:mm"),
                    "Carpeta enviada a Tránsito",
                    "Diprove y Tránsito");
            }

            if (t.Estado == Tramites.Entregado && t.FechaEntrega != DateTime.MinValue)
            {
                dgvHistorial.Rows.Add(
                    t.FechaEntrega.ToString("dd/MM/yyyy HH:mm"),
                    "Entrega final completada — Recibido por " + (t.EntregadoA ?? "-"),
                    "Entrega Final");
            }

            dgvHistorial.ClearSelection();
        }

        // ---------- Búsqueda ----------
        private void bntBuscar_Click(object sender, EventArgs e)
        {
            string criterio = txtBuscar.Text.Trim();
            tramites.Archivo_VectorTramites();

            if (tramites.Cantidad() == 0)
            {
                MostrarSinDatos();
                MessageBox.Show("No existen trámites registrados todavía.", "GDCON Legal System",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (criterio == "")
            {
                MostrarTramite(tramites.Obtener(tramites.Cantidad() - 1));
                return;
            }

            int pos = tramites.Buscar(criterio);
            if (pos < 0)
                pos = BuscarParcial(criterio);

            if (pos < 0)
            {
                MessageBox.Show("No se encontró ningún trámite con '" + criterio + "'.",
                    "GDCON Legal System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MostrarTramite(tramites.Obtener(pos));
        }

        private int BuscarParcial(string criterio)
        {
            for (int i = tramites.Cantidad() - 1; i >= 0; i--)
            {
                Tramite t = tramites.Obtener(i);
                if (t == null) continue;
                if (Contiene(t.Chasis, criterio)
                    || Contiene(t.Placa, criterio)
                    || Contiene(t.Cliente, criterio)
                    || Contiene(t.NroContrato, criterio)
                    || Contiene(t.NroTramite, criterio)
                    || Contiene(t.NitCi, criterio)
                    || Contiene(t.Poliza, criterio))
                {
                    return i;
                }
            }
            return -1;
        }

        private bool Contiene(string origen, string texto)
        {
            return !string.IsNullOrEmpty(origen)
                && origen.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                bntBuscar_Click(sender, e);
            }
        }

        // ---------- Barra de plazo de 48 h + semáforo ----------
        public void ActualizarPlazo(double horas, string vence)
        {
            ActualizarPlazo(horas, vence, false, DateTime.MinValue);
        }

        public void ActualizarPlazo(double horas, string vence, bool entregado, DateTime fechaEntrega)
        {
            double pct = entregado ? 1.0 : Math.Min(Math.Max(horas, 0) / 48.0, 1.0);
            anchoObjetivo = (int)(pbPlazo.Width * pct);
            IniciarAnimacionPlazo();

            Color color;
            string textoSemaforo;
            if (entregado)
            {
                color = Color.FromArgb(25, 118, 210);
                textoSemaforo = "Entregado" + (fechaEntrega != DateTime.MinValue ? " — " + fechaEntrega.ToString("dd/MM/yyyy HH:mm") : "");
            }
            else if (horas <= 24)
            {
                color = Color.FromArgb(46, 125, 50);
                textoSemaforo = "En tiempo — vence " + vence;
            }
            else if (horas <= 48)
            {
                color = Color.FromArgb(217, 119, 6);
                textoSemaforo = "Por vencer — vence " + vence;
            }
            else
            {
                color = Color.FromArgb(198, 40, 40);
                textoSemaforo = "Vencido — venció " + vence;
            }

            pnlPlazoRelleno.BackColor = color;
            lblHoras.ForeColor = color;
            lblPuntoSemaforo.ForeColor = color;

            int h = (int)Math.Max(0, horas);
            int m = (int)Math.Round((Math.Max(0, horas) - h) * 60);
            if (m == 60) { h++; m = 0; }
            lblHoras.Text = h + " h " + m + " min";
            lblSemaforo.Text = textoSemaforo;
        }

        private void IniciarAnimacionPlazo()
        {
            pnlPlazoRelleno.Width = 0;
            inicioAnim = DateTime.Now;
            tmrPlazo.Start();
        }

        private void tmrPlazo_Tick(object sender, EventArgs e)
        {
            double t = (DateTime.Now - inicioAnim).TotalMilliseconds / DuracionMs;
            if (t >= 1)
            {
                pnlPlazoRelleno.Width = anchoObjetivo;
                tmrPlazo.Stop();
                return;
            }
            double suave = 1 - Math.Pow(1 - t, 3);
            pnlPlazoRelleno.Width = (int)(anchoObjetivo * suave);
        }

        // ---------- Línea de tiempo ----------
        public void MostrarPasos(int actual, string[] fechasTxt)
        {
            Color verde = Color.FromArgb(46, 125, 50);
            Color azul = Color.FromArgb(0, 145, 185);
            Color gris = Color.FromArgb(91, 107, 124);
            Color grisClaro = Color.FromArgb(226, 232, 240);

            for (int i = 0; i < 5; i++)
            {
                int paso = i + 1;
                if (paso < actual)
                {
                    circulos[i].BackColor = verde; circulos[i].ForeColor = Color.White; circulos[i].Text = "✓";
                    nombres[i].ForeColor = verde; nombres[i].Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                }
                else if (paso == actual)
                {
                    circulos[i].BackColor = azul; circulos[i].ForeColor = Color.White; circulos[i].Text = paso.ToString();
                    nombres[i].ForeColor = azul; nombres[i].Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                }
                else
                {
                    circulos[i].BackColor = grisClaro; circulos[i].ForeColor = gris; circulos[i].Text = paso.ToString();
                    nombres[i].ForeColor = gris; nombres[i].Font = new Font("Segoe UI", 9F);
                }
                bool tieneFecha = paso <= actual && fechasTxt != null && i < fechasTxt.Length && fechasTxt[i] != "";
                fechas[i].Text = tieneFecha ? fechasTxt[i] : "Pendiente";
            }
            for (int i = 0; i < 4; i++)
                lineas[i].BackColor = (i + 1) < actual ? verde : Color.FromArgb(213, 221, 230);
        }

        private void PosicionarLineaTiempo()
        {
            if (circulos == null) return;
            int w = pnlLineaTiempo.ClientSize.Width;
            int col = w / 5;
            int anchoTxt = Math.Max(col - 20, 60);
            for (int i = 0; i < 5; i++)
            {
                int cx = col * i + col / 2;
                circulos[i].Location = new Point(cx - 15, 16);
                nombres[i].Size = new Size(anchoTxt, 20);
                nombres[i].Location = new Point(cx - anchoTxt / 2, 54);
                fechas[i].Size = new Size(anchoTxt, 18);
                fechas[i].Location = new Point(cx - anchoTxt / 2, 76);
            }
            for (int i = 0; i < 4; i++)
            {
                int x1 = (col * i + col / 2) + 15 + 8;
                int x2 = (col * (i + 1) + col / 2) - 15 - 8;
                lineas[i].Location = new Point(x1, 30);
                lineas[i].Size = new Size(Math.Max(x2 - x1, 1), 2);
            }
        }

        private void PintarBorde(object sender, PaintEventArgs e)
        {
            var c = (Control)sender;
            using (var pen = new Pen(Color.FromArgb(213, 221, 230)))
                e.Graphics.DrawRectangle(pen, 0, 0, c.Width - 1, c.Height - 1);
        }

        // ---------- Impresión y PDF ----------
        private Bitmap CapturarContenido()
        {
            tmrPlazo.Stop();
            pnlPlazoRelleno.Width = anchoObjetivo;
            dgvHistorial.ClearSelection();
            this.Refresh();

            Bitmap completo = new Bitmap(ClientSize.Width, ClientSize.Height);
            this.DrawToBitmap(completo, new Rectangle(0, 0, completo.Width, completo.Height));

            int alto = Math.Max(1, completo.Height - tsAcciones.Height);
            Bitmap recorte = new Bitmap(completo.Width, alto);
            using (Graphics g = Graphics.FromImage(recorte))
            {
                g.DrawImage(completo,
                    new Rectangle(0, 0, recorte.Width, recorte.Height),
                    new Rectangle(0, tsAcciones.Height, completo.Width, alto),
                    GraphicsUnit.Pixel);
            }
            completo.Dispose();
            return recorte;
        }

        private PrintDocument CrearDocumento()
        {
            var doc = new PrintDocument();
            doc.DefaultPageSettings.Landscape = true;
            doc.PrintPage += (s, e) =>
            {
                using (var bmp = CapturarContenido())
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

        private void ExportarPdf(string rutaArchivo)
        {
            using (Bitmap bmp = CapturarContenido())
            using (MemoryStream ms = new MemoryStream())
            {
                bmp.Save(ms, ImageFormat.Png);
                ms.Position = 0;

                using (PdfDocument pdf = new PdfDocument())
                {
                    string titulo = tramiteActual != null ? tramiteActual.NroTramite : "Seguimiento";
                    pdf.Info.Title = "Seguimiento de Trámite - " + titulo;
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
            if (tramiteActual == null)
            {
                MessageBox.Show("No hay un trámite cargado para imprimir.", "GDCON Legal System",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var doc = CrearDocumento();
            using (var dlg = new PrintDialog { Document = doc })
                if (dlg.ShowDialog() == DialogResult.OK) doc.Print();
        }

        private void tsbVistaPrevia_Click(object sender, EventArgs e)
        {
            if (tramiteActual == null)
            {
                MessageBox.Show("No hay un trámite cargado para previsualizar.", "GDCON Legal System",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (var dlg = new PrintPreviewDialog { Document = CrearDocumento(), Width = 1000, Height = 720 })
                dlg.ShowDialog();
        }

        private void tsbExportarPdf_Click(object sender, EventArgs e)
        {
            if (tramiteActual == null)
            {
                MessageBox.Show("No hay un trámite cargado para exportar a PDF.", "GDCON Legal System",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Title = "Guardar Seguimiento de Trámite en PDF";
                dlg.Filter = "Archivo PDF (*.pdf)|*.pdf";
                dlg.FileName = "Seguimiento_" + (string.IsNullOrWhiteSpace(tramiteActual.NroTramite) ? "Tramite" : tramiteActual.NroTramite) + ".pdf";
                if (dlg.ShowDialog(this) != DialogResult.OK) return;

                try
                {
                    ExportarPdf(dlg.FileName);
                    MessageBox.Show("Seguimiento exportado correctamente en PDF:\n" + dlg.FileName,
                        "GDCON Legal System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo generar el PDF:\n" + ex.Message,
                        "GDCON Legal System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}