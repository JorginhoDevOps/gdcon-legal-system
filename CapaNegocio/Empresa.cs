using System;

namespace CapaNegocio
{
    public class Empresa
    {
        #region "ATRIBUTO"
        public int Codigo;
        public string Nombre;
        public string Nit;
        public double HonorarioContado;   // Bs que GDCON cobra por un trámite al Contado
        public double HonorarioCredito;   // Bs que GDCON cobra por un trámite a Crédito
        #endregion
    }
}
