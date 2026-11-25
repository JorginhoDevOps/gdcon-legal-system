using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class Transitos
    {
        #region "ATRIBUTOS"
        private List<Transito> listaTransito = new List<Transito>();
        private readonly string rutaArchivo = @"C:\Datos\\transitos.json";
        public int count;
        #endregion
        #region "CONSTRUTOR"
        public Transitos()
        {
            count = -1;
            CrearArchivoJson();
            CargarDocumento();
        }
        #endregion

        #region "METODOS"
        private static readonly JsonSerializerOptions opcionesJson = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = true
        };
        public void Incrementar()
        {
            count++;
        }
        public void Guardar(Transito nuevoTransito)
        {
            nuevoTransito.Codigo = count + 1;
            listaTransito.Add(nuevoTransito);
            count++;
            GuardarDocumento();
        }
        public bool EnviarATransito(int codigo)
        {
            Transito seleccionado = listaTransito.Find(t => t.Codigo == codigo);
            if (seleccionado == null || !string.Equals((seleccionado.Estado ?? string.Empty).Trim(), "ENTREGADO", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            seleccionado.Estado = "EN TRANSITO";
            GuardarDocumento();
            return true;
        }
        private void CrearArchivoJson()
        {
            if (!File.Exists(rutaArchivo))
            {
                string jsonInicial = JsonSerializer.Serialize(new List<Transito>(), opcionesJson);
                File.WriteAllText(rutaArchivo, jsonInicial);
            }
        }
        private void CargarDocumento()
        {
            if (File.Exists(rutaArchivo))
            {
                string json = File.ReadAllText(rutaArchivo);
                listaTransito = JsonSerializer.Deserialize<List<Transito>>(json);
                count = listaTransito.Count;
            }
        }
        public void GuardarDocumento()
        {
            string json = JsonSerializer.Serialize(listaTransito, opcionesJson);
            File.WriteAllText(rutaArchivo, json);
        }

        public void MostrarTransito(DataGridView transitos)
        {
            try
            {
                transitos.RowCount = count + 1;
            }
            catch
            {
                transitos.RowCount = 1;
            }
            transitos.RowCount = count;
            for (int i=0; i< count; i++)
            {
                transitos.Rows[i].Tag = listaTransito[i].Codigo;
                transitos[0, i].Value = listaTransito[i].Chasis;
                transitos[1, i].Value = listaTransito[i].Placa;
                transitos[2, i].Value = listaTransito[i].Modalidad;
                transitos[3, i].Value = listaTransito[i].NroInformeDip;
                transitos[4, i].Value = listaTransito[i].FechaRetorno;
                transitos[5, i].Value = listaTransito[i].FechaEnvioTransito;
                transitos[6, i].Value = listaTransito[i].Estado;
            }
        }
        #endregion
    }
}
