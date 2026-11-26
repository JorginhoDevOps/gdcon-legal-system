using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CapaPresentacion.Properties;

namespace CapaPresentacion
{
    // Estilo común de todos los formularios (RNF-02: estandarización UI/UX).
    // Cada formulario lo llama UNA vez, justo después de InitializeComponent().
    public static class EstiloUI
    {
        #region "COLORES"
        public static readonly Color Marino = Color.FromArgb(9, 26, 58);
        public static readonly Color Cian = Color.FromArgb(25, 193, 227);
        public static readonly Color Fondo = Color.FromArgb(244, 247, 250);
        public static readonly Color Gris = Color.FromArgb(154, 167, 182);
        public static readonly Color EncabezadoGrilla = Color.FromArgb(230, 236, 245);
        public static readonly Color FilaAlterna = Color.FromArgb(245, 248, 252);
        public static readonly Color Seleccion = Color.FromArgb(205, 238, 247);
        public static readonly Color LineaGrilla = Color.FromArgb(227, 233, 240);

        //Paleta de colores que se aplica a los avisos
        public static readonly Color SoloLecturaFondo = Color.FromArgb(238, 242, 246);
        public static readonly Color SoloLecturaTexto = Color.FromArgb(75, 90, 107);
        public static readonly Color EditableFondo = Color.White;
        public static readonly Color EditableTexto = Color.FromArgb(27, 39, 51);

        public static readonly Color AvisoAlertaFondo = Color.FromArgb(255, 246, 224);
        public static readonly Color AvisoAlertaBorde = Color.FromArgb(249, 168, 37);
        public static readonly Color AvisoAlertaTexto = Color.FromArgb(109, 74, 0);

        public static readonly Color AvisoOkFondo = Color.FromArgb(232, 245, 233);
        public static readonly Color AvisoOkBorde = Color.FromArgb(46, 125, 50);
        public static readonly Color AvisoOkTexto = Color.FromArgb(27, 94, 32);

        public static readonly Color AvisoInfoFondo = Color.FromArgb(232, 244, 253);
        public static readonly Color AvisoInfoBorde = Color.FromArgb(25, 118, 210);
        public static readonly Color AvisoInfoTexto = Color.FromArgb(13, 71, 161);
        #endregion

        #region "PUNTOS DE ENTRADA"
        // Formularios operativos (Recepción, Placas, Tránsito, Entrega, Usuarios).
        // pasosActivos: números del 1 al 5 que se resaltan en el indicador de pasos.
        public static void Aplicar(Form frm, params int[] pasosActivos)
        {
            frm.BackColor = Fondo;
            foreach (ToolStrip ts in Buscar<ToolStrip>(frm))
                AplicarBarra(ts);
            AplicarPasos(frm, pasosActivos);
            AplicarEncabezados(frm);
            foreach (DataGridView dgv in Buscar<DataGridView>(frm))
                AplicarGrilla(dgv);
        }

        // Informes y actas: solo se uniforma la barra de herramientas y el fondo,
        // porque la hoja imprimible tiene su propio diseño.
        public static void SoloBarra(Form frm)
        {
            frm.BackColor = Fondo;
            foreach (ToolStrip ts in Buscar<ToolStrip>(frm))
                AplicarBarra(ts);
        }
        #endregion

        #region "BARRA DE HERRAMIENTAS"
        static void AplicarBarra(ToolStrip ts)
        {
            ts.GripStyle = ToolStripGripStyle.Hidden;
            ts.BackColor = Color.White;
            ts.ImageScalingSize = new Size(24, 24);
            ts.AutoSize = false;
            ts.Height = 48;
            ts.Padding = new Padding(8, 0, 8, 0);

            List<ToolStripButton> salidas = new List<ToolStripButton>();
            foreach (ToolStripItem item in ts.Items)
            {
                ToolStripButton b = item as ToolStripButton;
                if (b == null) continue;

                // Mismo tipo de letra, color y espacios en TODOS los botones
                b.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                b.ForeColor = Marino;
                b.Margin = new Padding(2, 2, 2, 2);
                b.Padding = new Padding(4, 0, 4, 0);

                Image img = null;
                string texto = null;
                switch (Clave(b.Text))
                {
                    case "nuevo":
                    case "agregar":
                        img = Resources.IcoAgregar; texto = "Agregar"; break;
                    case "guardar":
                        img = Resources.IcoGuardar; texto = "Guardar"; break;
                    case "modificar":
                    case "editar":
                        img = Resources.IcoModificar; texto = "Modificar"; break;
                    case "eliminar":
                        img = Resources.IcoEliminar; texto = "Eliminar"; break;
                    case "limpiar":
                        img = Resources.IcoActualizar; texto = "Limpiar"; break;
                    case "buscar":
                        img = Resources.IcoBuscar; texto = "Buscar"; break;
                    case "cerrar":
                    case "salir":
                        img = Resources.IcoSalir; texto = "Salir"; break;
                    case "vistaprevia":
                        img = Resources.IcoVer; texto = "Vista previa"; break;
                    case "veracta":
                        img = Resources.IcoVer; texto = "Ver acta"; break;
                    case "imprimir":
                        img = Resources.IMPRIMIR; texto = "Imprimir"; break;
                }
                if (img == null) continue;

                b.Image = img;
                b.Text = texto;
                b.ToolTipText = texto;
                b.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                b.TextImageRelation = TextImageRelation.ImageBeforeText;
                b.ImageScaling = ToolStripItemImageScaling.SizeToFit;

                if (texto == "Salir") salidas.Add(b);
            }

            // "Salir" siempre es UNO solo, va en el extremo DERECHO y se ve igual en todas las pantallas.
            // Si había dos (Cerrar y Salir), se conserva el que ya estaba a la derecha.
            if (salidas.Count > 0)
            {
                ToolStripButton salir = salidas[0];
                foreach (ToolStripButton b in salidas)
                    if (b.Alignment == ToolStripItemAlignment.Right) { salir = b; break; }
                foreach (ToolStripButton b in salidas)
                    if (b != salir) b.Visible = false;

                salir.Alignment = ToolStripItemAlignment.Right;
                salir.Margin = new Padding(8, 2, 2, 2);
                // Los botones alineados a la derecha se colocan de derecha a izquierda
                // según su orden: el primero queda pegado al borde.
                ts.Items.Remove(salir);
                ts.Items.Insert(0, salir);
            }
        }

