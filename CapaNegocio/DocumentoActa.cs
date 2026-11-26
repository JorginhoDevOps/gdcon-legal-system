using System;

namespace CapaNegocio
{
    // Clase abstracta base: define la plantilla común de un acta
    public abstract class DocumentoActa
    {
        public Tramite TramiteActual { get; protected set; }

        protected DocumentoActa(Tramite tramite)
        {
            TramiteActual = tramite;
        }

        public abstract string Modalidad { get; }

        // Método virtual: permite polimorfismo mediante override en clases hijas
        public virtual string ConstruirContenidoQr()
        {
            if (TramiteActual == null) return "GDCON | SIN_DATOS";

            string placa = string.IsNullOrWhiteSpace(TramiteActual.Placa) ? "S/P" : TramiteActual.Placa;
            return "GDCON | " + TramiteActual.NroTramite +
                   " | " + TramiteActual.Empresa +
                   " | Chasis: " + TramiteActual.Chasis +
                   " | Placa: " + placa +
                   " | Modalidad: " + Modalidad +
                   " | Cliente: " + TramiteActual.Cliente;
        }
    }

    public sealed class ActaContadoDocumento : DocumentoActa
    {
        public ActaContadoDocumento(Tramite tramite) : base(tramite) { }

        public override string Modalidad => "CONTADO";
    }

    public sealed class ActaCreditoDocumento : DocumentoActa
    {
        public ActaCreditoDocumento(Tramite tramite) : base(tramite) { }

        public override string Modalidad => "CREDITO";

        public override string ConstruirContenidoQr()
        {
            string baseQr = base.ConstruirContenidoQr();
            return baseQr + " | TipoDoc: CREDITO_VEHICULAR";
        }
    }
}