namespace CapaPresentacion
{
    partial class FrmConsolidado
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsBarra = new System.Windows.Forms.ToolStrip();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlHoja = new System.Windows.Forms.Panel();
            this.tlpTablas = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSecContado = new System.Windows.Forms.Panel();
            this.dgvContado = new System.Windows.Forms.DataGridView();
            this.colNroC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClienteC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChasisC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlacaC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirmaC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSecContado = new System.Windows.Forms.Label();
            this.pnlSecCredito = new System.Windows.Forms.Panel();
            this.dgvCredito = new System.Windows.Forms.DataGridView();
            this.colNroCr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClienteCr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChasisCr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlacaCr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirmaCr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSecCredito = new System.Windows.Forms.Label();
            this.pnlPie = new System.Windows.Forms.Panel();
            this.lblEntregadoPor = new System.Windows.Forms.Label();
            this.lblTotalEntregados = new System.Windows.Forms.Label();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tsbImprimir = new System.Windows.Forms.ToolStripButton();
            this.tsbVistaPrevia = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsBarra.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            this.pnlHoja.SuspendLayout();
            this.tlpTablas.SuspendLayout();
            this.pnlSecContado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContado)).BeginInit();
            this.pnlSecCredito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredito)).BeginInit();
            this.pnlPie.SuspendLayout();
            this.pnlEncabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsBarra
            // 
            this.tsBarra.AutoSize = false;
            this.tsBarra.BackColor = System.Drawing.Color.White;
            this.tsBarra.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsBarra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbImprimir,
            this.tsbVistaPrevia,
            this.tsbSalir});
            this.tsBarra.Location = new System.Drawing.Point(0, 0);
            this.tsBarra.Name = "tsBarra";
            this.tsBarra.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.tsBarra.Size = new System.Drawing.Size(1060, 44);
            this.tsBarra.TabIndex = 0;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.pnlHoja);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 44);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Padding = new System.Windows.Forms.Padding(16);
            this.pnlContenedor.Size = new System.Drawing.Size(1060, 716);
            this.pnlContenedor.TabIndex = 1;
            // 
            // pnlHoja
            // 
            this.pnlHoja.BackColor = System.Drawing.Color.White;
            this.pnlHoja.Controls.Add(this.tlpTablas);
            this.pnlHoja.Controls.Add(this.pnlPie);
            this.pnlHoja.Controls.Add(this.pnlEncabezado);
            this.pnlHoja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHoja.Location = new System.Drawing.Point(16, 16);
            this.pnlHoja.Name = "pnlHoja";
            this.pnlHoja.Padding = new System.Windows.Forms.Padding(20);
            this.pnlHoja.Size = new System.Drawing.Size(1028, 684);
            this.pnlHoja.TabIndex = 0;
            // 
            // tlpTablas
            // 
            this.tlpTablas.ColumnCount = 1;
            this.tlpTablas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTablas.Controls.Add(this.pnlSecContado, 0, 0);
            this.tlpTablas.Controls.Add(this.pnlSecCredito, 0, 1);
            this.tlpTablas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTablas.Location = new System.Drawing.Point(20, 86);
            this.tlpTablas.Name = "tlpTablas";
            this.tlpTablas.Padding = new System.Windows.Forms.Padding(0, 14, 0, 14);
            this.tlpTablas.RowCount = 2;
            this.tlpTablas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTablas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTablas.Size = new System.Drawing.Size(988, 538);
            this.tlpTablas.TabIndex = 2;
            // 
            // pnlSecContado
            // 
            this.pnlSecContado.Controls.Add(this.dgvContado);
            this.pnlSecContado.Controls.Add(this.lblSecContado);
            this.pnlSecContado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSecContado.Location = new System.Drawing.Point(0, 14);
            this.pnlSecContado.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlSecContado.Name = "pnlSecContado";
            this.pnlSecContado.Size = new System.Drawing.Size(988, 245);
            this.pnlSecContado.TabIndex = 0;
            // 
            // dgvContado
            // 
            this.dgvContado.AllowUserToAddRows = false;
            this.dgvContado.AllowUserToDeleteRows = false;
            this.dgvContado.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvContado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContado.BackgroundColor = System.Drawing.Color.White;
            this.dgvContado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.dgvContado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContado.ColumnHeadersHeight = 30;
            this.dgvContado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvContado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNroC,
            this.colClienteC,
            this.colChasisC,
            this.colPlacaC,
            this.colFirmaC});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContado.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvContado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContado.EnableHeadersVisualStyles = false;
            this.dgvContado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.dgvContado.Location = new System.Drawing.Point(0, 28);
            this.dgvContado.MultiSelect = false;
            this.dgvContado.Name = "dgvContado";
            this.dgvContado.ReadOnly = true;
            this.dgvContado.RowHeadersVisible = false;
            this.dgvContado.RowTemplate.Height = 28;
            this.dgvContado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContado.Size = new System.Drawing.Size(988, 217);
            this.dgvContado.TabIndex = 0;
            // 
            // colNroC
            // 
            this.colNroC.FillWeight = 35F;
            this.colNroC.HeaderText = "N°";
            this.colNroC.Name = "colNroC";
            this.colNroC.ReadOnly = true;
            // 
            // colClienteC
            // 
            this.colClienteC.HeaderText = "Cliente / Propietario";
            this.colClienteC.Name = "colClienteC";
            this.colClienteC.ReadOnly = true;
            // 
            // colChasisC
            // 
            this.colChasisC.HeaderText = "Chasis";
            this.colChasisC.Name = "colChasisC";
            this.colChasisC.ReadOnly = true;
            // 
            // colPlacaC
            // 
            this.colPlacaC.FillWeight = 70F;
            this.colPlacaC.HeaderText = "Placa";
            this.colPlacaC.Name = "colPlacaC";
            this.colPlacaC.ReadOnly = true;
            // 
            // colFirmaC
            // 
            this.colFirmaC.HeaderText = "Firma y Sello Recepción";
            this.colFirmaC.Name = "colFirmaC";
            this.colFirmaC.ReadOnly = true;
            // 
            // lblSecContado
            // 
            this.lblSecContado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblSecContado.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSecContado.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSecContado.ForeColor = System.Drawing.Color.White;
            this.lblSecContado.Location = new System.Drawing.Point(0, 0);
            this.lblSecContado.Name = "lblSecContado";
            this.lblSecContado.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblSecContado.Size = new System.Drawing.Size(988, 28);
            this.lblSecContado.TabIndex = 1;
            this.lblSecContado.Text = "MODALIDAD: CONTADO";
            this.lblSecContado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSecCredito
            // 
            this.pnlSecCredito.Controls.Add(this.dgvCredito);
            this.pnlSecCredito.Controls.Add(this.lblSecCredito);
            this.pnlSecCredito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSecCredito.Location = new System.Drawing.Point(0, 275);
            this.pnlSecCredito.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.pnlSecCredito.Name = "pnlSecCredito";
            this.pnlSecCredito.Size = new System.Drawing.Size(988, 249);
            this.pnlSecCredito.TabIndex = 1;
            // 
            // dgvCredito
            // 
            this.dgvCredito.AllowUserToAddRows = false;
            this.dgvCredito.AllowUserToDeleteRows = false;
            this.dgvCredito.AllowUserToResizeRows = false;
            this.dgvCredito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCredito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCredito.BackgroundColor = System.Drawing.Color.White;
            this.dgvCredito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCredito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCredito.ColumnHeadersHeight = 30;
            this.dgvCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCredito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNroCr,
            this.colClienteCr,
            this.colChasisCr,
            this.colPlacaCr,
            this.colFirmaCr});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCredito.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCredito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCredito.EnableHeadersVisualStyles = false;
            this.dgvCredito.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.dgvCredito.Location = new System.Drawing.Point(0, 28);
            this.dgvCredito.MultiSelect = false;
            this.dgvCredito.Name = "dgvCredito";
            this.dgvCredito.ReadOnly = true;
            this.dgvCredito.RowHeadersVisible = false;
            this.dgvCredito.RowTemplate.Height = 28;
            this.dgvCredito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCredito.Size = new System.Drawing.Size(988, 221);
            this.dgvCredito.TabIndex = 0;
            // 
            // colNroCr
            // 
            this.colNroCr.FillWeight = 35F;
            this.colNroCr.HeaderText = "N°";
            this.colNroCr.Name = "colNroCr";
            this.colNroCr.ReadOnly = true;
            // 
            // colClienteCr
            // 
            this.colClienteCr.HeaderText = "Cliente / Propietario";
            this.colClienteCr.Name = "colClienteCr";
            this.colClienteCr.ReadOnly = true;
            // 
            // colChasisCr
            // 
            this.colChasisCr.HeaderText = "Chasis";
            this.colChasisCr.Name = "colChasisCr";
            this.colChasisCr.ReadOnly = true;
            // 
            // colPlacaCr
            // 
            this.colPlacaCr.FillWeight = 70F;
            this.colPlacaCr.HeaderText = "Placa";
            this.colPlacaCr.Name = "colPlacaCr";
            this.colPlacaCr.ReadOnly = true;
            // 
            // colFirmaCr
            // 
            this.colFirmaCr.HeaderText = "Firma y Sello Recepción";
            this.colFirmaCr.Name = "colFirmaCr";
            this.colFirmaCr.ReadOnly = true;
            // 
            // lblSecCredito
            // 
            this.lblSecCredito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblSecCredito.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSecCredito.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSecCredito.ForeColor = System.Drawing.Color.White;
            this.lblSecCredito.Location = new System.Drawing.Point(0, 0);
            this.lblSecCredito.Name = "lblSecCredito";
            this.lblSecCredito.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblSecCredito.Size = new System.Drawing.Size(988, 28);
            this.lblSecCredito.TabIndex = 1;
            this.lblSecCredito.Text = "MODALIDAD: CRÉDITO";
            this.lblSecCredito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlPie
            // 
            this.pnlPie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlPie.Controls.Add(this.lblEntregadoPor);
            this.pnlPie.Controls.Add(this.lblTotalEntregados);
            this.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPie.Location = new System.Drawing.Point(20, 624);
            this.pnlPie.Name = "pnlPie";
            this.pnlPie.Size = new System.Drawing.Size(988, 40);
            this.pnlPie.TabIndex = 1;
            // 
            // lblEntregadoPor
            // 
            this.lblEntregadoPor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEntregadoPor.AutoSize = true;
            this.lblEntregadoPor.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblEntregadoPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblEntregadoPor.Location = new System.Drawing.Point(820, 11);
            this.lblEntregadoPor.Name = "lblEntregadoPor";
            this.lblEntregadoPor.Size = new System.Drawing.Size(152, 17);
            this.lblEntregadoPor.TabIndex = 0;
            this.lblEntregadoPor.Text = "Entregado por: GDCON";
            // 
            // lblTotalEntregados
            // 
            this.lblTotalEntregados.AutoSize = true;
            this.lblTotalEntregados.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalEntregados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblTotalEntregados.Location = new System.Drawing.Point(16, 11);
            this.lblTotalEntregados.Name = "lblTotalEntregados";
            this.lblTotalEntregados.Size = new System.Drawing.Size(138, 19);
            this.lblTotalEntregados.TabIndex = 1;
            this.lblTotalEntregados.Text = "Total entregados: 0";
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.pnlEncabezado.Controls.Add(this.lblFecha);
            this.pnlEncabezado.Controls.Add(this.lblSubtitulo);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(20, 20);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.pnlEncabezado.Size = new System.Drawing.Size(988, 66);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(840, 22);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(119, 17);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha: 19/11/2026";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(193)))), ((int)(((byte)(227)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(18, 37);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(334, 15);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "GDCON Legal System — Control de Documentación Vehicular";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(16, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(432, 25);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "LISTADO CONSOLIDADO DE ENTREGA A IMCRUZ";
            // 
            // tsbImprimir
            // 
            this.tsbImprimir.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.tsbImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.tsbImprimir.Image = global::CapaPresentacion.Properties.Resources.IMPRIMIR;
            this.tsbImprimir.Name = "tsbImprimir";
            this.tsbImprimir.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tsbImprimir.Size = new System.Drawing.Size(102, 41);
            this.tsbImprimir.Text = " Imprimir";
            this.tsbImprimir.Click += new System.EventHandler(this.tsbImprimir_Click);
            // 
            // tsbVistaPrevia
            // 
            this.tsbVistaPrevia.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.tsbVistaPrevia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.tsbVistaPrevia.Image = global::CapaPresentacion.Properties.Resources.icons8_invisible_50;
            this.tsbVistaPrevia.Name = "tsbVistaPrevia";
            this.tsbVistaPrevia.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tsbVistaPrevia.Size = new System.Drawing.Size(117, 41);
            this.tsbVistaPrevia.Text = "Vista previa";
            this.tsbVistaPrevia.ToolTipText = "👁 Vista previa";
            this.tsbVistaPrevia.Click += new System.EventHandler(this.tsbVistaPrevia_Click);
            // 
            // tsbSalir
            // 
            this.tsbSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSalir.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.tsbSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.tsbSalir.Image = global::CapaPresentacion.Properties.Resources.SALIR;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tsbSalir.Size = new System.Drawing.Size(81, 41);
            this.tsbSalir.Text = "Cerrar";
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // FrmConsolidado
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1060, 760);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.tsBarra);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsolidado";
            this.Text = "Listado Consolidado de Entrega";
            this.tsBarra.ResumeLayout(false);
            this.tsBarra.PerformLayout();
            this.pnlContenedor.ResumeLayout(false);
            this.pnlHoja.ResumeLayout(false);
            this.tlpTablas.ResumeLayout(false);
            this.pnlSecContado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContado)).EndInit();
            this.pnlSecCredito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredito)).EndInit();
            this.pnlPie.ResumeLayout(false);
            this.pnlPie.PerformLayout();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsBarra;
        private System.Windows.Forms.ToolStripButton tsbImprimir;
        private System.Windows.Forms.ToolStripButton tsbVistaPrevia;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnlHoja;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel pnlPie;
        private System.Windows.Forms.Label lblTotalEntregados;
        private System.Windows.Forms.Label lblEntregadoPor;
        private System.Windows.Forms.TableLayoutPanel tlpTablas;
        private System.Windows.Forms.Panel pnlSecContado;
        private System.Windows.Forms.Label lblSecContado;
        private System.Windows.Forms.DataGridView dgvContado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClienteC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChasisC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlacaC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirmaC;
        private System.Windows.Forms.Panel pnlSecCredito;
        private System.Windows.Forms.Label lblSecCredito;
        private System.Windows.Forms.DataGridView dgvCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroCr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClienteCr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChasisCr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlacaCr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirmaCr;
    }
}