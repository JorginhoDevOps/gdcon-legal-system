using System;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmNuevaEmpresa : Form
    {
        private readonly Empresas listaEmpresas;
        public Empresa EmpresaCreada;

        public FrmNuevaEmpresa()
        {
            InitializeComponent();
        }

        public FrmNuevaEmpresa(Empresas empresasExistentes) : this()
        {
            listaEmpresas = empresasExistentes;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingresa el nombre de la empresa.", "GDCON Legal System",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            double contado;
            if (!double.TryParse(txtContado.Text.Trim(), out contado) || contado < 0)
            {
                MessageBox.Show("Ingresa un honorario al Contado válido (número mayor o igual a 0).", "GDCON Legal System",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContado.Focus();
                return;
            }

            double credito;
            if (!double.TryParse(txtCredito.Text.Trim(), out credito) || credito < 0)
            {
                MessageBox.Show("Ingresa un honorario a Crédito válido (número mayor o igual a 0).", "GDCON Legal System",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCredito.Focus();
                return;
            }

            string nombre = txtNombre.Text.Trim().ToUpper();
            if (listaEmpresas != null && listaEmpresas.Buscar(nombre) >= 0)
            {
                MessageBox.Show("Ya existe una empresa registrada con ese nombre.", "GDCON Legal System",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            EmpresaCreada = new Empresa();
            EmpresaCreada.Nombre = nombre;
            EmpresaCreada.Nit = txtNit.Text.Trim();
            EmpresaCreada.HonorarioContado = contado;
            EmpresaCreada.HonorarioCredito = credito;

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