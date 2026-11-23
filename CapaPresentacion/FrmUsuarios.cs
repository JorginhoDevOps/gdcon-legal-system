using System;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmUsuarios : Form
    {
        private readonly Usuarios usuarios = new Usuarios();
        private readonly Usuario usuarioSesion;
        private int posActual = -1;

        public FrmUsuarios()
        {
            InitializeComponent();
            EstiloUI.Aplicar(this);

            // Guardar nuevos se hace en la ventanita de Agregar; editar se hace con Modificar
            btnGuardar.Visible = false;

            this.Load += FrmUsuarios_Load;
            btnNuevo.Click += btnNuevo_Click;
            btnModificar.Click += btnModificar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;

            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public FrmUsuarios(Usuario sesion) : this()
        {
            usuarioSesion = sesion;
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            usuarios.Archivo_VectorUsuarios();
            usuarios.Mostrar(dgvUsuarios);
            EstadoInicial();
        }

        #region "FORMULARIO"
        // Nada seleccionado: panel bloqueado, solo Agregar encendido
        private void EstadoInicial()
        {
            posActual = -1;
            txtCI.Clear();
            txtNombre.Clear();
            txtCorreo.Clear();
            txtClave.Clear();
            cmbRol.SelectedIndex = -1;

            dgvUsuarios.ClearSelection();
            ActualizarEstado();
        }

        private void CargarEnFormulario(int pos)
        {
            Usuario u = usuarios.Obtener(pos);
            if (u == null) return;

            posActual = pos;
            txtCI.Text = u.Ci;
            txtNombre.Text = u.Nombre;
            txtCorreo.Text = u.Correo;
            txtClave.Clear(); // por seguridad no se muestra el hash
            cmbRol.SelectedItem = u.Rol;

            ActualizarEstado();
        }

        private void ActualizarEstado()
        {
            bool seleccionado = (posActual >= 0);

            // Bloquea o desbloquea los campos de datos
            txtCI.Enabled = seleccionado;
            txtNombre.Enabled = seleccionado;
            txtCorreo.Enabled = seleccionado;
            txtClave.Enabled = seleccionado;
            cmbRol.Enabled = seleccionado;

            // Alterna Agregar vs Modificar/Eliminar/Limpiar
            btnNuevo.Enabled = !seleccionado;
            btnModificar.Enabled = seleccionado;
            btnEliminar.Enabled = seleccionado;
            btnLimpiar.Enabled = seleccionado;
        }

        private int ContarAdministradores()
        {
            int total = 0;
            for (int i = 0; i < usuarios.Cantidad(); i++)
            {
                Usuario u = usuarios.Obtener(i);
                if (u != null && u.Rol == "Administrador") total++;
            }
            return total;
        }

        private void Aviso(string msg, MessageBoxIcon icono)
        {
            MessageBox.Show(msg, "GDCON Legal System", MessageBoxButtons.OK, icono);
        }
        #endregion

        #region "ACCIONES CRUD"
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            object correo = dgvUsuarios[2, e.RowIndex].Value;
            if (correo == null) return;

            int pos = usuarios.Buscar(correo.ToString());
            if (pos >= 0) CargarEnFormulario(pos);
        }

        // Abre la ventanita modal para crear un usuario nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (!usuarios.HayEspacio())
            {
                Aviso("Se alcanzó el límite máximo de usuarios.", MessageBoxIcon.Warning);
                return;
            }

            FrmNuevoUsuario ventana = new FrmNuevoUsuario(usuarios);
            if (ventana.ShowDialog(this) == DialogResult.OK && ventana.UsuarioCreado != null)
            {
                usuarios.Incrementar();
                usuarios.Guardar(ventana.UsuarioCreado);
                usuarios.VectorUsuarios_Archivo();
                usuarios.Mostrar(dgvUsuarios);
                EstadoInicial();

                Aviso("Usuario registrado correctamente.", MessageBoxIcon.Information);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (posActual < 0) return;

            if (string.IsNullOrWhiteSpace(txtCI.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                cmbRol.SelectedIndex < 0)
            {
                Aviso("Completa CI, nombre, correo y rol.", MessageBoxIcon.Warning);
                return;
            }

            string correo = txtCorreo.Text.Trim();
            if (!correo.Contains("@"))
            {
                Aviso("Ingresa un correo electrónico válido.", MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }

            int existente = usuarios.Buscar(correo);
            if (existente >= 0 && existente != posActual)
            {
                Aviso("Ese correo ya pertenece a otro usuario.", MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }

            Usuario actual = usuarios.Obtener(posActual);
            string nuevoRol = cmbRol.SelectedItem.ToString();

            if (actual.Rol == "Administrador" && nuevoRol != "Administrador" && ContarAdministradores() <= 1)
            {
                Aviso("Debe existir al menos un Administrador en el sistema.", MessageBoxIcon.Warning);
                return;
            }

            Usuario u = new Usuario();
            u.Ci = txtCI.Text.Trim();
            u.Nombre = txtNombre.Text.Trim();
            u.Correo = correo;
            u.ClaveHash = string.IsNullOrWhiteSpace(txtClave.Text)
                ? actual.ClaveHash
                : Usuarios.Hash(txtClave.Text);
            u.Rol = nuevoRol;

            usuarios.Modificar(posActual, u);
            usuarios.VectorUsuarios_Archivo();
            usuarios.Mostrar(dgvUsuarios);
            EstadoInicial();

            Aviso("Usuario modificado correctamente.", MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (posActual < 0) return;

            Usuario u = usuarios.Obtener(posActual);
            if (u == null) return;

            if (usuarioSesion != null &&
                string.Equals(u.Correo, usuarioSesion.Correo, StringComparison.OrdinalIgnoreCase))
            {
                Aviso("No puedes eliminar el usuario con el que iniciaste sesión.", MessageBoxIcon.Warning);
                return;
            }

            if (u.Rol == "Administrador" && ContarAdministradores() <= 1)
            {
                Aviso("No se puede eliminar al último Administrador del sistema.", MessageBoxIcon.Warning);
                return;
            }

            DialogResult r = MessageBox.Show(
                "¿Seguro que deseas eliminar al usuario " + u.Nombre + "?",
                "GDCON Legal System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes) return;

            usuarios.Eliminar(posActual);
            usuarios.VectorUsuarios_Archivo();
            usuarios.Mostrar(dgvUsuarios);
            EstadoInicial();

            Aviso("Usuario eliminado correctamente.", MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}