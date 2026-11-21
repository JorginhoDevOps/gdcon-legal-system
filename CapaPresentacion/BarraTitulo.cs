using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public static class BarraTitulo
    {
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int atributo, ref int valor, int tamano);

        private const int MODO_OSCURO = 20;
        private const int BORDE = 34;
        private const int FONDO = 35;
        private const int TEXTO = 36;

        private static int ColorRef(Color c) => c.R | (c.G << 8) | (c.B << 16);

        public static void Aplicar(Form f, Color fondo, Color texto)
        {
            if (f.IsHandleCreated) Poner(f, fondo, texto);
            f.HandleCreated += (s, e) => Poner(f, fondo, texto);
            f.Load += (s, e) => Poner(f, fondo, texto);
        }

        private static void Poner(Form f, Color fondo, Color texto)
        {
            try
            {
                int modoClaro = 0; // 0 = iconos oscuros (— □ ×) sobre barra clara
                int cFondo = ColorRef(fondo);
                int cTexto = ColorRef(texto);

                DwmSetWindowAttribute(f.Handle, MODO_OSCURO, ref modoClaro, 4);
                DwmSetWindowAttribute(f.Handle, FONDO, ref cFondo, 4);
                DwmSetWindowAttribute(f.Handle, BORDE, ref cFondo, 4);
                DwmSetWindowAttribute(f.Handle, TEXTO, ref cTexto, 4);
            }
            catch { }
        }
    }
}