        // "🖨 Imprimir" -> "imprimir"; "Vista Previa" -> "vistaprevia"
        static string Clave(string texto)
        {
            if (texto == null) return "";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (char c in texto)
                if (char.IsLetter(c)) sb.Append(char.ToLowerInvariant(c));
            return sb.ToString();
        }
        #endregion

        #region "INDICADOR DE PASOS"
        static readonly string[] NombresPasos =
        {
            "① Recepción", "② Despacho", "③ Placas y Pagos", "④ Diprove y Tránsito", "⑤ Entrega"
        };

        static void AplicarPasos(Form frm, int[] activos)
        {
            Label[] etiquetas = new Label[5];
            for (int i = 0; i < 5; i++)
            {
                Control[] c = frm.Controls.Find("lblPaso" + (i + 1).ToString(), true);
                if (c.Length == 0) return;
                Label l = c[0] as Label;
                // Solo el indicador de la barra superior (no la línea de tiempo de Seguimiento)
                if (l == null || l.Parent == null || l.Parent.Name != "pnlPasos") return;
                etiquetas[i] = l;
            }

            Control panel = etiquetas[0].Parent;
            if (panel.Dock == DockStyle.Top) panel.Height = 44;

            int x = 24;
            for (int i = 0; i < 5; i++)
            {
                Label l = etiquetas[i];
                bool activo = Array.IndexOf(activos, i + 1) >= 0;
                l.AutoSize = true;
                l.Font = new Font("Segoe UI", 9F, activo ? FontStyle.Bold : FontStyle.Regular);
                l.ForeColor = activo ? Cian : Gris;
                l.Text = NombresPasos[i] + (i < 4 ? "   ───" : "");
                Size tam = l.PreferredSize;
                l.Location = new Point(x, (panel.Height - tam.Height) / 2 - 1);
                x += tam.Width + 10;
            }
        }
        #endregion

        #region "ENCABEZADOS Y GRILLAS"
        static void AplicarEncabezados(Form frm)
        {
            foreach (Label l in Buscar<Label>(frm))
            {
                if (!l.Name.StartsWith("lblEncabezado") || l.Dock != DockStyle.Top) continue;
                l.BackColor = Marino;
                l.ForeColor = Color.White;
                l.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                l.TextAlign = ContentAlignment.MiddleLeft;
                l.Padding = new Padding(12, 0, 0, 0);
                l.AutoEllipsis = true;
                l.AutoSize = false;
                l.Height = 32;
            }
        }

        static void AplicarGrilla(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.GridColor = LineaGrilla;
            dgv.RowHeadersVisible = false;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersHeight = 32;
            dgv.RowTemplate.Height = 28;

            DataGridViewCellStyle enc = dgv.ColumnHeadersDefaultCellStyle;
            enc.BackColor = EncabezadoGrilla;
            enc.ForeColor = Marino;
            enc.SelectionBackColor = EncabezadoGrilla;   // evita el azul de Windows en el encabezado
            enc.SelectionForeColor = Marino;
            enc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            enc.Alignment = DataGridViewContentAlignment.MiddleLeft;
            enc.Padding = new Padding(6, 0, 0, 0);

            dgv.DefaultCellStyle.SelectionBackColor = Seleccion;
            dgv.DefaultCellStyle.SelectionForeColor = Marino;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = FilaAlterna;
            dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = Seleccion;
            dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = Marino;
        }
        #endregion

        #region "AUXILIAR"
        static List<T> Buscar<T>(Control raiz) where T : Control
        {
            List<T> lista = new List<T>();
            foreach (Control c in raiz.Controls)
            {
                T t = c as T;
                if (t != null) lista.Add(t);
                lista.AddRange(Buscar<T>(c));
            }
            return lista;
        }
        #endregion
    }
}
