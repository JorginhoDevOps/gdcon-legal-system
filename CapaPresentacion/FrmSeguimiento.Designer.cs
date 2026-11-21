using System.Windows.Forms;

namespace CapaPresentacion
{
    partial class FrmSeguimiento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsAcciones = new System.Windows.Forms.ToolStrip();
            this.tsbImprimir = new System.Windows.Forms.ToolStripButton();
            this.tsbVistaPrevia = new System.Windows.Forms.ToolStripButton();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.pnlBuscar = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.bntBuscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbPlazo = new System.Windows.Forms.Panel();
            this.pnlPlazoRelleno = new System.Windows.Forms.Panel();
            this.lbl0h = new System.Windows.Forms.Label();
            this.lbl24h = new System.Windows.Forms.Label();
            this.lbl48h = new System.Windows.Forms.Label();
            this.lblPuntoSemaforo = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblSemaforo = new System.Windows.Forms.Label();
            this.lblHorasHabiles = new System.Windows.Forms.Label();
            this.lblModalidadT = new System.Windows.Forms.Label();
            this.lblVehiculoT = new System.Windows.Forms.Label();
            this.lblClienteT = new System.Windows.Forms.Label();
            this.lblPoderT = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblPlacaT = new System.Windows.Forms.Label();
            this.lblEstadoDetalle = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPlacaV = new System.Windows.Forms.Label();
            this.llbModalidadV = new System.Windows.Forms.Label();
            this.lblVehiculoV = new System.Windows.Forms.Label();
            this.lblClienteV = new System.Windows.Forms.Label();
            this.lblTramite = new System.Windows.Forms.Label();
            this.pnlLineaTiempo = new System.Windows.Forms.Panel();
            this.lblCirculo1 = new System.Windows.Forms.Label();
            this.lblCirculo2 = new System.Windows.Forms.Label();
            this.lblCirculo3 = new System.Windows.Forms.Label();
            this.lblCirculo4 = new System.Windows.Forms.Label();
            this.lblCirculo5 = new System.Windows.Forms.Label();
            this.pnlLinea1 = new System.Windows.Forms.Panel();
            this.pnlLinea2 = new System.Windows.Forms.Panel();
            this.pnlLinea3 = new System.Windows.Forms.Panel();
            this.pnlLinea4 = new System.Windows.Forms.Panel();
            this.lblFechaPaso5 = new System.Windows.Forms.Label();
            this.lblPaso5 = new System.Windows.Forms.Label();
            this.lblFechaPaso4 = new System.Windows.Forms.Label();
            this.lblPaso4 = new System.Windows.Forms.Label();
            this.lblFechaPaso3 = new System.Windows.Forms.Label();
            this.lblPaso3 = new System.Windows.Forms.Label();
            this.lblFechaPaso2 = new System.Windows.Forms.Label();
            this.lblPaso2 = new System.Windows.Forms.Label();
            this.lblFechaPaso1 = new System.Windows.Forms.Label();
            this.lblPaso1 = new System.Windows.Forms.Label();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.tsAcciones.SuspendLayout();
            this.pnlBuscar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlLineaTiempo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // tsAcciones
            // 
            this.tsAcciones.AutoSize = false;
            this.tsAcciones.BackColor = System.Drawing.Color.White;
            this.tsAcciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsAcciones.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsAcciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbImprimir,
            this.tsbVistaPrevia,
            this.tsbCerrar});
            this.tsAcciones.Location = new System.Drawing.Point(0, 0);
            this.tsAcciones.Name = "tsAcciones";
            this.tsAcciones.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tsAcciones.Size = new System.Drawing.Size(1060, 44);
            this.tsAcciones.TabIndex = 2;
            // 
            // tsbImprimir
            // 
            this.tsbImprimir.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.tsbImprimir.ForeColor = System.Drawing.Color.FromArgb(9, 26, 58);
            this.tsbImprimir.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tsbImprimir.Click += new System.EventHandler(this.tsbImprimir_Click);
            this.tsbImprimir.Name = "tsbImprimir";
            this.tsbImprimir.Size = new System.Drawing.Size(57, 40);
            this.tsbImprimir.Text = "Imprimir";
            this.tsbImprimir.ToolTipText = "Imprimir";
            // 
            // tsbVistaPrevia
            // 
            this.tsbVistaPrevia.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.tsbVistaPrevia.ForeColor = System.Drawing.Color.FromArgb(9, 26, 58);
            this.tsbVistaPrevia.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tsbVistaPrevia.Click += new System.EventHandler(this.tsbVistaPrevia_Click);
            this.tsbVistaPrevia.Name = "tsbVistaPrevia";
            this.tsbVistaPrevia.Size = new System.Drawing.Size(71, 40);
            this.tsbVistaPrevia.Text = "Vista Previa";
            // 
            // tsbCerrar
            // 
            this.tsbCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.tsbCerrar.ForeColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.tsbCerrar.Name = "tsbCerrar";
            this.tsbCerrar.Click += new System.EventHandler(this.tsbCerrar_Click);
            this.tsbCerrar.Size = new System.Drawing.Size(43, 41);
            this.tsbCerrar.Text = "Cerrar";
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBuscar.BackColor = System.Drawing.Color.White;
            this.pnlBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlBuscar.Controls.Add(this.lblBuscar);
            this.pnlBuscar.Controls.Add(this.txtBuscar);
            this.pnlBuscar.Controls.Add(this.bntBuscar);
            this.pnlBuscar.Location = new System.Drawing.Point(13, 56);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Padding = new System.Windows.Forms.Padding(8, 9, 8, 8);
            this.pnlBuscar.Size = new System.Drawing.Size(1035, 52);
            this.pnlBuscar.TabIndex = 3;
            this.pnlBuscar.Paint += new System.Windows.Forms.PaintEventHandler(this.PintarBorde);
            // 
            // lblBuscar
            // 
            this.lblBuscar.BackColor = System.Drawing.Color.White;
            this.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblBuscar.Location = new System.Drawing.Point(11, 9);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblBuscar.Size = new System.Drawing.Size(298, 28);
            this.lblBuscar.TabIndex = 1;
            this.lblBuscar.Text = "Buscar por chasis, placa, cliente o contrato";
            this.lblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.txtBuscar.Location = new System.Drawing.Point(315, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(398, 26);
            this.txtBuscar.TabIndex = 2;
            // 
            // bntBuscar
            // 
            this.bntBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(193)))), ((int)(((byte)(227)))));
            this.bntBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntBuscar.ForeColor = System.Drawing.Color.Black;
            this.bntBuscar.Location = new System.Drawing.Point(719, 12);
            this.bntBuscar.Name = "bntBuscar";
            this.bntBuscar.Size = new System.Drawing.Size(128, 31);
            this.bntBuscar.TabIndex = 0;
            this.bntBuscar.Text = "Buscar";
            this.bntBuscar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panel1.Controls.Add(this.lblPuntoSemaforo);
            this.panel1.Controls.Add(this.lbl48h);
            this.panel1.Controls.Add(this.lbl24h);
            this.panel1.Controls.Add(this.lbl0h);
            this.panel1.Controls.Add(this.pbPlazo);
            this.panel1.Controls.Add(this.lblHoras);
            this.panel1.Controls.Add(this.lblSemaforo);
            this.panel1.Controls.Add(this.lblHorasHabiles);
            this.panel1.Controls.Add(this.lblModalidadT);
            this.panel1.Controls.Add(this.lblVehiculoT);
            this.panel1.Controls.Add(this.lblClienteT);
            this.panel1.Controls.Add(this.lblPoderT);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.lblPlacaT);
            this.panel1.Controls.Add(this.lblEstadoDetalle);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblPlacaV);
            this.panel1.Controls.Add(this.llbModalidadV);
            this.panel1.Controls.Add(this.lblVehiculoV);
            this.panel1.Controls.Add(this.lblClienteV);
            this.panel1.Controls.Add(this.lblTramite);
            this.panel1.Location = new System.Drawing.Point(13, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 134);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.PintarBorde);
            // 
            // pbPlazo
            // 
            this.pbPlazo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPlazo.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.pbPlazo.Controls.Add(this.pnlPlazoRelleno);
            this.pbPlazo.Location = new System.Drawing.Point(745, 75);
            this.pbPlazo.Name = "pbPlazo";
            this.pbPlazo.Size = new System.Drawing.Size(272, 10);
            this.pbPlazo.TabIndex = 16;
            // 
            // pnlPlazoRelleno
            // 
            this.pnlPlazoRelleno.BackColor = System.Drawing.Color.FromArgb(249, 168, 37);
            this.pnlPlazoRelleno.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPlazoRelleno.Location = new System.Drawing.Point(0, 0);
            this.pnlPlazoRelleno.Name = "pnlPlazoRelleno";
            this.pnlPlazoRelleno.Size = new System.Drawing.Size(268, 10);
            this.pnlPlazoRelleno.TabIndex = 0;
            // 
            // lbl0h
            // 
            this.lbl0h.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl0h.AutoSize = true;
            this.lbl0h.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lbl0h.ForeColor = System.Drawing.Color.FromArgb(91, 107, 124);
            this.lbl0h.Location = new System.Drawing.Point(745, 88);
            this.lbl0h.Name = "lbl0h";
            this.lbl0h.Size = new System.Drawing.Size(24, 13);
            this.lbl0h.TabIndex = 17;
            this.lbl0h.Text = "0 h";
            // 
            // lbl24h
            // 
            this.lbl24h.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl24h.AutoSize = true;
            this.lbl24h.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lbl24h.ForeColor = System.Drawing.Color.FromArgb(91, 107, 124);
            this.lbl24h.Location = new System.Drawing.Point(870, 88);
            this.lbl24h.Name = "lbl24h";
            this.lbl24h.Size = new System.Drawing.Size(24, 13);
            this.lbl24h.TabIndex = 17;
            this.lbl24h.Text = "24 h";
            // 
            // lbl48h
            // 
            this.lbl48h.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl48h.AutoSize = true;
            this.lbl48h.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lbl48h.ForeColor = System.Drawing.Color.FromArgb(91, 107, 124);
            this.lbl48h.Location = new System.Drawing.Point(990, 88);
            this.lbl48h.Name = "lbl48h";
            this.lbl48h.Size = new System.Drawing.Size(24, 13);
            this.lbl48h.TabIndex = 17;
            this.lbl48h.Text = "48 h";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(168)))), ((int)(((byte)(37)))));
            this.lblHoras.Location = new System.Drawing.Point(745, 31);
            this.lblHoras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(135, 30);
            this.lblHoras.TabIndex = 15;
            this.lblHoras.Text = "47 h 20 min";
            // 
            // lblSemaforo
            // 
            this.lblSemaforo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSemaforo.AutoSize = true;
            this.lblSemaforo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSemaforo.ForeColor = System.Drawing.Color.FromArgb(9, 26, 58);
            this.lblSemaforo.Location = new System.Drawing.Point(762, 108);
            this.lblSemaforo.Name = "lblSemaforo";
            this.lblSemaforo.Size = new System.Drawing.Size(232, 15);
            this.lblSemaforo.TabIndex = 14;
            this.lblSemaforo.Text = "Por vencer — vence 12/11/2026 15:00";
            // 
            // lblPuntoSemaforo
            // 
            this.lblPuntoSemaforo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPuntoSemaforo.AutoSize = true;
            this.lblPuntoSemaforo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPuntoSemaforo.ForeColor = System.Drawing.Color.FromArgb(249, 168, 37);
            this.lblPuntoSemaforo.Location = new System.Drawing.Point(743, 106);
            this.lblPuntoSemaforo.Name = "lblPuntoSemaforo";
            this.lblPuntoSemaforo.Size = new System.Drawing.Size(17, 19);
            this.lblPuntoSemaforo.TabIndex = 18;
            this.lblPuntoSemaforo.Text = "●";
            // 
            // lblHorasHabiles
            // 
            this.lblHorasHabiles.AutoSize = true;
            this.lblHorasHabiles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasHabiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblHorasHabiles.Location = new System.Drawing.Point(745, 9);
            this.lblHorasHabiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHorasHabiles.Name = "lblHorasHabiles";
            this.lblHorasHabiles.Size = new System.Drawing.Size(149, 15);
            this.lblHorasHabiles.TabIndex = 13;
            this.lblHorasHabiles.Text = "Horas hábiles transcurridas";
            // 
            // lblModalidadT
            // 
            this.lblModalidadT.AutoSize = true;
            this.lblModalidadT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModalidadT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblModalidadT.Location = new System.Drawing.Point(447, 36);
            this.lblModalidadT.Name = "lblModalidadT";
            this.lblModalidadT.Size = new System.Drawing.Size(64, 15);
            this.lblModalidadT.TabIndex = 12;
            this.lblModalidadT.Text = "Modalidad";
            // 
            // lblVehiculoT
            // 
            this.lblVehiculoT.AutoSize = true;
            this.lblVehiculoT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculoT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblVehiculoT.Location = new System.Drawing.Point(251, 36);
            this.lblVehiculoT.Name = "lblVehiculoT";
            this.lblVehiculoT.Size = new System.Drawing.Size(52, 15);
            this.lblVehiculoT.TabIndex = 11;
            this.lblVehiculoT.Text = "Vehículo";
            // 
            // lblClienteT
            // 
            this.lblClienteT.AutoSize = true;
            this.lblClienteT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblClienteT.Location = new System.Drawing.Point(5, 36);
            this.lblClienteT.Name = "lblClienteT";
            this.lblClienteT.Size = new System.Drawing.Size(44, 15);
            this.lblClienteT.TabIndex = 10;
            this.lblClienteT.Text = "Cliente";
            // 
            // lblPoderT
            // 
            this.lblPoderT.AutoSize = true;
            this.lblPoderT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoderT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblPoderT.Location = new System.Drawing.Point(447, 85);
            this.lblPoderT.Name = "lblPoderT";
            this.lblPoderT.Size = new System.Drawing.Size(70, 15);
            this.lblPoderT.TabIndex = 9;
            this.lblPoderT.Text = "En poder de";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblEstado.Location = new System.Drawing.Point(251, 85);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(42, 15);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado";
            // 
            // lblPlacaT
            // 
            this.lblPlacaT.AutoSize = true;
            this.lblPlacaT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacaT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblPlacaT.Location = new System.Drawing.Point(6, 85);
            this.lblPlacaT.Name = "lblPlacaT";
            this.lblPlacaT.Size = new System.Drawing.Size(35, 15);
            this.lblPlacaT.TabIndex = 7;
            this.lblPlacaT.Text = "Placa";
            // 
            // lblEstadoDetalle
            // 
            this.lblEstadoDetalle.AutoSize = true;
            this.lblEstadoDetalle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblEstadoDetalle.Location = new System.Drawing.Point(447, 105);
            this.lblEstadoDetalle.Name = "lblEstadoDetalle";
            this.lblEstadoDetalle.Size = new System.Drawing.Size(204, 15);
            this.lblEstadoDetalle.TabIndex = 6;
            this.lblEstadoDetalle.Text = "Tránsito (espera resolución y placas)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(191)))));
            this.label6.CausesValidation = false;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(251, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "EN TRANSITO";
            // 
            // lblPlacaV
            // 
            this.lblPlacaV.AutoSize = true;
            this.lblPlacaV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacaV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblPlacaV.Location = new System.Drawing.Point(5, 105);
            this.lblPlacaV.Name = "lblPlacaV";
            this.lblPlacaV.Size = new System.Drawing.Size(49, 15);
            this.lblPlacaV.TabIndex = 4;
            this.lblPlacaV.Text = "650ERT";
            // 
            // llbModalidadV
            // 
            this.llbModalidadV.AutoSize = true;
            this.llbModalidadV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbModalidadV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.llbModalidadV.Location = new System.Drawing.Point(447, 56);
            this.llbModalidadV.Name = "llbModalidadV";
            this.llbModalidadV.Size = new System.Drawing.Size(57, 15);
            this.llbModalidadV.TabIndex = 3;
            this.llbModalidadV.Text = "CREDITO";
            // 
            // lblVehiculoV
            // 
            this.lblVehiculoV.AutoSize = true;
            this.lblVehiculoV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculoV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblVehiculoV.Location = new System.Drawing.Point(251, 56);
            this.lblVehiculoV.Name = "lblVehiculoV";
            this.lblVehiculoV.Size = new System.Drawing.Size(131, 15);
            this.lblVehiculoV.TabIndex = 2;
            this.lblVehiculoV.Text = "CHANGAN VAGONETA";
            // 
            // lblClienteV
            // 
            this.lblClienteV.AutoSize = true;
            this.lblClienteV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblClienteV.Location = new System.Drawing.Point(5, 56);
            this.lblClienteV.Name = "lblClienteV";
            this.lblClienteV.Size = new System.Drawing.Size(172, 15);
            this.lblClienteV.TabIndex = 1;
            this.lblClienteV.Text = "TRANSPORTES ORIENTE S.R.L";
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblTramite.Location = new System.Drawing.Point(5, 9);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(222, 15);
            this.lblTramite.TabIndex = 0;
            this.lblTramite.Text = "Trámite 302900102 . LS5AFE1F564C8D";
            // 
            // pnlLineaTiempo
            // 
            this.pnlLineaTiempo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLineaTiempo.BackColor = System.Drawing.Color.White;
            this.pnlLineaTiempo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlLineaTiempo.Controls.Add(this.lblCirculo1);
            this.pnlLineaTiempo.Controls.Add(this.lblPaso1);
            this.pnlLineaTiempo.Controls.Add(this.lblFechaPaso1);
            this.pnlLineaTiempo.Controls.Add(this.lblCirculo2);
            this.pnlLineaTiempo.Controls.Add(this.lblPaso2);
            this.pnlLineaTiempo.Controls.Add(this.lblFechaPaso2);
            this.pnlLineaTiempo.Controls.Add(this.lblCirculo3);
            this.pnlLineaTiempo.Controls.Add(this.lblPaso3);
            this.pnlLineaTiempo.Controls.Add(this.lblFechaPaso3);
            this.pnlLineaTiempo.Controls.Add(this.lblCirculo4);
            this.pnlLineaTiempo.Controls.Add(this.lblPaso4);
            this.pnlLineaTiempo.Controls.Add(this.lblFechaPaso4);
            this.pnlLineaTiempo.Controls.Add(this.lblCirculo5);
            this.pnlLineaTiempo.Controls.Add(this.lblPaso5);
            this.pnlLineaTiempo.Controls.Add(this.lblFechaPaso5);
            this.pnlLineaTiempo.Controls.Add(this.pnlLinea1);
            this.pnlLineaTiempo.Controls.Add(this.pnlLinea2);
            this.pnlLineaTiempo.Controls.Add(this.pnlLinea3);
            this.pnlLineaTiempo.Controls.Add(this.pnlLinea4);
            this.pnlLineaTiempo.Location = new System.Drawing.Point(13, 266);
            this.pnlLineaTiempo.Name = "pnlLineaTiempo";
            this.pnlLineaTiempo.Size = new System.Drawing.Size(1035, 120);
            this.pnlLineaTiempo.TabIndex = 1;
            this.pnlLineaTiempo.Paint += new System.Windows.Forms.PaintEventHandler(this.PintarBorde);
            // 
            // lblCirculo1
            // 
            this.lblCirculo1.AutoSize = false;
            this.lblCirculo1.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.lblCirculo1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCirculo1.ForeColor = System.Drawing.Color.White;
            this.lblCirculo1.Location = new System.Drawing.Point(88, 16);
            this.lblCirculo1.Name = "lblCirculo1";
            this.lblCirculo1.Size = new System.Drawing.Size(30, 30);
            this.lblCirculo1.TabIndex = 0;
            this.lblCirculo1.Text = "✓";
            this.lblCirculo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPaso1
            // 
            this.lblPaso1.AutoSize = false;
            this.lblPaso1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPaso1.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.lblPaso1.Location = new System.Drawing.Point(10, 54);
            this.lblPaso1.Name = "lblPaso1";
            this.lblPaso1.Size = new System.Drawing.Size(187, 20);
            this.lblPaso1.TabIndex = 1;
            this.lblPaso1.Text = "Recepción";
            this.lblPaso1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFechaPaso1
            // 
            this.lblFechaPaso1.AutoSize = false;
            this.lblFechaPaso1.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFechaPaso1.ForeColor = System.Drawing.Color.FromArgb(91, 107, 124);
            this.lblFechaPaso1.Location = new System.Drawing.Point(10, 76);
            this.lblFechaPaso1.Name = "lblFechaPaso1";
            this.lblFechaPaso1.Size = new System.Drawing.Size(187, 18);
            this.lblFechaPaso1.TabIndex = 2;
            this.lblFechaPaso1.Text = "10/11/2026 15:00";
            this.lblFechaPaso1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCirculo2
            // 
            this.lblCirculo2.AutoSize = false;
            this.lblCirculo2.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.lblCirculo2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCirculo2.ForeColor = System.Drawing.Color.White;
            this.lblCirculo2.Location = new System.Drawing.Point(295, 16);
            this.lblCirculo2.Name = "lblCirculo2";
            this.lblCirculo2.Size = new System.Drawing.Size(30, 30);
            this.lblCirculo2.TabIndex = 3;
            this.lblCirculo2.Text = "✓";
            this.lblCirculo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPaso2
            // 
            this.lblPaso2.AutoSize = false;
            this.lblPaso2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPaso2.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.lblPaso2.Location = new System.Drawing.Point(217, 54);
            this.lblPaso2.Name = "lblPaso2";
            this.lblPaso2.Size = new System.Drawing.Size(187, 20);
            this.lblPaso2.TabIndex = 4;
            this.lblPaso2.Text = "Despacho";
            this.lblPaso2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFechaPaso2
            // 
            this.lblFechaPaso2.AutoSize = false;
            this.lblFechaPaso2.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFechaPaso2.ForeColor = System.Drawing.Color.FromArgb(91, 107, 124);
            this.lblFechaPaso2.Location = new System.Drawing.Point(217, 76);
            this.lblFechaPaso2.Name = "lblFechaPaso2";
            this.lblFechaPaso2.Size = new System.Drawing.Size(187, 18);
            this.lblFechaPaso2.TabIndex = 5;
            this.lblFechaPaso2.Text = "11/11/2026 08:30";
            this.lblFechaPaso2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCirculo3
            // 
            this.lblCirculo3.AutoSize = false;
            this.lblCirculo3.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.lblCirculo3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCirculo3.ForeColor = System.Drawing.Color.White;
            this.lblCirculo3.Location = new System.Drawing.Point(502, 16);
            this.lblCirculo3.Name = "lblCirculo3";
            this.lblCirculo3.Size = new System.Drawing.Size(30, 30);
            this.lblCirculo3.TabIndex = 6;
            this.lblCirculo3.Text = "✓";
            this.lblCirculo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPaso3
            // 
            this.lblPaso3.AutoSize = false;
            this.lblPaso3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPaso3.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.lblPaso3.Location = new System.Drawing.Point(424, 54);
            this.lblPaso3.Name = "lblPaso3";
            this.lblPaso3.Size = new System.Drawing.Size(187, 20);
            this.lblPaso3.TabIndex = 7;
            this.lblPaso3.Text = "Placas y Pagos";
            this.lblPaso3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFechaPaso3
            // 
            this.lblFechaPaso3.AutoSize = false;
            this.lblFechaPaso3.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFechaPaso3.ForeColor = System.Drawing.Color.FromArgb(91, 107, 124);
            this.lblFechaPaso3.Location = new System.Drawing.Point(424, 76);
            this.lblFechaPaso3.Name = "lblFechaPaso3";
            this.lblFechaPaso3.Size = new System.Drawing.Size(187, 18);
            this.lblFechaPaso3.TabIndex = 8;
            this.lblFechaPaso3.Text = "11/11/2026 13:10";
            this.lblFechaPaso3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCirculo4
            // 
            this.lblCirculo4.AutoSize = false;
            this.lblCirculo4.BackColor = System.Drawing.Color.FromArgb(0, 145, 185);
            this.lblCirculo4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCirculo4.ForeColor = System.Drawing.Color.White;
            this.lblCirculo4.Location = new System.Drawing.Point(709, 16);
            this.lblCirculo4.Name = "lblCirculo4";
            this.lblCirculo4.Size = new System.Drawing.Size(30, 30);
            this.lblCirculo4.TabIndex = 9;
            this.lblCirculo4.Text = "4";
            this.lblCirculo4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPaso4
            // 
            this.lblPaso4.AutoSize = false;
            this.lblPaso4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPaso4.ForeColor = System.Drawing.Color.FromArgb(0, 145, 185);
            this.lblPaso4.Location = new System.Drawing.Point(631, 54);
            this.lblPaso4.Name = "lblPaso4";
            this.lblPaso4.Size = new System.Drawing.Size(187, 20);
            this.lblPaso4.TabIndex = 10;
            this.lblPaso4.Text = "Tránsito";
            this.lblPaso4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFechaPaso4
            // 
            this.lblFechaPaso4.AutoSize = false;
            this.lblFechaPaso4.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFechaPaso4.ForeColor = System.Drawing.Color.FromArgb(91, 107, 124);
            this.lblFechaPaso4.Location = new System.Drawing.Point(631, 76);
            this.lblFechaPaso4.Name = "lblFechaPaso4";
            this.lblFechaPaso4.Size = new System.Drawing.Size(187, 18);
            this.lblFechaPaso4.TabIndex = 11;
            this.lblFechaPaso4.Text = "11/11/2026 16:40";
            this.lblFechaPaso4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCirculo5
            // 
            this.lblCirculo5.AutoSize = false;
            this.lblCirculo5.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.lblCirculo5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCirculo5.ForeColor = System.Drawing.Color.FromArgb(91, 107, 124);
            this.lblCirculo5.Location = new System.Drawing.Point(916, 16);
            this.lblCirculo5.Name = "lblCirculo5";
            this.lblCirculo5.Size = new System.Drawing.Size(30, 30);
            this.lblCirculo5.TabIndex = 12;
            this.lblCirculo5.Text = "5";
            this.lblCirculo5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPaso5
            // 
            this.lblPaso5.AutoSize = false;
            this.lblPaso5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPaso5.ForeColor = System.Drawing.Color.FromArgb(91, 107, 124);
            this.lblPaso5.Location = new System.Drawing.Point(838, 54);
            this.lblPaso5.Name = "lblPaso5";
            this.lblPaso5.Size = new System.Drawing.Size(187, 20);
            this.lblPaso5.TabIndex = 13;
            this.lblPaso5.Text = "Entrega";
            this.lblPaso5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFechaPaso5
            // 
            this.lblFechaPaso5.AutoSize = false;
            this.lblFechaPaso5.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFechaPaso5.ForeColor = System.Drawing.Color.FromArgb(91, 107, 124);
            this.lblFechaPaso5.Location = new System.Drawing.Point(838, 76);
            this.lblFechaPaso5.Name = "lblFechaPaso5";
            this.lblFechaPaso5.Size = new System.Drawing.Size(187, 18);
            this.lblFechaPaso5.TabIndex = 14;
            this.lblFechaPaso5.Text = "Pendiente";
            this.lblFechaPaso5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLinea1
            // 
            this.pnlLinea1.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.pnlLinea1.Location = new System.Drawing.Point(126, 30);
            this.pnlLinea1.Name = "pnlLinea1";
            this.pnlLinea1.Size = new System.Drawing.Size(161, 2);
            this.pnlLinea1.TabIndex = 15;
            // 
            // pnlLinea2
            // 
            this.pnlLinea2.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.pnlLinea2.Location = new System.Drawing.Point(333, 30);
            this.pnlLinea2.Name = "pnlLinea2";
            this.pnlLinea2.Size = new System.Drawing.Size(161, 2);
            this.pnlLinea2.TabIndex = 16;
            // 
            // pnlLinea3
            // 
            this.pnlLinea3.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.pnlLinea3.Location = new System.Drawing.Point(540, 30);
            this.pnlLinea3.Name = "pnlLinea3";
            this.pnlLinea3.Size = new System.Drawing.Size(161, 2);
            this.pnlLinea3.TabIndex = 17;
            // 
            // pnlLinea4
            // 
            this.pnlLinea4.BackColor = System.Drawing.Color.FromArgb(213, 221, 230);
            this.pnlLinea4.Location = new System.Drawing.Point(747, 30);
            this.pnlLinea4.Name = "pnlLinea4";
            this.pnlLinea4.Size = new System.Drawing.Size(161, 2);
            this.pnlLinea4.TabIndex = 18;
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.dgvHistorial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorial.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(230, 236, 245);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(9, 26, 58);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFecha,
            this.colEvento,
            this.colModulo});
            this.dgvHistorial.EnableHeadersVisualStyles = false;
            this.dgvHistorial.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.dgvHistorial.Location = new System.Drawing.Point(13, 427);
            this.dgvHistorial.MultiSelect = false;
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.RowHeadersVisible = false;
            this.dgvHistorial.RowHeadersWidth = 51;
            this.dgvHistorial.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.dgvHistorial.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.dgvHistorial.RowTemplate.Height = 28;
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorial.Size = new System.Drawing.Size(1034, 322);
            this.dgvHistorial.TabIndex = 4;
            // 
            // colFecha
            // 
            this.colFecha.FillWeight = 22F;
            this.colFecha.HeaderText = "Fecha y hora";
            this.colFecha.MinimumWidth = 6;
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colEvento
            // 
            this.colEvento.FillWeight = 56F;
            this.colEvento.HeaderText = "Evento";
            this.colEvento.MinimumWidth = 6;
            this.colEvento.Name = "colEvento";
            this.colEvento.ReadOnly = true;
            // 
            // colModulo
            // 
            this.colModulo.FillWeight = 22F;
            this.colModulo.HeaderText = "Módulo";
            this.colModulo.MinimumWidth = 6;
            this.colModulo.Name = "colModulo";
            this.colModulo.ReadOnly = true;
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblEncabezado.CausesValidation = false;
            this.lblEncabezado.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.ForeColor = System.Drawing.Color.White;
            this.lblEncabezado.Location = new System.Drawing.Point(13, 397);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblEncabezado.Size = new System.Drawing.Size(1034, 30);
            this.lblEncabezado.TabIndex = 5;
            this.lblEncabezado.Text = "Historial de movimientos";
            this.lblEncabezado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmSeguimiento
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1060, 760);
            this.Controls.Add(this.lblEncabezado);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.pnlLineaTiempo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBuscar);
            this.Controls.Add(this.tsAcciones);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmSeguimiento";
            this.Text = "FrmSeguimiento";
            this.tsAcciones.ResumeLayout(false);
            this.tsAcciones.PerformLayout();
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlLineaTiempo.ResumeLayout(false);
            this.pnlLineaTiempo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsAcciones;
        private System.Windows.Forms.ToolStripButton tsbImprimir;
        private System.Windows.Forms.ToolStripButton tsbVistaPrevia;
        private System.Windows.Forms.ToolStripButton tsbCerrar;
        private System.Windows.Forms.FlowLayoutPanel pnlBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlLineaTiempo;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.Button bntBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblPlacaT;
        private System.Windows.Forms.Label lblEstadoDetalle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPlacaV;
        private System.Windows.Forms.Label llbModalidadV;
        private System.Windows.Forms.Label lblVehiculoV;
        private System.Windows.Forms.Label lblClienteV;
        private System.Windows.Forms.Label lblSemaforo;
        private System.Windows.Forms.Label lblHorasHabiles;
        private System.Windows.Forms.Label lblModalidadT;
        private System.Windows.Forms.Label lblVehiculoT;
        private System.Windows.Forms.Label lblClienteT;
        private System.Windows.Forms.Label lblPoderT;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Panel pbPlazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModulo;
        private System.Windows.Forms.Label lblPaso1;
        private System.Windows.Forms.Label lblFechaPaso1;
        private System.Windows.Forms.Label lblFechaPaso5;
        private System.Windows.Forms.Label lblPaso5;
        private System.Windows.Forms.Label lblFechaPaso4;
        private System.Windows.Forms.Label lblPaso4;
        private System.Windows.Forms.Label lblFechaPaso3;
        private System.Windows.Forms.Label lblPaso3;
        private System.Windows.Forms.Label lblFechaPaso2;
        private System.Windows.Forms.Label lblPaso2;
        private System.Windows.Forms.Label lblCirculo1;
        private System.Windows.Forms.Label lblCirculo2;
        private System.Windows.Forms.Label lblCirculo3;
        private System.Windows.Forms.Label lblCirculo4;
        private System.Windows.Forms.Label lblCirculo5;
        private System.Windows.Forms.Panel pnlLinea1;
        private System.Windows.Forms.Panel pnlLinea2;
        private System.Windows.Forms.Panel pnlLinea3;
        private System.Windows.Forms.Panel pnlLinea4;
        private System.Windows.Forms.Panel pnlPlazoRelleno;
        private System.Windows.Forms.Label lbl0h;
        private System.Windows.Forms.Label lbl24h;
        private System.Windows.Forms.Label lbl48h;
        private System.Windows.Forms.Label lblPuntoSemaforo;
    }
}