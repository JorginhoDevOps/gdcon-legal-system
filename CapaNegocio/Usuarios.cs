using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Text.Json;

namespace CapaNegocio
{
    public class Usuarios
    {
        #region "ATRIBUTOS"
        Usuario[] VUsuarios = new Usuario[30];
        int Vis;
        #endregion

        #region "CONSTRUCTOR"
        public Usuarios()
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
            return Vis < VUsuarios.Length - 1;
        }
        public int Cantidad()
        {
            return Vis + 1;
        }
        public void Guardar(Usuario DatosUsu)
        {
            DatosUsu.Codigo = Vis + 1;
            VUsuarios[Vis] = DatosUsu;
        }
        public int Buscar(string Correo)
        {
            for (int V = 0; V <= Vis; V++)
                if (string.Equals(VUsuarios[V].Correo, Correo, StringComparison.OrdinalIgnoreCase))
                    return V;
            return -1;
        }
        public Usuario Obtener(int Pos)
        {
            if (Pos < 0 || Pos > Vis) return null;
            return VUsuarios[Pos];
        }
        public void Modificar(int Pos, Usuario DatosUsu)
        {
            if (Pos < 0 || Pos > Vis) return;
            DatosUsu.Codigo = VUsuarios[Pos].Codigo;
            VUsuarios[Pos] = DatosUsu;
        }
        public void Eliminar(int Pos)
        {
            if (Pos < 0 || Pos > Vis) return;
            for (int V = Pos; V < Vis; V++)
            {
                VUsuarios[V] = VUsuarios[V + 1];
                VUsuarios[V].Codigo = V + 1;
            }
            VUsuarios[Vis] = null;
            Vis--;
        }
        public Usuario Validar(string Correo, string Clave, string Rol)
        {
            int Pos = Buscar(Correo);
            if (Pos < 0) return null;
            if (VUsuarios[Pos].ClaveHash == Hash(Clave) && VUsuarios[Pos].Rol == Rol)
                return VUsuarios[Pos];
            return null;
        }
        public static string Hash(string Texto)
        {
            using (SHA256 Sha = SHA256.Create())
                return BitConverter.ToString(Sha.ComputeHash(Encoding.UTF8.GetBytes(Texto))).Replace("-", "");
        }
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
                Dgv[0, V].Value = VUsuarios[V].Ci;
                Dgv[1, V].Value = VUsuarios[V].Nombre;
                Dgv[2, V].Value = VUsuarios[V].Correo;
                Dgv[3, V].Value = VUsuarios[V].Rol;
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
            List<Usuario> Lista = new List<Usuario>();
            for (int V = 0; V <= Vis; V++)
                Lista.Add(VUsuarios[V]);

            string Json = JsonSerializer.Serialize(Lista, OpcionesJson);
            File.WriteAllText(Archivo, Json);
        }

        public void Archivo_VectorUsuarios()
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
                    List<Usuario> Lista = JsonSerializer.Deserialize<List<Usuario>>(Json, OpcionesJson);
                    if (Lista != null)
                    {
                        for (int I = 0; I < Lista.Count; I++)
                        {
                            if (!HayEspacio()) break;
                            Incrementar();
                            VUsuarios[Vis] = Lista[I];
                        }
                    }
                }
                catch
                {
                    CrearArchivo();
                }
            }
            if (Vis == -1) CrearUsuariosPrueba();
        }

        public void CrearArchivo()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(Archivo));
            File.WriteAllText(Archivo, "[]");
        }

        void CrearUsuariosPrueba()
        {
            Vis = -1;
            Incrementar();
            Guardar(new Usuario { Ci = "0000001", Nombre = "Administrador", Correo = "admin@gdcon.com", ClaveHash = Hash("Admin123"), Rol = "Administrador" });
            Incrementar();
            Guardar(new Usuario { Ci = "0000002", Nombre = "Operador", Correo = "operador@gdcon.com", ClaveHash = Hash("Oper123"), Rol = "Operador" });
            VectorUsuarios_Archivo();
        }
        #endregion
    }
}
