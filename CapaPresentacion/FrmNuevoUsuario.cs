using System;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmNuevoUsuario : Form
    {
        private readonly Usuarios listaUsuarios;
        public Usuario UsuarioCreado;

        public FrmNuevoUsuario()
        {
            InitializeComponent();
        }

        public FrmNuevoUsuario(Usuarios usuariosExistentes) : this()
        {
            listaUsuarios = usuariosExistentes;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCI.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtClave.Text) ||
                cmbRol.SelectedIndex < 0)
            {
                MessageBox.Show("Completa todos los campos.", "GDCON Legal System",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string correo = txtCorreo.Text.Trim();
            if (!correo.Contains("@"))
            {
                MessageBox.Show("Ingresa un correo electrónico válido.", "GDCON Legal System",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }

            if (listaUsuarios != null && listaUsuarios.Buscar(correo) >= 0)
            {
                MessageBox.Show("Ya existe un usuario registrado con ese correo.", "GDCON Legal System",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }

            UsuarioCreado = new Usuario();
            UsuarioCreado.Ci = txtCI.Text.Trim();
            UsuarioCreado.Nombre = txtNombre.Text.Trim();
            UsuarioCreado.Correo = correo;
            UsuarioCreado.ClaveHash = Usuarios.Hash(txtClave.Text);
            UsuarioCreado.Rol = cmbRol.SelectedItem.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}