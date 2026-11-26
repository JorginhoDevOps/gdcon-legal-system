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
        private List<Recepcion> listaRecepcion = new List<Recepcion>();
        private readonly string rutaArchivo = "recepciones.json";
        public int count = 0;
        #endregion
        #region constructor
        public Recepciones()
        {
            crearArchivoJson();
            cargarDocumento();
        }
        #endregion
        #region metodos
        private static readonly JsonSerializerOptions opcionesJson = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = true
        };

        public void incrementar()
        {
            count++;
        }
        public void guardar(Recepcion nuevaRecepcion)
        {
            nuevaRecepcion.codigo = count + 1;
            listaRecepcion.Add(nuevaRecepcion);
            count++;
            guardarDocumento();
        }
        public string obtenerContrato(RadioButton rbContado, RadioButton rbCredito)
        {
            string modalidad = "";
            if (rbContado.Checked == true) { modalidad = "Contado"; }
            else if (rbCredito.Checked == true) { modalidad = "Crédito"; }
            return modalidad;
        }

        public void modificar()
        {
            // Implementación del método modificar
        }

        public void eliminar()
        {
            // Implementación del método eliminar
        }
        public void crearArchivoJson()
        {
            if (!File.Exists(rutaArchivo))
            {
                string jsonInicial = JsonSerializer.Serialize(new List<Recepcion>(), opcionesJson);
                File.WriteAllText(rutaArchivo, jsonInicial);
            }
        }

        public void guardarDocumento()
        {
            string json = JsonSerializer.Serialize(listaRecepcion, opcionesJson);
            File.WriteAllText(rutaArchivo, json);
        }

        public void cargarDocumento()
        {
            if (System.IO.File.Exists(rutaArchivo))
            {
                string json = System.IO.File.ReadAllText(rutaArchivo);
                listaRecepcion = JsonSerializer.Deserialize<List<Recepcion>>(json);
                count = listaRecepcion.Count;
            }
        }

        public void mostrarRecepciones(DataGridView recepciones) {
            if (recepciones == null || listaRecepcion == null) return;

            recepciones.Rows.Clear();

            foreach (var item in listaRecepcion)
            {
                recepciones.Rows.Add(
                    item.chasis,
                    item.cliente,
                    item.modalidad,
                    item.marca,
                    item.poliza,
                    item.ingreso,
                    item.status
                );
            }
        }
        #endregion

    }
}
