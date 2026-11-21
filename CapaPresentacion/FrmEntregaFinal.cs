using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmEntregaFinal : Form
    {
        private CheckBox[] requisitos;

        private readonly Color colBotonActivo = Color.FromArgb(25, 193, 227);
        private readonly Color colBotonBloqueado = Color.FromArgb(154, 167, 182);

        // Colores del aviso inferior
        private readonly Color colAvisoFaltaFondo = Color.FromArgb(253, 236, 236);
        private readonly Color colAvisoFaltaBorde = Color.FromArgb(198, 40, 40);
        private readonly Color colAvisoFaltaTexto = Color.FromArgb(138, 28, 28);
        private readonly Color colAvisoOkFondo = Color.FromArgb(232, 245, 233);
        private readonly Color colAvisoOkBorde = Color.FromArgb(46, 125, 50);
        private readonly Color colAvisoOkTexto = Color.FromArgb(27, 94, 32);

        public FrmEntregaFinal()
        {
            InitializeComponent();

            // Los 7 requisitos que deben estar marcados para poder finalizar
            requisitos = new CheckBox[]
            {
                chkDocsIniciales, chkComprobanteCopia, chkActaImpresa,
                chkPolizaOriginal, chkRuat, chkPlacasMetalicas, chkResolucion
            };

            foreach (CheckBox c in requisitos)
                c.CheckedChanged += Requisito_CheckedChanged;

            btnFinalizarEntrega.Click += btnFinalizarEntrega_Click;

            ActualizarBotonFinalizar();
        }

        // Permite que otro formulario (o la capa de negocio) cargue el trámite elegido.
        // La modalidad viene del trámite (se definió en Recepción), por eso es solo lectura.
        public void CargarTramite(string chasis, string placa, string modalidad)
        {
            txtChasis.Text = chasis;
            txtPlaca.Text = placa;
            txtModalidad.Text = modalidad;
        }

        private void Requisito_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarBotonFinalizar();
        }

        private bool TodosMarcados()
        {
            foreach (CheckBox c in requisitos)
                if (!c.Checked) return false;
            return true;
        }

        // El botón queda bloqueado hasta que TODOS los requisitos estén marcados
        private void ActualizarBotonFinalizar()
        {
            bool ok = TodosMarcados();
            btnFinalizarEntrega.Enabled = ok;
            btnFinalizarEntrega.BackColor = ok ? colBotonActivo : colBotonBloqueado;
            btnFinalizarEntrega.ForeColor = Color.White;

            // Aviso: rojo mientras falte algo, verde cuando todo está completo
            pnlAviso.BackColor = ok ? colAvisoOkFondo : colAvisoFaltaFondo;
            pnlBordeAviso.BackColor = ok ? colAvisoOkBorde : colAvisoFaltaBorde;
            lblAviso.ForeColor = ok ? colAvisoOkTexto : colAvisoFaltaTexto;
            lblAviso.Text = ok
                ? "✓ Documentación completa"
                : "✕ Sin resolución, placas y RUAT no se puede entregar";
        }

        private void btnFinalizarEntrega_Click(object sender, EventArgs e)
        {
            if (!TodosMarcados()) return;   // seguridad extra

            if (string.IsNullOrWhiteSpace(txtEntregadoA.Text))
            {
                MessageBox.Show("Indica a quién se entrega la carpeta.",
                    "GDCON Legal System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEntregadoA.Focus();
                return;
            }

            DialogResult r = MessageBox.Show("¿Confirmas la entrega final del trámite?",
                "GDCON Legal System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes) return;

            dtpFechaEntrega.Value = DateTime.Now;

            // Aquí se cambiará el estado del trámite a "Entregado" (capa de negocio).

            MessageBox.Show("Entrega registrada correctamente.",
                "GDCON Legal System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbActa_Click(object sender, EventArgs e)
        {
            var menu = this.ParentForm as FrmMenuPrincipal;
            if (menu == null) return;

            if (string.IsNullOrWhiteSpace(txtModalidad.Text))
            {
                MessageBox.Show("Este trámite aún no tiene modalidad. Busca o carga un trámite primero.",
                    "GDCON Legal System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtModalidad.Text.Trim().Equals("Crédito", StringComparison.OrdinalIgnoreCase)
                || txtModalidad.Text.Trim().Equals("Credito", StringComparison.OrdinalIgnoreCase))
                menu.AbrirFormulario(new FrmActaCredito());
            else
                menu.AbrirFormulario(new FrmActaContado());
        }
    }
}
