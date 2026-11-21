using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

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

        #region "ARCHIVO TIPO TEXTO"
       
        string Archivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datos", "Usuarios.txt");

        public void VectorUsuarios_Archivo()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(Archivo));
            using (StreamWriter Obj = File.CreateText(Archivo))
            {
                string Linea;
                for (int V = 0; V <= Vis; V++)
                {
                    Linea = VUsuarios[V].Codigo.ToString() + "*" +
                        VUsuarios[V].Ci + "*" +
                        VUsuarios[V].Nombre + "*" +
                        VUsuarios[V].Correo + "*" +
                        VUsuarios[V].ClaveHash + "*" +
                        VUsuarios[V].Rol + "*";
                    Obj.WriteLine(Linea);
                }
            }
        }

        public void Archivo_VectorUsuarios()
        {
            Vis = -1;
            try
            {
                using (StreamReader Obj = File.OpenText(Archivo))
                {
                    string Linea;
                    string[] Separados = new string[6];
                    while ((Linea = Obj.ReadLine()) != null)
                    {
                        if (!HayEspacio()) break;
                        Separados = Linea.Split('*');
                        Incrementar();
                        VUsuarios[Vis] = new Usuario();
                        VUsuarios[Vis].Codigo = Convert.ToInt32(Separados[0]);
                        VUsuarios[Vis].Ci = Separados[1];
                        VUsuarios[Vis].Nombre = Separados[2];
                        VUsuarios[Vis].Correo = Separados[3];
                        VUsuarios[Vis].ClaveHash = Separados[4];
                        VUsuarios[Vis].Rol = Separados[5];
                    }
                }
            }
            catch
            {
                CrearArchivo();
            }
            if (Vis == -1) CrearUsuariosPrueba();
        }
        public void CrearArchivo()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(Archivo));
            using (StreamWriter Obj = File.CreateText(Archivo))
            { }
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
