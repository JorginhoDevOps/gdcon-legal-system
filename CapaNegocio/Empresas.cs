using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.Json;

namespace CapaNegocio
{
    public class Empresas
    {
        #region "ATRIBUTOS"
        Empresa[] VEmpresas = new Empresa[30];
        int Vis;
        #endregion

        #region "CONSTRUCTOR"
        public Empresas()
        {
            Vis = -1;
        }
        #endregion

        #region "METODOS"
        public void Incrementar()
        {
            Vis++;
        }
        public bool HayEspacio()
        {
            return Vis < VEmpresas.Length - 1;
        }
        public int Cantidad()
        {
            return Vis + 1;
        }
        public void Guardar(Empresa DatosEmp)
        {
            DatosEmp.Codigo = Vis + 1;
            VEmpresas[Vis] = DatosEmp;
        }
        public int Buscar(string Nombre)
        {
            for (int V = 0; V <= Vis; V++)
                if (string.Equals(VEmpresas[V].Nombre, Nombre, StringComparison.OrdinalIgnoreCase))
                    return V;
            return -1;
        }
        public Empresa Obtener(int Pos)
        {
            if (Pos < 0 || Pos > Vis) return null;
            return VEmpresas[Pos];
        }
        public void Modificar(int Pos, Empresa DatosEmp)
        {
            if (Pos < 0 || Pos > Vis) return;
            DatosEmp.Codigo = VEmpresas[Pos].Codigo;
            VEmpresas[Pos] = DatosEmp;
        }
        public void Eliminar(int Pos)
        {
            if (Pos < 0 || Pos > Vis) return;
            for (int V = Pos; V < Vis; V++)
            {
                VEmpresas[V] = VEmpresas[V + 1];
                VEmpresas[V].Codigo = V + 1;
            }
            VEmpresas[Vis] = null;
            Vis--;
        }

        // Nombres para llenar el ComboBox de Recepción
        public string[] Nombres()
        {
            string[] Lista = new string[Vis + 1];
            for (int V = 0; V <= Vis; V++)
                Lista[V] = VEmpresas[V].Nombre;
            return Lista;
        }

        // Honorario que se cobra a una empresa según la modalidad del trámite
        public double Honorario(string NombreEmpresa, string Modalidad)
        {
            int Pos = Buscar(NombreEmpresa);
            if (Pos < 0) return 0;
            if (string.Equals(Modalidad, "Crédito", StringComparison.OrdinalIgnoreCase))
                return VEmpresas[Pos].HonorarioCredito;
            return VEmpresas[Pos].HonorarioContado;
        }

        // Columnas del DataGridView: Nombre, NIT, Honorario Contado, Honorario Crédito
        public void Mostrar(DataGridView Dgv)
        {
            try
            {
                Dgv.RowCount = Vis + 1;
            }
            catch
            {
                Dgv.RowCount = 1;
            }
            for (int V = 0; V <= Vis; V++)
            {
                Dgv[0, V].Value = VEmpresas[V].Nombre;
                Dgv[1, V].Value = VEmpresas[V].Nit;
                Dgv[2, V].Value = VEmpresas[V].HonorarioContado.ToString("0.00");
                Dgv[3, V].Value = VEmpresas[V].HonorarioCredito.ToString("0.00");
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
            List<Empresa> Lista = new List<Empresa>();
            for (int V = 0; V <= Vis; V++)
                Lista.Add(VEmpresas[V]);

            string Json = JsonSerializer.Serialize(Lista, OpcionesJson);
            File.WriteAllText(Archivo, Json);
        }

        public void Archivo_VectorEmpresas()
        {
            Vis = -1;
            if (!File.Exists(Archivo))
            {
                CrearArchivo();
            }
            else
            {
                try
                {
                    string Json = File.ReadAllText(Archivo);
                    List<Empresa> Lista = JsonSerializer.Deserialize<List<Empresa>>(Json, OpcionesJson);
                    if (Lista != null)
                    {
                        for (int I = 0; I < Lista.Count; I++)
                        {
                            if (!HayEspacio()) break;
                            Incrementar();
                            VEmpresas[Vis] = Lista[I];
                        }
                    }
                }
                catch
                {
                    CrearArchivo();
                }
            }
            if (Vis == -1) CrearEmpresasPrueba();
        }

        public void CrearArchivo()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(Archivo));
            File.WriteAllText(Archivo, "[]");
        }

        // Valores de PRUEBA: el administrador los cambiará con los honorarios reales
        void CrearEmpresasPrueba()
        {
            Vis = -1;
            Incrementar();
            Guardar(new Empresa { Nombre = "IMCRUZ", Nit = "", HonorarioContado = 900, HonorarioCredito = 1100 });
            Incrementar();
            Guardar(new Empresa { Nombre = "TOYOSA", Nit = "", HonorarioContado = 850, HonorarioCredito = 1000 });
            Incrementar();
            Guardar(new Empresa { Nombre = "OVANDO", Nit = "", HonorarioContado = 800, HonorarioCredito = 950 });
            VectorEmpresas_Archivo();
        }
        #endregion
    }
}
