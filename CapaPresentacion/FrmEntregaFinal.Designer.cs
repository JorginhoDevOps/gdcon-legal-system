namespace CapaPresentacion
{
    partial class FrmEntregaFinal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntregaFinal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregarNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvEntregas = new System.Windows.Forms.DataGridView();
            this.colCI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregas)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregarNuevo,
            this.btnGuardar,
            this.btnModificar,
            this.btnEliminar,
            this.btnLimpiar,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1313, 85);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAgregarNuevo
            // 
            this.btnAgregarNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarNuevo.Image")));
            this.btnAgregarNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregarNuevo.Name = "btnAgregarNuevo";
            this.btnAgregarNuevo.Size = new System.Drawing.Size(126, 79);
            this.btnAgregarNuevo.Text = "Agregar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(126, 79);
            this.btnGuardar.Text = "Guardar";
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(143, 79);
            this.btnModificar.Text = "Modificar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(127, 79);
            this.btnEliminar.Text = "Eliminar";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 79);
            this.btnLimpiar.Text = "Limpiar";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 79);
            this.btnSalir.Text = "Salir";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 724);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvEntregas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(400, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(913, 724);
            this.panel2.TabIndex = 0;
            // 
            // dgvEntregas
            // 
            this.dgvEntregas.AllowUserToAddRows = false;
            this.dgvEntregas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEntregas.BackgroundColor = System.Drawing.Color.White;
            this.dgvEntregas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEntregas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntregas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEntregas.ColumnHeadersHeight = 46;
            this.dgvEntregas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCI,
            this.colNombre,
            this.colCorreo,
            this.colRol});
            this.dgvEntregas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEntregas.EnableHeadersVisualStyles = false;
            this.dgvEntregas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvEntregas.Location = new System.Drawing.Point(0, 0);
            this.dgvEntregas.Margin = new System.Windows.Forms.Padding(6);
            this.dgvEntregas.Name = "dgvEntregas";
            this.dgvEntregas.RowHeadersWidth = 82;
            this.dgvEntregas.Size = new System.Drawing.Size(913, 724);
            this.dgvEntregas.TabIndex = 3;
            // 
            // colCI
            // 
            this.colCI.HeaderText = "CI";
            this.colCI.MinimumWidth = 10;
            this.colCI.Name = "colCI";
            // 
            // colNombre
            // 
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombre.HeaderText = "Nombre Completo";
            this.colNombre.MinimumWidth = 10;
            this.colNombre.Name = "colNombre";
            // 
            // colCorreo
            // 
            this.colCorreo.HeaderText = "Correo";
            this.colCorreo.MinimumWidth = 10;
            this.colCorreo.Name = "colCorreo";
            // 
            // colRol
            // 
            this.colRol.HeaderText = "Rol";
            this.colRol.MinimumWidth = 10;
            this.colRol.Name = "colRol";
            // 
            // FrmEntregaFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1313, 809);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEntregaFinal";
            this.Text = "FrmEntregaFinal";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAgregarNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnLimpiar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvEntregas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRol;
    }
}