using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Transito
    {
        public int Codigo { get; set; }
        public string Chasis { get; set; }
        public string Placa { get; set; }
        public string Modalidad { get; set; }
        public string NroInformeDip { get; set; }
        public DateTime? FechaRetorno { get; set; }
        public DateTime? FechaEnvioTransito { get; set; }
        public string Estado { get; set; }
    }
}
