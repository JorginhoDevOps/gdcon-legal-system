using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class Usuarios
    {
        #region "ATRIBUTOS"
        List<Usuario> ListaUsuarios = new List<Usuario>();
        #endregion

        #region "CONSTRUCTOR"
        public Usuarios()
        {
            ListaUsuarios = new List<Usuario>();
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
            return ListaUsuarios.Count;
        }
        public void Guardar(Usuario DatosUsu)
        {
            DatosUsu.Codigo = ListaUsuarios.Count + 1;
            ListaUsuarios.Add(DatosUsu);
        }
        public int Buscar(string Correo)
        {
            for (int V = 0; V < ListaUsuarios.Count; V++)
                if (string.Equals(ListaUsuarios[V].Correo, Correo, StringComparison.OrdinalIgnoreCase))
                    return V;
            return -1;
        }
        public Usuario Obtener(int Pos)
        {
            if (Pos < 0 || Pos >= ListaUsuarios.Count) return null;
            return ListaUsuarios[Pos];
        }
        public void Modificar(int Pos, Usuario DatosUsu)
        {
            if (Pos < 0 || Pos >= ListaUsuarios.Count) return;
            DatosUsu.Codigo = ListaUsuarios[Pos].Codigo;
            ListaUsuarios[Pos] = DatosUsu;
        }
        public void Eliminar(int Pos)
        {
            if (Pos < 0 || Pos >= ListaUsuarios.Count) return;
            ListaUsuarios.RemoveAt(Pos);
            for (int V = 0; V < ListaUsuarios.Count; V++)
                ListaUsuarios[V].Codigo = V + 1;
        }
        public Usuario Validar(string Correo, string Clave, string Rol)
        {
            int Pos = Buscar(Correo);
            if (Pos < 0) return null;
            if (ListaUsuarios[Pos].ClaveHash == Hash(Clave) && ListaUsuarios[Pos].Rol == Rol)
                return ListaUsuarios[Pos];
            return null;
        }
        public static string Hash(string Texto)
        {
            using (SHA256 Sha = SHA256.Create())
                return BitConverter.ToString(Sha.ComputeHash(Encoding.UTF8.GetBytes(Texto))).Replace("-", "");
        }
        public void Mostrar(DataGridView Dgv)
        {
            if (ListaUsuarios.Count == 0)
            {
                Dgv.Rows.Clear();
                return;
            }
            Dgv.RowCount = ListaUsuarios.Count;
            for (int V = 0; V < ListaUsuarios.Count; V++)
            {
                Dgv[0, V].Value = ListaUsuarios[V].Ci;
                Dgv[1, V].Value = ListaUsuarios[V].Nombre;
                Dgv[2, V].Value = ListaUsuarios[V].Correo;
                Dgv[3, V].Value = ListaUsuarios[V].Rol;
            }
        }
        #endregion

        #region "ARCHIVO JSON"
        string Archivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datos", "Usuarios.json");
        JsonSerializerOptions OpcionesJson = new JsonSerializerOptions
        {
            WriteIndented = true,
            IncludeFields = true
        };

        public void VectorUsuarios_Archivo()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(Archivo));
            string Json = JsonSerializer.Serialize(ListaUsuarios, OpcionesJson);
            File.WriteAllText(Archivo, Json);
        }

        public void Archivo_VectorUsuarios()
        {
            ListaUsuarios.Clear();
            if (!File.Exists(Archivo))
            {
                CrearArchivo();
            }
            else
            {
                try
                {
                    string Json = File.ReadAllText(Archivo);
                    List<Usuario> Cargados = JsonSerializer.Deserialize<List<Usuario>>(Json, OpcionesJson);
                    if (Cargados != null) ListaUsuarios = Cargados;
                }
                catch
                {
                    CrearArchivo();
                }
            }
            if (ListaUsuarios.Count == 0) CrearUsuariosPrueba();
        }

        public void CrearArchivo()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(Archivo));
            File.WriteAllText(Archivo, "[]");
        }

        void CrearUsuariosPrueba()
        {
            ListaUsuarios.Clear();
            Guardar(new Usuario { Ci = "0000001", Nombre = "Administrador", Correo = "admin@gdcon.com", ClaveHash = Hash("Admin123"), Rol = "Administrador" });
            Guardar(new Usuario { Ci = "0000002", Nombre = "Operador", Correo = "operador@gdcon.com", ClaveHash = Hash("Oper123"), Rol = "Operador" });
            VectorUsuarios_Archivo();
        }
        #endregion
    }
}