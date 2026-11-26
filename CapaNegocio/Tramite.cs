using System;

namespace CapaNegocio
{
    public class Tramite
    {
        #region "ATRIBUTO"
        // Recepción y Despacho
        public int Codigo;
        public string NroTramite;        // lo genera el sistema: TRM-2026-0001
        public string Empresa;           // para quién es el trámite
        public string Chasis;
        public string NitCi;
        public string Cliente;
        public string Poliza;
        public string Modalidad;         // "Contado" o "Crédito" (se define en Recepción)
        public string Marca;
        public string Clase;
        public string TipoVehiculo;
        public string Anio;
        public string Color;
        public DateTime FechaIngreso;
        public string Estado;            // solo lo cambia la capa de negocio
        public DateTime FechaDespacho;
        public double Honorario;         // lo que se cobra a la empresa (copiado de Empresas)

        // Placas y Pagos
        public string Placa;
        public bool Ruat;
        public string Comprobante;
        public double MontoPago;
        public bool PagoRealizado;

        // Diprove y Tránsito
        public string InformeDiprove;
        public DateTime FechaRetorno;
        public DateTime FechaEnvioTransito;

        // Entrega Final
        public string Requisitos;        // 7 caracteres 0/1, ver Tramites.Req...
        public string EntregadoA;
        public DateTime FechaEntrega;
        public string NroContrato;
        public bool DespachoAlcaldia;
        #endregion
    }
}
