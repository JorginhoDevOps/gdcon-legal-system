using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmSeguimiento : Form
    {
        private Label[] circulos, nombres, fechas;
        private Panel[] lineas;
        private Timer tmrPlazo;
        private int anchoObjetivo;
        private DateTime inicioAnim;
        private const int DuracionMs = 1000;

        public FrmSeguimiento()
        {
            InitializeComponent();
            EstiloUI.SoloBarra(this);

            circulos = new[] { lblCirculo1, lblCirculo2, lblCirculo3, lblCirculo4, lblCirculo5 };
            nombres = new[] { lblPaso1, lblPaso2, lblPaso3, lblPaso4, lblPaso5 };
            fechas = new[] { lblFechaPaso1, lblFechaPaso2, lblFechaPaso3, lblFechaPaso4, lblFechaPaso5 };
            lineas = new[] { pnlLinea1, pnlLinea2, pnlLinea3, pnlLinea4 };

            // Círculos de los pasos
            foreach (Label c in circulos)
            {
                var gp = new GraphicsPath();
                gp.AddEllipse(0, 0, c.Width - 1, c.Height - 1);
                c.Region = new Region(gp);
            }

            // Redibujar el borde y reubicar la línea de tiempo al cambiar de tamaño
            foreach (Control p in new Control[] { pnlBuscar, panel1, pnlLineaTiempo })
                p.Resize += (s, e) => ((Control)s).Invalidate();
            pnlLineaTiempo.Resize += (s, e) => PosicionarLineaTiempo();

            tmrPlazo = new Timer { Interval = 15 };
            tmrPlazo.Tick += tmrPlazo_Tick;
            // La animación corre cada vez que el formulario se muestra
            this.VisibleChanged += (s, e) => { if (this.Visible) IniciarAnimacionPlazo(); };
            PosicionarLineaTiempo();
            CargarEjemplo();
        }

        // ---------- Datos de EJEMPLO (ficticios). Luego vendrán de la CapaNegocio ----------
        private void CargarEjemplo()
        {
            ActualizarPlazo(47.33, "12/11/2026 15:00");
            MostrarPasos(4, new[] { "10/11/2026 15:00", "11/11/2026 08:30", "11/11/2026 13:10", "11/11/2026 16:40", "" });

            dgvHistorial.Rows.Clear();
            dgvHistorial.Rows.Add("10/11/2026 15:00", "Trámite recibido (carpeta física con póliza y calco)", "Recepción y Despacho");
            dgvHistorial.Rows.Add("11/11/2026 08:30", "Despachado a Alcaldía y Diprove", "Recepción y Despacho");
            dgvHistorial.Rows.Add("11/11/2026 12:40", "Placa asignada (RUAT verificado)", "Placas y Pagos");
            dgvHistorial.Rows.Add("11/11/2026 13:10", "Pago registrado - comprobante", "Placas y Pagos");
            dgvHistorial.Rows.Add("11/11/2026 16:05", "Retorno de Diprove - informe técnico", "Diprove y Tránsito");
            dgvHistorial.Rows.Add("11/11/2026 16:40", "Carpeta enviada a Tránsito", "Diprove y Tránsito");
            dgvHistorial.ClearSelection();
        }

        // ---------- Barra de plazo de 48 h + semáforo ----------
        public void ActualizarPlazo(double horas, string vence)
        {
            double pct = Math.Min(horas / 48.0, 1.0);
            anchoObjetivo = (int)(pbPlazo.Width * pct);
            IniciarAnimacionPlazo();

            Color color; string estado;
            if (horas <= 24) { color = Color.FromArgb(46, 125, 50); estado = "En tiempo"; }
            else if (horas <= 48) { color = Color.FromArgb(249, 168, 37); estado = "Por vencer"; }
            else { color = Color.FromArgb(198, 40, 40); estado = "Vencido"; }

            pnlPlazoRelleno.BackColor = color;
            lblHoras.ForeColor = color;
            lblPuntoSemaforo.ForeColor = color;
            int h = (int)horas;
            int m = (int)Math.Round((horas - h) * 60);
            lblHoras.Text = h + " h " + m + " min";
            lblSemaforo.Text = estado + " — vence " + vence;
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
            double suave = 1 - Math.Pow(1 - t, 3);   // arranca rápido y frena al final
            pnlPlazoRelleno.Width = (int)(anchoObjetivo * suave);
        }

        // ---------- Línea de tiempo: pasos hechos, actual y pendientes ----------
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

        // Reparte los 5 pasos a lo ancho del panel (se adapta al tamaño del menú)
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

        // Borde fino y claro de las tarjetas
        private void PintarBorde(object sender, PaintEventArgs e)
        {
            var c = (Control)sender;
            using (var pen = new Pen(Color.FromArgb(213, 221, 230)))
                e.Graphics.DrawRectangle(pen, 0, 0, c.Width - 1, c.Height - 1);
        }

        // ---------- Barra de acciones ----------
        private PrintDocument CrearDocumento()
        {
            var doc = new PrintDocument();
            doc.DefaultPageSettings.Landscape = true;
            doc.PrintPage += (s, e) =>
            {
                using (var bmp = new Bitmap(ClientSize.Width, ClientSize.Height))
                {
                    this.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                    var origen = new Rectangle(0, tsAcciones.Height, bmp.Width, bmp.Height - tsAcciones.Height);
                    float esc = Math.Min((float)e.MarginBounds.Width / origen.Width,
                                         (float)e.MarginBounds.Height / origen.Height);
                    var destino = new RectangleF(e.MarginBounds.X, e.MarginBounds.Y, origen.Width * esc, origen.Height * esc);
                    e.Graphics.DrawImage(bmp, destino, origen, GraphicsUnit.Pixel);
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

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
