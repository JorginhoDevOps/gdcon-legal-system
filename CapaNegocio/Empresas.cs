using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class Empresas
    {
        #region "ATRIBUTOS"
        List<Empresa> ListaEmpresas = new List<Empresa>();
        #endregion

        #region "CONSTRUCTOR"
        public Empresas()
        {
            ListaEmpresas = new List<Empresa>();
        }
        #endregion

        #region "METODOS"
        public void Incrementar()
        {

        }
        public bool HayEspacio()
        {
            return true;
        }
        public int Cantidad()
        {
            return ListaEmpresas.Count;
        }
        public void Guardar(Empresa DatosEmp)
        {
            DatosEmp.Codigo = ListaEmpresas.Count + 1;
            ListaEmpresas.Add(DatosEmp);
        }
        public int Buscar(string Nombre)
        {
            for (int V = 0; V < ListaEmpresas.Count; V++)
                if (string.Equals(ListaEmpresas[V].Nombre, Nombre, StringComparison.OrdinalIgnoreCase))
                    return V;
            return -1;
        }
        public Empresa Obtener(int Pos)
        {
            if (Pos < 0 || Pos >= ListaEmpresas.Count) return null;
            return ListaEmpresas[Pos];
        }
        public void Modificar(int Pos, Empresa DatosEmp)
        {
            if (Pos < 0 || Pos >= ListaEmpresas.Count) return;
            DatosEmp.Codigo = ListaEmpresas[Pos].Codigo;
            ListaEmpresas[Pos] = DatosEmp;
        }
        public void Eliminar(int Pos)
        {
            if (Pos < 0 || Pos >= ListaEmpresas.Count) return;
            ListaEmpresas.RemoveAt(Pos);
            for (int V = 0; V < ListaEmpresas.Count; V++)
                ListaEmpresas[V].Codigo = V + 1;
        }

        // Nombres para llenar el ComboBox de Recepción
        public string[] Nombres()
        {
            string[] Lista = new string[ListaEmpresas.Count];
            for (int V = 0; V < ListaEmpresas.Count; V++)
                Lista[V] = ListaEmpresas[V].Nombre;
            return Lista;
        }

        // Honorario que se cobra a una empresa según la modalidad del trámite
        public double Honorario(string NombreEmpresa, string Modalidad)
        {
            int Pos = Buscar(NombreEmpresa);
            if (Pos < 0) return 0;
            if (string.Equals(Modalidad, "Crédito", StringComparison.OrdinalIgnoreCase))
                return ListaEmpresas[Pos].HonorarioCredito;
            return ListaEmpresas[Pos].HonorarioContado;
        }

        // Columnas del DataGridView: Nombre, NIT, Honorario Contado, Honorario Crédito
        public void Mostrar(DataGridView Dgv)
        {
            if (ListaEmpresas.Count == 0)
            {
                Dgv.Rows.Clear();
                return;
            }
            Dgv.RowCount = ListaEmpresas.Count;
            for (int V = 0; V < ListaEmpresas.Count; V++)
            {
                Dgv[0, V].Value = ListaEmpresas[V].Nombre;
                Dgv[1, V].Value = ListaEmpresas[V].Nit;
                Dgv[2, V].Value = ListaEmpresas[V].HonorarioContado.ToString("0.00");
                Dgv[3, V].Value = ListaEmpresas[V].HonorarioCredito.ToString("0.00");
            }
        }
        #endregion

        #region "ARCHIVO JSON"
        string Archivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datos", "Empresas.json");
        JsonSerializerOptions OpcionesJson = new JsonSerializerOptions
        {
            WriteIndented = true,
            IncludeFields = true
        };

        public void VectorEmpresas_Archivo()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(Archivo));
            string Json = JsonSerializer.Serialize(ListaEmpresas, OpcionesJson);
            File.WriteAllText(Archivo, Json);
        }

        public void Archivo_VectorEmpresas()
        {
            ListaEmpresas.Clear();
            if (!File.Exists(Archivo))
            {
                CrearArchivo();
            }
            else
            {
                try
                {
                    string Json = File.ReadAllText(Archivo);
                    List<Empresa> Cargadas = JsonSerializer.Deserialize<List<Empresa>>(Json, OpcionesJson);
                    if (Cargadas != null) ListaEmpresas = Cargadas;
                }
                catch
                {
                    CrearArchivo();
                }
            }
            if (ListaEmpresas.Count == 0) CrearEmpresasPrueba();
        }

        public void CrearArchivo()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(Archivo));
            File.WriteAllText(Archivo, "[]");
        }

        void CrearEmpresasPrueba()
        {
            ListaEmpresas.Clear();
            Guardar(new Empresa { Nombre = "IMCRUZ", Nit = "", HonorarioContado = 900, HonorarioCredito = 1100 });
            Guardar(new Empresa { Nombre = "TOYOSA", Nit = "", HonorarioContado = 850, HonorarioCredito = 1000 });
            Guardar(new Empresa { Nombre = "OVANDO", Nit = "", HonorarioContado = 800, HonorarioCredito = 950 });
            VectorEmpresas_Archivo();
        }
        #endregion
    }
}