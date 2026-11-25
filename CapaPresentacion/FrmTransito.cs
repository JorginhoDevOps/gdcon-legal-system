using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmTransito : Form
    {
        public FrmTransito()
        {
            InitializeComponent();
            EstiloUI.Aplicar(this, 4);
        }
        Transitos transitos = new Transitos();

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            Transito nuevoTransito = new Transito
            {
                Chasis = txtChasis.Text,
                Placa = txtPlaca.Text,
                Modalidad = txtContado.Text,
                NroInformeDip = txtNroInforme.Text,
                FechaRetorno = dtpFechaRetorno.Value,
                FechaEnvioTransito = dtpFechaEnvioTransito.Value,
            };
            transitos.Guardar(nuevoTransito);
            transitos.MostrarTransito(dgvPlacas);
            transitos.GuardarDocumento();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmTransito_Load(object sender, EventArgs e)
        {

            transitos.MostrarTransito(dgvPlacas);
            transitos.GuardarDocumento();


        }

        private void btnEnviarTransito_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvPlacas.CurrentRow;
            if (fila == null || !(fila.Tag is int codigo))
            {
                MessageBox.Show("Haz doble clic en una fila para seleccionarla.", "Enviar a Tránsito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!transitos.EnviarATransito(codigo))
            {
                MessageBox.Show("Solo se pueden enviar a tránsito los registros con estado ENTREGADO.", "Enviar a Tránsito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            transitos.MostrarTransito(dgvPlacas);
            MessageBox.Show("El estado se actualizó a EN TRANSITO.", "Enviar a Tránsito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvPlacas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvPlacas.Rows.Count)
            {
                return;
            }

            DataGridViewRow fila = dgvPlacas.Rows[e.RowIndex];
            dgvPlacas.CurrentCell = fila.Cells[0];
            fila.Selected = true;

            txtChasis.Text = Convert.ToString(fila.Cells["colChasis"].Value);
            txtPlaca.Text = Convert.ToString(fila.Cells["colPlaca"].Value);
            txtContado.Text = Convert.ToString(fila.Cells["colModalidad"].Value);
            txtNroInforme.Text = Convert.ToString(fila.Cells["colInforme"].Value);

            DateTime fecha;
            if (DateTime.TryParse(Convert.ToString(fila.Cells["colRetorno"].Value), out fecha))
            {
                dtpFechaRetorno.Value = fecha;
            }

            if (DateTime.TryParse(Convert.ToString(fila.Cells["colEnvioTransito"].Value), out fecha))
            {
                dtpFechaEnvioTransito.Value = fecha;
            }
        }
    }
}
