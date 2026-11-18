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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeguimiento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsAcciones = new System.Windows.Forms.ToolStrip();
            this.tsbImprimir = new System.Windows.Forms.ToolStripButton();
            this.tsbVistaPrevia = new System.Windows.Forms.ToolStripButton();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.pnlBuscar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlLineaTiempo = new System.Windows.Forms.Panel();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.bntBuscar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblClienteV = new System.Windows.Forms.Label();
            this.lblVehiculoV = new System.Windows.Forms.Label();
            this.llbModalidadV = new System.Windows.Forms.Label();
            this.lblPlacaV = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEstadoDetalle = new System.Windows.Forms.Label();
            this.lblPlacaT = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblPoderT = new System.Windows.Forms.Label();
            this.lblClienteT = new System.Windows.Forms.Label();
            this.lblVehiculoT = new System.Windows.Forms.Label();
            this.lblModalidadT = new System.Windows.Forms.Label();
            this.lblHorasHabiles = new System.Windows.Forms.Label();
            this.lblSemaforo = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.pbPlazo = new System.Windows.Forms.ProgressBar();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPaso1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFechaPaso1 = new System.Windows.Forms.Label();
            this.lblFechaPaso2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPaso2 = new System.Windows.Forms.Label();
            this.lblFechaPaso4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPaso4 = new System.Windows.Forms.Label();
            this.lblFechaPaso3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPaso3 = new System.Windows.Forms.Label();
            this.lblFechaPaso5 = new System.Windows.Forms.Label();
            this.lblPaso5 = new System.Windows.Forms.Label();
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
            this.tsbImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tsbImprimir.Image")));
            this.tsbImprimir.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tsbImprimir.Name = "tsbImprimir";
            this.tsbImprimir.Size = new System.Drawing.Size(94, 40);
            this.tsbImprimir.Text = "Imprimir";
            this.tsbImprimir.ToolTipText = "Nuevo";
            // 
            // tsbVistaPrevia
            // 
            this.tsbVistaPrevia.Image = ((System.Drawing.Image)(resources.GetObject("tsbVistaPrevia.Image")));
            this.tsbVistaPrevia.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tsbVistaPrevia.Name = "tsbVistaPrevia";
            this.tsbVistaPrevia.Size = new System.Drawing.Size(113, 40);
            this.tsbVistaPrevia.Text = "Vista Previa";
            // 
            // tsbCerrar
            // 
            this.tsbCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCerrar.Image")));
            this.tsbCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrar.Name = "tsbCerrar";
            this.tsbCerrar.Size = new System.Drawing.Size(77, 41);
            this.tsbCerrar.Text = "Cerrar";
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.BackColor = System.Drawing.Color.White;
            this.pnlBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBuscar.Controls.Add(this.lblBuscar);
            this.pnlBuscar.Controls.Add(this.txtBuscar);
            this.pnlBuscar.Controls.Add(this.bntBuscar);
            this.pnlBuscar.Location = new System.Drawing.Point(13, 56);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Padding = new System.Windows.Forms.Padding(8, 9, 8, 8);
            this.pnlBuscar.Size = new System.Drawing.Size(1035, 52);
            this.pnlBuscar.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            // 
            // pnlLineaTiempo
            // 
            this.pnlLineaTiempo.BackColor = System.Drawing.Color.White;
            this.pnlLineaTiempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLineaTiempo.Controls.Add(this.lblFechaPaso5);
            this.pnlLineaTiempo.Controls.Add(this.lblPaso5);
            this.pnlLineaTiempo.Controls.Add(this.lblFechaPaso4);
            this.pnlLineaTiempo.Controls.Add(this.label8);
            this.pnlLineaTiempo.Controls.Add(this.lblPaso4);
            this.pnlLineaTiempo.Controls.Add(this.lblFechaPaso3);
            this.pnlLineaTiempo.Controls.Add(this.label11);
            this.pnlLineaTiempo.Controls.Add(this.lblPaso3);
            this.pnlLineaTiempo.Controls.Add(this.lblFechaPaso2);
            this.pnlLineaTiempo.Controls.Add(this.label4);
            this.pnlLineaTiempo.Controls.Add(this.lblPaso2);
            this.pnlLineaTiempo.Controls.Add(this.lblFechaPaso1);
            this.pnlLineaTiempo.Controls.Add(this.label1);
            this.pnlLineaTiempo.Controls.Add(this.lblPaso1);
            this.pnlLineaTiempo.Location = new System.Drawing.Point(12, 266);
            this.pnlLineaTiempo.Name = "pnlLineaTiempo";
            this.pnlLineaTiempo.Size = new System.Drawing.Size(1036, 120);
            this.pnlLineaTiempo.TabIndex = 1;
            this.pnlLineaTiempo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLineaTiempo_Paint);
            // 
            // dgvHistorial
            // 
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
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
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
            // lblBuscar
            // 
            this.lblBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.txtBuscar.Size = new System.Drawing.Size(398, 30);
            this.txtBuscar.TabIndex = 2;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblTramite.Location = new System.Drawing.Point(5, 9);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(285, 20);
            this.lblTramite.TabIndex = 0;
            this.lblTramite.Text = "Trámite 302900102 . LS5AFE1F564C8D";
            // 
            // lblClienteV
            // 
            this.lblClienteV.AutoSize = true;
            this.lblClienteV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblClienteV.Location = new System.Drawing.Point(5, 56);
            this.lblClienteV.Name = "lblClienteV";
            this.lblClienteV.Size = new System.Drawing.Size(219, 20);
            this.lblClienteV.TabIndex = 1;
            this.lblClienteV.Text = "TRANSPORTES ORIENTE S.R.L";
            // 
            // lblVehiculoV
            // 
            this.lblVehiculoV.AutoSize = true;
            this.lblVehiculoV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculoV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblVehiculoV.Location = new System.Drawing.Point(251, 56);
            this.lblVehiculoV.Name = "lblVehiculoV";
            this.lblVehiculoV.Size = new System.Drawing.Size(171, 20);
            this.lblVehiculoV.TabIndex = 2;
            this.lblVehiculoV.Text = "CHANGAN VAGONETA";
            // 
            // llbModalidadV
            // 
            this.llbModalidadV.AutoSize = true;
            this.llbModalidadV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbModalidadV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.llbModalidadV.Location = new System.Drawing.Point(447, 56);
            this.llbModalidadV.Name = "llbModalidadV";
            this.llbModalidadV.Size = new System.Drawing.Size(71, 20);
            this.llbModalidadV.TabIndex = 3;
            this.llbModalidadV.Text = "CREDITO";
            // 
            // lblPlacaV
            // 
            this.lblPlacaV.AutoSize = true;
            this.lblPlacaV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacaV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblPlacaV.Location = new System.Drawing.Point(5, 105);
            this.lblPlacaV.Name = "lblPlacaV";
            this.lblPlacaV.Size = new System.Drawing.Size(63, 20);
            this.lblPlacaV.TabIndex = 4;
            this.lblPlacaV.Text = "650ERT";
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
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "EN TRANSITO";
            // 
            // lblEstadoDetalle
            // 
            this.lblEstadoDetalle.AutoSize = true;
            this.lblEstadoDetalle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblEstadoDetalle.Location = new System.Drawing.Point(447, 105);
            this.lblEstadoDetalle.Name = "lblEstadoDetalle";
            this.lblEstadoDetalle.Size = new System.Drawing.Size(263, 20);
            this.lblEstadoDetalle.TabIndex = 6;
            this.lblEstadoDetalle.Text = "Tránsito (espera resolución y placas)";
            // 
            // lblPlacaT
            // 
            this.lblPlacaT.AutoSize = true;
            this.lblPlacaT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacaT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblPlacaT.Location = new System.Drawing.Point(6, 85);
            this.lblPlacaT.Name = "lblPlacaT";
            this.lblPlacaT.Size = new System.Drawing.Size(44, 20);
            this.lblPlacaT.TabIndex = 7;
            this.lblPlacaT.Text = "Placa";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblEstado.Location = new System.Drawing.Point(251, 85);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(54, 20);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado";
            // 
            // lblPoderT
            // 
            this.lblPoderT.AutoSize = true;
            this.lblPoderT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoderT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblPoderT.Location = new System.Drawing.Point(447, 85);
            this.lblPoderT.Name = "lblPoderT";
            this.lblPoderT.Size = new System.Drawing.Size(90, 20);
            this.lblPoderT.TabIndex = 9;
            this.lblPoderT.Text = "En poder de";
            // 
            // lblClienteT
            // 
            this.lblClienteT.AutoSize = true;
            this.lblClienteT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblClienteT.Location = new System.Drawing.Point(5, 36);
            this.lblClienteT.Name = "lblClienteT";
            this.lblClienteT.Size = new System.Drawing.Size(55, 20);
            this.lblClienteT.TabIndex = 10;
            this.lblClienteT.Text = "Cliente";
            // 
            // lblVehiculoT
            // 
            this.lblVehiculoT.AutoSize = true;
            this.lblVehiculoT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculoT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblVehiculoT.Location = new System.Drawing.Point(251, 36);
            this.lblVehiculoT.Name = "lblVehiculoT";
            this.lblVehiculoT.Size = new System.Drawing.Size(65, 20);
            this.lblVehiculoT.TabIndex = 11;
            this.lblVehiculoT.Text = "Vehículo";
            // 
            // lblModalidadT
            // 
            this.lblModalidadT.AutoSize = true;
            this.lblModalidadT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModalidadT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblModalidadT.Location = new System.Drawing.Point(447, 36);
            this.lblModalidadT.Name = "lblModalidadT";
            this.lblModalidadT.Size = new System.Drawing.Size(82, 20);
            this.lblModalidadT.TabIndex = 12;
            this.lblModalidadT.Text = "Modalidad";
            // 
            // lblHorasHabiles
            // 
            this.lblHorasHabiles.AutoSize = true;
            this.lblHorasHabiles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasHabiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblHorasHabiles.Location = new System.Drawing.Point(745, 9);
            this.lblHorasHabiles.Name = "lblHorasHabiles";
            this.lblHorasHabiles.Size = new System.Drawing.Size(187, 20);
            this.lblHorasHabiles.TabIndex = 13;
            this.lblHorasHabiles.Text = "Horas hábiles transcurridas";
            // 
            // lblSemaforo
            // 
            this.lblSemaforo.AutoSize = true;
            this.lblSemaforo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemaforo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblSemaforo.Location = new System.Drawing.Point(737, 95);
            this.lblSemaforo.Name = "lblSemaforo";
            this.lblSemaforo.Size = new System.Drawing.Size(292, 20);
            this.lblSemaforo.TabIndex = 14;
            this.lblSemaforo.Text = "Por vencer ─── vence 12/11/2026 15:00";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(168)))), ((int)(((byte)(37)))));
            this.lblHoras.Location = new System.Drawing.Point(745, 31);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(167, 37);
            this.lblHoras.TabIndex = 15;
            this.lblHoras.Text = "47 h 20 min";
            // 
            // pbPlazo
            // 
            this.pbPlazo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(168)))), ((int)(((byte)(37)))));
            this.pbPlazo.Location = new System.Drawing.Point(745, 75);
            this.pbPlazo.Maximum = 48;
            this.pbPlazo.Name = "pbPlazo";
            this.pbPlazo.Size = new System.Drawing.Size(272, 10);
            this.pbPlazo.Step = 24;
            this.pbPlazo.TabIndex = 16;
            this.pbPlazo.Value = 48;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha y hora";
            this.colFecha.MinimumWidth = 6;
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colEvento
            // 
            this.colEvento.HeaderText = "Evento";
            this.colEvento.MinimumWidth = 6;
            this.colEvento.Name = "colEvento";
            this.colEvento.ReadOnly = true;
            // 
            // colModulo
            // 
            this.colModulo.HeaderText = "Módulo";
            this.colModulo.MinimumWidth = 6;
            this.colModulo.Name = "colModulo";
            this.colModulo.ReadOnly = true;
            // 
            // lblPaso1
            // 
            this.lblPaso1.AutoSize = true;
            this.lblPaso1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaso1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblPaso1.Location = new System.Drawing.Point(89, 29);
            this.lblPaso1.Name = "lblPaso1";
            this.lblPaso1.Size = new System.Drawing.Size(80, 40);
            this.lblPaso1.TabIndex = 2;
            this.lblPaso1.Text = "① \r\nRecepción\r\n";
            this.lblPaso1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(167)))), ((int)(((byte)(182)))));
            this.label1.Location = new System.Drawing.Point(182, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "   ───────\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFechaPaso1
            // 
            this.lblFechaPaso1.AutoSize = true;
            this.lblFechaPaso1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblFechaPaso1.Location = new System.Drawing.Point(67, 69);
            this.lblFechaPaso1.Name = "lblFechaPaso1";
            this.lblFechaPaso1.Size = new System.Drawing.Size(124, 20);
            this.lblFechaPaso1.TabIndex = 4;
            this.lblFechaPaso1.Text = "10/11/2026 15:00";
            // 
            // lblFechaPaso2
            // 
            this.lblFechaPaso2.AutoSize = true;
            this.lblFechaPaso2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblFechaPaso2.Location = new System.Drawing.Point(261, 69);
            this.lblFechaPaso2.Name = "lblFechaPaso2";
            this.lblFechaPaso2.Size = new System.Drawing.Size(124, 20);
            this.lblFechaPaso2.TabIndex = 7;
            this.lblFechaPaso2.Text = "10/11/2026 15:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(167)))), ((int)(((byte)(182)))));
            this.label4.Location = new System.Drawing.Point(376, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "   ───────\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPaso2
            // 
            this.lblPaso2.AutoSize = true;
            this.lblPaso2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaso2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblPaso2.Location = new System.Drawing.Point(283, 29);
            this.lblPaso2.Name = "lblPaso2";
            this.lblPaso2.Size = new System.Drawing.Size(80, 40);
            this.lblPaso2.TabIndex = 5;
            this.lblPaso2.Text = "① \r\nRecepción\r\n";
            this.lblPaso2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFechaPaso4
            // 
            this.lblFechaPaso4.AutoSize = true;
            this.lblFechaPaso4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblFechaPaso4.Location = new System.Drawing.Point(651, 69);
            this.lblFechaPaso4.Name = "lblFechaPaso4";
            this.lblFechaPaso4.Size = new System.Drawing.Size(124, 20);
            this.lblFechaPaso4.TabIndex = 13;
            this.lblFechaPaso4.Text = "10/11/2026 15:00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(167)))), ((int)(((byte)(182)))));
            this.label8.Location = new System.Drawing.Point(766, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "   ───────\r\n";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPaso4
            // 
            this.lblPaso4.AutoSize = true;
            this.lblPaso4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaso4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(193)))), ((int)(((byte)(227)))));
            this.lblPaso4.Location = new System.Drawing.Point(673, 29);
            this.lblPaso4.Name = "lblPaso4";
            this.lblPaso4.Size = new System.Drawing.Size(80, 40);
            this.lblPaso4.TabIndex = 11;
            this.lblPaso4.Text = "① \r\nRecepción\r\n";
            this.lblPaso4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFechaPaso3
            // 
            this.lblFechaPaso3.AutoSize = true;
            this.lblFechaPaso3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblFechaPaso3.Location = new System.Drawing.Point(457, 69);
            this.lblFechaPaso3.Name = "lblFechaPaso3";
            this.lblFechaPaso3.Size = new System.Drawing.Size(124, 20);
            this.lblFechaPaso3.TabIndex = 10;
            this.lblFechaPaso3.Text = "10/11/2026 15:00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(167)))), ((int)(((byte)(182)))));
            this.label11.Location = new System.Drawing.Point(572, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "   ───────\r\n";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPaso3
            // 
            this.lblPaso3.AutoSize = true;
            this.lblPaso3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaso3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblPaso3.Location = new System.Drawing.Point(479, 29);
            this.lblPaso3.Name = "lblPaso3";
            this.lblPaso3.Size = new System.Drawing.Size(80, 40);
            this.lblPaso3.TabIndex = 8;
            this.lblPaso3.Text = "① \r\nRecepción\r\n";
            this.lblPaso3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFechaPaso5
            // 
            this.lblFechaPaso5.AutoSize = true;
            this.lblFechaPaso5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblFechaPaso5.Location = new System.Drawing.Point(842, 69);
            this.lblFechaPaso5.Name = "lblFechaPaso5";
            this.lblFechaPaso5.Size = new System.Drawing.Size(124, 20);
            this.lblFechaPaso5.TabIndex = 16;
            this.lblFechaPaso5.Text = "10/11/2026 15:00";
            // 
            // lblPaso5
            // 
            this.lblPaso5.AutoSize = true;
            this.lblPaso5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaso5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblPaso5.Location = new System.Drawing.Point(864, 29);
            this.lblPaso5.Name = "lblPaso5";
            this.lblPaso5.Size = new System.Drawing.Size(78, 40);
            this.lblPaso5.TabIndex = 14;
            this.lblPaso5.Text = "① \r\nRecepción\r\n";
            this.lblPaso5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmSeguimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private System.Windows.Forms.ProgressBar pbPlazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModulo;
        private System.Windows.Forms.Label lblPaso1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFechaPaso1;
        private System.Windows.Forms.Label lblFechaPaso5;
        private System.Windows.Forms.Label lblPaso5;
        private System.Windows.Forms.Label lblFechaPaso4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPaso4;
        private System.Windows.Forms.Label lblFechaPaso3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPaso3;
        private System.Windows.Forms.Label lblFechaPaso2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPaso2;
    }
}