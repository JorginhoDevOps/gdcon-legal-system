namespace CapaPresentacion
{
    partial class FrmPlacasPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlacasPagos));
            this.tsAcciones = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbLimpiar = new System.Windows.Forms.ToolStripButton();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.txtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.pnlPasos = new System.Windows.Forms.Panel();
            this.pnlBordePasos = new System.Windows.Forms.Panel();
            this.tsAcciones.SuspendLayout();
            this.pnlPasos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsAcciones
            // 
            this.tsAcciones.AutoSize = false;
            this.tsAcciones.BackColor = System.Drawing.Color.White;
            this.tsAcciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsAcciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbGuardar,
            this.tsbModificar,
            this.tsbEliminar,
            this.tsbLimpiar,
            this.tsbCerrar,
            this.tsbBuscar,
            this.txtBuscar});
            this.tsAcciones.Location = new System.Drawing.Point(0, 0);
            this.tsAcciones.Name = "tsAcciones";
            this.tsAcciones.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tsAcciones.Size = new System.Drawing.Size(1060, 44);
            this.tsAcciones.TabIndex = 0;
            this.tsAcciones.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(73, 40);
            this.tsbNuevo.Text = "+ Nuevo";
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(69, 40);
            this.tsbGuardar.Text = "Guardar";
            // 
            // tsbModificar
            // 
            this.tsbModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsbModificar.Image")));
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(78, 40);
            this.tsbModificar.Text = "Modificar";
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(70, 40);
            this.tsbEliminar.Text = "Eliminar";
            // 
            // tsbLimpiar
            // 
            this.tsbLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("tsbLimpiar.Image")));
            this.tsbLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLimpiar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tsbLimpiar.Name = "tsbLimpiar";
            this.tsbLimpiar.Size = new System.Drawing.Size(67, 40);
            this.tsbLimpiar.Text = "Limpiar";
            // 
            // tsbCerrar
            // 
            this.tsbCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCerrar.Image")));
            this.tsbCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrar.Margin = new System.Windows.Forms.Padding(8, 2, 4, 2);
            this.tsbCerrar.Name = "tsbCerrar";
            this.tsbCerrar.Size = new System.Drawing.Size(59, 40);
            this.tsbCerrar.Text = "Cerrar";
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscar.Image")));
            this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(62, 40);
            this.tsbBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtBuscar.AutoSize = false;
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(220, 23);
            // 
            // pnlPasos
            // 
            this.pnlPasos.BackColor = System.Drawing.Color.White;
            this.pnlPasos.Controls.Add(this.pnlBordePasos);
            this.pnlPasos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPasos.Location = new System.Drawing.Point(0, 44);
            this.pnlPasos.Name = "pnlPasos";
            this.pnlPasos.Size = new System.Drawing.Size(1060, 44);
            this.pnlPasos.TabIndex = 1;
            // 
            // pnlBordePasos
            // 
            this.pnlBordePasos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(221)))), ((int)(((byte)(230)))));
            this.pnlBordePasos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBordePasos.Location = new System.Drawing.Point(0, 36);
            this.pnlBordePasos.Name = "pnlBordePasos";
            this.pnlBordePasos.Size = new System.Drawing.Size(1060, 8);
            this.pnlBordePasos.TabIndex = 0;
            // 
            // FrmPlacasPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1060, 760);
            this.Controls.Add(this.pnlPasos);
            this.Controls.Add(this.tsAcciones);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(900, 650);
            this.Name = "FrmPlacasPagos";
            this.Text = "Placas y Pagos";
            this.tsAcciones.ResumeLayout(false);
            this.tsAcciones.PerformLayout();
            this.pnlPasos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsAcciones;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStripButton tsbLimpiar;
        private System.Windows.Forms.ToolStripButton tsbCerrar;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.ToolStripTextBox txtBuscar;
        private System.Windows.Forms.Panel pnlPasos;
        private System.Windows.Forms.Panel pnlBordePasos;
    }
}