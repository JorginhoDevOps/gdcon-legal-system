using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            count = tramites.Cantidad();
        }
        #endregion

        #region metodos
        public int Cantidad()
        {
            tramites.Archivo_VectorTramites();
            count = tramites.Cantidad();
            return count;
        }

        public List<KeyValuePair<string, string>> GuardarRecepcion(Tramite nuevaRecepcion)
        {
            tramites.Archivo_VectorTramites();

            List<KeyValuePair<string, string>> errores = tramites.Validar(nuevaRecepcion, -1);

            if (errores.Count == 0)
            {
                tramites.Guardar(nuevaRecepcion);
                tramites.VectorTramites_Archivo();
                count = tramites.Cantidad();
            }

            return errores;
        }

        public string obtenerContrato(RadioButton rbContado, RadioButton rbCredito)
        {
            string modalidad = "";
            if (rbContado.Checked) modalidad = "Contado";
            else if (rbCredito.Checked) modalidad = "Crédito";
            return modalidad;
        }

        public bool EliminarRecepcion(int indice, out string mensajeError)
        {
            mensajeError = "";
            tramites.Archivo_VectorTramites();

            Tramite tramite = tramites.Obtener(indice);
            if (tramite == null)
            {
                mensajeError = "El registro seleccionado no existe.";
                return false;
            }

            if (tramite.Estado != Tramites.Recibido)
            {
                mensajeError = "Solo se pueden eliminar trámites en estado Recibido (este está " + tramite.Estado + ").";
                return false;
            }

            if (!tramites.Eliminar(indice))
            {
                mensajeError = "No se pudo eliminar el trámite seleccionado.";
                return false;
            }

            tramites.VectorTramites_Archivo();
            count = tramites.Cantidad();
            return true;
        }

        public List<Tramite> ObtenerTodos()
        {
            tramites.Archivo_VectorTramites();
            count = tramites.Cantidad();
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
                mensajeError = "No se puede editar un trámite en estado '" + tramite.Estado + "'. Solo se permiten trámites Recibidos o Despachados.";
                return null;
            }

            return tramite;
        }

        public bool EditarRecepcion(Tramite editado)
        {
            string msg;
            return EditarRecepcion(editado, out msg);
        }

        public bool EditarRecepcion(Tramite editado, out string mensajeError)
        {
            mensajeError = "";
            tramites.Archivo_VectorTramites();

            int indice = tramites.Buscar(editado.NroTramite);
            if (indice < 0)
            {
                mensajeError = "No se encontró el trámite para actualizar.";
                return false;
            }

            Tramite antiguo = tramites.Obtener(indice);
            if (antiguo.Estado != Tramites.Recibido && antiguo.Estado != Tramites.Despachado)
            {
                mensajeError = "No se puede modificar un trámite en estado '" + antiguo.Estado + "'.";
                return false;
            }

            List<KeyValuePair<string, string>> errores = tramites.Validar(editado, indice);
            if (errores.Count > 0)
            {
                mensajeError = errores[0].Value;
                return false;
            }

            if (antiguo.Estado == Tramites.Recibido)
            {
                antiguo.Empresa = editado.Empresa;
                antiguo.Chasis = editado.Chasis;
                antiguo.Poliza = editado.Poliza;
                antiguo.Modalidad = editado.Modalidad;
                antiguo.Honorario = editado.Honorario;
            }

            antiguo.NroContrato = editado.NroContrato;
            antiguo.NitCi = editado.NitCi;
            antiguo.Cliente = editado.Cliente;
            antiguo.Marca = editado.Marca;
            antiguo.Clase = editado.Clase;
            antiguo.TipoVehiculo = editado.TipoVehiculo;
            antiguo.Anio = editado.Anio;
            antiguo.Color = editado.Color;

            if (antiguo.Estado == Tramites.Recibido && editado.DespachoAlcaldia)
            {
                if (!tramites.Despachar(indice, out mensajeError))
                    return false;
            }

            tramites.VectorTramites_Archivo();
            return true;
        }
        #endregion
    }
}