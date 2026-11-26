using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;
using System.IO;

namespace CapaNegocio
{
    public class Recepciones
    {
        #region atributos
        private Tramites tramites = new Tramites();
        public int count = 0;
        #endregion
        #region constructor
        public Recepciones()
        {
            tramites.Archivo_VectorTramites();
        }
        #endregion
        #region metodos
        private static readonly JsonSerializerOptions opcionesJson = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = true
        };

        public int Cantidad()
        {
            return tramites.Cantidad();
        }
        public List<KeyValuePair<string, string>> GuardarRecepcion(Tramite nuevaRecepcion)
        {
            tramites.Archivo_VectorTramites();

            var errores = tramites.Validar(nuevaRecepcion, -1);

            if (errores.Count == 0)
            {
                tramites.Guardar(nuevaRecepcion);
                tramites.VectorTramites_Archivo();
            }

            return errores;
        }
        public string obtenerContrato(RadioButton rbContado, RadioButton rbCredito)
        {
            string modalidad = "";
            if (rbContado.Checked == true) { modalidad = "Contado"; }
            else if (rbCredito.Checked == true) { modalidad = "Crédito"; }
            return modalidad;
        }

        public void eliminar()
        {
            // Implementación del método eliminar
        }

        public List<Tramite> ObtenerTodos()
        {
            tramites.Archivo_VectorTramites();
            List<Tramite> lista = new List<Tramite>();

            for (int i = 0; i < tramites.Cantidad(); i++)
            {
                lista.Add(tramites.Obtener(i));
            }

            return lista;
        }
        public Tramite ObtenerPorIndice(int indice)
        {
            tramites.Archivo_VectorTramites();
            return tramites.Obtener(indice);
        }

        public Tramite ObtenerParaEditar(int indice, out string mensajeError)
        {
            mensajeError = "";
            tramites.Archivo_VectorTramites();

            Tramite tramite = tramites.Obtener(indice);
            if (tramite == null)
            {
                mensajeError = "El registro seleccionado no existe.";
                return null;
            }

            if (tramite.Estado != Tramites.Recibido && tramite.Estado != Tramites.Despachado)
            {
                mensajeError = $"No se puede editar un trámite en estado '{tramite.Estado}'. Solo se permiten trámites Recibidos o Despachados.";
                return null;
            }

            return tramite;
        }

        public bool EditarRecepcion(Tramite editado)
        {
            tramites.Archivo_VectorTramites();

            int indice = tramites.Buscar(editado.NroTramite);

            if (indice < 0) return false;

            Tramite antiguo = tramites.Obtener(indice);
            antiguo.Chasis = editado.Chasis;
            antiguo.NitCi = editado.NitCi;
            antiguo.Cliente = editado.Cliente;
            antiguo.Marca = editado.Marca;
            antiguo.Clase = editado.Clase;
            antiguo.TipoVehiculo = editado.TipoVehiculo;
            antiguo.Poliza = editado.Poliza;
            antiguo.Anio = editado.Anio;
            antiguo.Color = editado.Color;
            antiguo.Modalidad = editado.Modalidad;
            antiguo.Estado = editado.Estado;

            tramites.VectorTramites_Archivo();
            return true;
        }

        #endregion

    }
}
