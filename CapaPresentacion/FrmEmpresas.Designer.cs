namespace CapaPresentacion
{
    partial class FrmEmpresas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.pnlGuia = new System.Windows.Forms.Panel();
            this.lblSubtituloModulo = new System.Windows.Forms.Label();
            this.lblTituloModulo = new System.Windows.Forms.Label();
            this.pnlCuerpo = new System.Windows.Forms.Panel();
            this.pnlLista = new System.Windows.Forms.Panel();
            this.dgvEmpresas = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlEncabezadoLista = new System.Windows.Forms.Panel();
            this.lblTituloLista = new System.Windows.Forms.Label();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.lblCredito = new System.Windows.Forms.Label();
            this.txtContado = new System.Windows.Forms.TextBox();
            this.lblContado = new System.Windows.Forms.Label();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.lblNit = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlEncabezadoDatos = new System.Windows.Forms.Panel();
            this.lblTituloDatos = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.pnlGuia.SuspendLayout();
            this.pnlCuerpo.SuspendLayout();
            this.pnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).BeginInit();
            this.pnlEncabezadoLista.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            this.pnlEncabezadoDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnModificar,
            this.btnEliminar,
            this.btnLimpiar,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(960, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(57, 24);
            this.btnNuevo.Text = "Agregar";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(57, 24);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(66, 24);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(58, 24);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(54, 24);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(37, 24);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnlGuia
            // 
            this.pnlGuia.BackColor = System.Drawing.Color.White;
            this.pnlGuia.Controls.Add(this.lblSubtituloModulo);
            this.pnlGuia.Controls.Add(this.lblTituloModulo);
            this.pnlGuia.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGuia.Location = new System.Drawing.Point(0, 27);
            this.pnlGuia.Name = "pnlGuia";
            this.pnlGuia.Padding = new System.Windows.Forms.Padding(16, 10, 16, 8);
            this.pnlGuia.Size = new System.Drawing.Size(960, 58);
            this.pnlGuia.TabIndex = 1;
            // 
            // lblTituloModulo
            // 
            this.lblTituloModulo.AutoSize = true;
            this.lblTituloModulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloModulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblTituloModulo.Location = new System.Drawing.Point(16, 8);
            this.lblTituloModulo.Name = "lblTituloModulo";
            this.lblTituloModulo.Size = new System.Drawing.Size(262, 21);
            this.lblTituloModulo.TabIndex = 0;
            this.lblTituloModulo.Text = "Gestión de Empresas y Honorarios";
            // 
            // lblSubtituloModulo
            // 
            this.lblSubtituloModulo.AutoSize = true;
            this.lblSubtituloModulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtituloModulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSubtituloModulo.Location = new System.Drawing.Point(16, 32);
            this.lblSubtituloModulo.Name = "lblSubtituloModulo";
            this.lblSubtituloModulo.Size = new System.Drawing.Size(598, 15);
            this.lblSubtituloModulo.TabIndex = 1;
            this.lblSubtituloModulo.Text = "Completa los datos para registrar una nueva empresa, o haz clic en una fila de la tabla para modificarla o eliminarla.";
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.Controls.Add(this.pnlLista);
            this.pnlCuerpo.Controls.Add(this.pnlDatos);
            this.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCuerpo.Location = new System.Drawing.Point(0, 85);
            this.pnlCuerpo.Name = "pnlCuerpo";
            this.pnlCuerpo.Padding = new System.Windows.Forms.Padding(16);
            this.pnlCuerpo.Size = new System.Drawing.Size(960, 475);
            this.pnlCuerpo.TabIndex = 2;
            // 
            // pnlLista
            // 
            this.pnlLista.Controls.Add(this.dgvEmpresas);
            this.pnlLista.Controls.Add(this.pnlEncabezadoLista);
            this.pnlLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLista.Location = new System.Drawing.Point(376, 16);
            this.pnlLista.Name = "pnlLista";
            this.pnlLista.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.pnlLista.Size = new System.Drawing.Size(568, 443);
            this.pnlLista.TabIndex = 1;
            // 
            // pnlEncabezadoLista
            // 
            this.pnlEncabezadoLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.pnlEncabezadoLista.Controls.Add(this.lblTituloLista);
            this.pnlEncabezadoLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezadoLista.Location = new System.Drawing.Point(16, 0);
            this.pnlEncabezadoLista.Name = "pnlEncabezadoLista";
            this.pnlEncabezadoLista.Size = new System.Drawing.Size(552, 40);
            this.pnlEncabezadoLista.TabIndex = 1;
            // 
            // lblTituloLista
            // 
            this.lblTituloLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTituloLista.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTituloLista.ForeColor = System.Drawing.Color.White;
            this.lblTituloLista.Location = new System.Drawing.Point(0, 0);
            this.lblTituloLista.Name = "lblTituloLista";
            this.lblTituloLista.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblTituloLista.Size = new System.Drawing.Size(552, 40);
            this.lblTituloLista.TabIndex = 0;
            this.lblTituloLista.Text = "Empresas registradas (clic en una fila para editar)";
            this.lblTituloLista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvEmpresas
            // 
            this.dgvEmpresas.AllowUserToAddRows = false;
            this.dgvEmpresas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colNit,
            this.colContado,
            this.colCredito});
            this.dgvEmpresas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmpresas.Location = new System.Drawing.Point(16, 40);
            this.dgvEmpresas.Name = "dgvEmpresas";
            this.dgvEmpresas.ReadOnly = true;
            this.dgvEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpresas.Size = new System.Drawing.Size(552, 403);
            this.dgvEmpresas.TabIndex = 0;
            this.dgvEmpresas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpresas_CellClick);
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Empresa";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colNit
            // 
            this.colNit.HeaderText = "NIT";
            this.colNit.Name = "colNit";
            this.colNit.ReadOnly = true;
            // 
            // colContado
            // 
            this.colContado.HeaderText = "Honorario Contado (Bs)";
            this.colContado.Name = "colContado";
            this.colContado.ReadOnly = true;
            // 
            // colCredito
            // 
            this.colCredito.HeaderText = "Honorario Crédito (Bs)";
            this.colCredito.Name = "colCredito";
            this.colCredito.ReadOnly = true;
            // 
            // pnlDatos
            // 
            this.pnlDatos.BackColor = System.Drawing.Color.White;
            this.pnlDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatos.Controls.Add(this.txtCredito);
            this.pnlDatos.Controls.Add(this.lblCredito);
            this.pnlDatos.Controls.Add(this.txtContado);
            this.pnlDatos.Controls.Add(this.lblContado);
            this.pnlDatos.Controls.Add(this.txtNit);
            this.pnlDatos.Controls.Add(this.lblNit);
            this.pnlDatos.Controls.Add(this.txtNombre);
            this.pnlDatos.Controls.Add(this.lblNombre);
            this.pnlDatos.Controls.Add(this.pnlEncabezadoDatos);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDatos.Location = new System.Drawing.Point(16, 16);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(360, 443);
            this.pnlDatos.TabIndex = 0;
            // 
            // pnlEncabezadoDatos
            // 
            this.pnlEncabezadoDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.pnlEncabezadoDatos.Controls.Add(this.lblTituloDatos);
            this.pnlEncabezadoDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezadoDatos.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezadoDatos.Name = "pnlEncabezadoDatos";
            this.pnlEncabezadoDatos.Size = new System.Drawing.Size(358, 40);
            this.pnlEncabezadoDatos.TabIndex = 0;
            // 
            // lblTituloDatos
            // 
            this.lblTituloDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTituloDatos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTituloDatos.ForeColor = System.Drawing.Color.White;
            this.lblTituloDatos.Location = new System.Drawing.Point(0, 0);
            this.lblTituloDatos.Name = "lblTituloDatos";
            this.lblTituloDatos.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblTituloDatos.Size = new System.Drawing.Size(358, 40);
            this.lblTituloDatos.TabIndex = 0;
            this.lblTituloDatos.Text = "Datos — Empresas y Honorarios";
            this.lblTituloDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(124, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre de la Empresa";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(16, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(324, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.Location = new System.Drawing.Point(16, 120);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(26, 15);
            this.lblNit.TabIndex = 3;
            this.lblNit.Text = "NIT";
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(16, 140);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(324, 23);
            this.txtNit.TabIndex = 4;
            // 
            // lblContado
            // 
            this.lblContado.AutoSize = true;
            this.lblContado.Location = new System.Drawing.Point(16, 180);
            this.lblContado.Name = "lblContado";
            this.lblContado.Size = new System.Drawing.Size(134, 15);
            this.lblContado.TabIndex = 5;
            this.lblContado.Text = "Honorario Contado (Bs)";
            // 
            // txtContado
            // 
            this.txtContado.Location = new System.Drawing.Point(16, 200);
            this.txtContado.Name = "txtContado";
            this.txtContado.Size = new System.Drawing.Size(324, 23);
            this.txtContado.TabIndex = 6;
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.Location = new System.Drawing.Point(16, 240);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(128, 15);
            this.lblCredito.TabIndex = 7;
            this.lblCredito.Text = "Honorario Crédito (Bs)";
            // 
            // txtCredito
            // 
            this.txtCredito.Location = new System.Drawing.Point(16, 260);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(324, 23);
            this.txtCredito.TabIndex = 8;
            // 
            // FrmEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 560);
            this.Controls.Add(this.pnlCuerpo);
            this.Controls.Add(this.pnlGuia);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmEmpresas";
            this.Text = "Empresas y Honorarios";
            this.Load += new System.EventHandler(this.FrmEmpresas_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlGuia.ResumeLayout(false);
            this.pnlGuia.PerformLayout();
            this.pnlCuerpo.ResumeLayout(false);
            this.pnlLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).EndInit();
            this.pnlEncabezadoLista.ResumeLayout(false);
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.pnlEncabezadoDatos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnLimpiar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Panel pnlGuia;
        private System.Windows.Forms.Label lblTituloModulo;
        private System.Windows.Forms.Label lblSubtituloModulo;
        private System.Windows.Forms.Panel pnlCuerpo;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Panel pnlEncabezadoDatos;
        private System.Windows.Forms.Label lblTituloDatos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label lblContado;
        private System.Windows.Forms.TextBox txtContado;
        private System.Windows.Forms.Label lblCredito;
        private System.Windows.Forms.TextBox txtCredito;
        private System.Windows.Forms.Panel pnlLista;
        private System.Windows.Forms.Panel pnlEncabezadoLista;
        private System.Windows.Forms.Label lblTituloLista;
        private System.Windows.Forms.DataGridView dgvEmpresas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCredito;
    }
}