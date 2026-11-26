using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CapaPresentacion
{
    public class PaletaColores
    {
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
    }
}
