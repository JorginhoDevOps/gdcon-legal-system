using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Recepcion
    {
        public int codigo { get; set; }
        public string chasis { get; set; }
        public string nroContrato { get; set; }
        public string documento { get; set; }
        public string cliente { get; set; }
        public string marca { get; set; }
        public string clase { get; set; }
        public string tipoVehiculo { get; set; }
        public string poliza { get; set; }
        public string year { get; set; }
        public string color { get; set; }
        public string modalidad { get; set; }
        public DateTime ingreso { get; set; }
        public bool despachoAlcaldia { get; set; }
        public string status { get; set; }
    }
}
