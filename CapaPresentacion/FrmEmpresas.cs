using System;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmEmpresas : Form
    {
        private readonly Empresas empresas = new Empresas();
        private int posActual = -1;

        public FrmEmpresas()
        {
            InitializeComponent();
            EstiloUI.Aplicar(this);

            // Guardar nuevas empresas se hace en la ventanita de Agregar; editar se hace con Modificar
            btnGuardar.Visible = false;
            lblSubtituloModulo.Text = "Presiona Agregar para registrar una nueva empresa, o haz clic en una fila de la tabla para modificarla o eliminarla.";
        }

        private void FrmEmpresas_Load(object sender, EventArgs e)
        {
            empresas.Archivo_VectorEmpresas();
            empresas.Mostrar(dgvEmpresas);
            EstadoInicial();
        }

        // Nada seleccionado: cajas bloqueadas, solo Agregar encendido
        private void EstadoInicial()
        {
            posActual = -1;
            txtNombre.Clear();
            txtNit.Clear();
            txtContado.Clear();
            txtCredito.Clear();

            dgvEmpresas.ClearSelection();
            ActualizarEstado();
        }

        private void CargarEnFormulario(int pos)
        {
            Empresa emp = empresas.Obtener(pos);
            if (emp == null) return;

            posActual = pos;
            txtNombre.Text = emp.Nombre;
            txtNit.Text = emp.Nit;
            txtContado.Text = emp.HonorarioContado.ToString("0.00");
            txtCredito.Text = emp.HonorarioCredito.ToString("0.00");

            ActualizarEstado();
        }

        private void ActualizarEstado()
        {
            bool seleccionado = (posActual >= 0);

            txtNombre.Enabled = seleccionado;
            txtNit.Enabled = seleccionado;
            txtContado.Enabled = seleccionado;
            txtCredito.Enabled = seleccionado;

            btnNuevo.Enabled = !seleccionado;
            btnModificar.Enabled = seleccionado;
            btnEliminar.Enabled = seleccionado;
            btnLimpiar.Enabled = seleccionado;
        }

        private bool LeerDatos(out Empresa emp)
        {
            emp = null;
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                Aviso("Ingresa el nombre de la empresa.", MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            double contado;
            if (!double.TryParse(txtContado.Text.Trim(), out contado) || contado < 0)
            {
                Aviso("Ingresa un honorario al Contado válido (número mayor o igual a 0).", MessageBoxIcon.Warning);
                txtContado.Focus();
                return false;
            }

            double credito;
            if (!double.TryParse(txtCredito.Text.Trim(), out credito) || credito < 0)
            {
                Aviso("Ingresa un honorario a Crédito válido (número mayor o igual a 0).", MessageBoxIcon.Warning);
                txtCredito.Focus();
                return false;
            }

            emp = new Empresa();
            emp.Nombre = txtNombre.Text.Trim().ToUpper();
            emp.Nit = txtNit.Text.Trim();
            emp.HonorarioContado = contado;
            emp.HonorarioCredito = credito;
            return true;
        }

        private void Aviso(string msg, MessageBoxIcon icono)
        {
            MessageBox.Show(msg, "GDCON Legal System", MessageBoxButtons.OK, icono);
        }

        private void dgvEmpresas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            object nombre = dgvEmpresas[0, e.RowIndex].Value;
            if (nombre == null) return;

            int pos = empresas.Buscar(nombre.ToString());
            if (pos >= 0) CargarEnFormulario(pos);
        }

        // Abre la ventanita modal para crear una empresa nueva
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (!empresas.HayEspacio())
            {
                Aviso("Se alcanzó el límite máximo de empresas.", MessageBoxIcon.Warning);
                return;
            }

            FrmNuevaEmpresa ventana = new FrmNuevaEmpresa(empresas);
            if (ventana.ShowDialog(this) == DialogResult.OK && ventana.EmpresaCreada != null)
            {
                empresas.Incrementar();
                empresas.Guardar(ventana.EmpresaCreada);
                empresas.VectorEmpresas_Archivo();
                empresas.Mostrar(dgvEmpresas);
                EstadoInicial();

                Aviso("Empresa registrada correctamente.", MessageBoxIcon.Information);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // No se usa: el alta se realiza desde FrmNuevaEmpresa
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (posActual < 0) return;

            Empresa emp;
            if (!LeerDatos(out emp)) return;

            int existente = empresas.Buscar(emp.Nombre);
            if (existente >= 0 && existente != posActual)
            {
                Aviso("Ese nombre ya pertenece a otra empresa.", MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            empresas.Modificar(posActual, emp);
            empresas.VectorEmpresas_Archivo();
            empresas.Mostrar(dgvEmpresas);
            EstadoInicial();

            Aviso("Empresa modificada correctamente.", MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (posActual < 0) return;

            Empresa emp = empresas.Obtener(posActual);
            if (emp == null) return;

            DialogResult r = MessageBox.Show(
                "¿Seguro que deseas eliminar la empresa " + emp.Nombre + "?",
                "GDCON Legal System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes) return;

            empresas.Eliminar(posActual);
            empresas.VectorEmpresas_Archivo();
            empresas.Mostrar(dgvEmpresas);
            EstadoInicial();

            Aviso("Empresa eliminada correctamente.", MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}