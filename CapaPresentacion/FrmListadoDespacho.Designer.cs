namespace CapaPresentacion
{
    partial class FrmListadoDespacho
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
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle altStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cellStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.tsBarra = new System.Windows.Forms.ToolStrip();
            this.tsbImprimir = new System.Windows.Forms.ToolStripButton();
            this.tsbVistaPrevia = new System.Windows.Forms.ToolStripButton();
            this.tssSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlHoja = new System.Windows.Forms.Panel();
            this.pnlPie = new System.Windows.Forms.Panel();
            this.lblFirmaEntrega = new System.Windows.Forms.Label();
            this.lblTotalDespachados = new System.Windows.Forms.Label();
            this.tlpTablas = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSecContado = new System.Windows.Forms.Panel();
            this.dgvContado = new System.Windows.Forms.DataGridView();
            this.colNroC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClienteC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChasisC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPolizaC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDestinoC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSecContado = new System.Windows.Forms.Label();
            this.pnlSecCredito = new System.Windows.Forms.Panel();
            this.dgvCredito = new System.Windows.Forms.DataGridView();
            this.colNroCr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClienteCr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChasisCr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPolizaCr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDestinoCr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSecCredito = new System.Windows.Forms.Label();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();

            this.tsBarra.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            this.pnlHoja.SuspendLayout();
            this.pnlPie.SuspendLayout();
            this.tlpTablas.SuspendLayout();
            this.pnlSecContado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContado)).BeginInit();
            this.pnlSecCredito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredito)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
            this.SuspendLayout();

            // Estilos compartidos para tablas
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = System.Drawing.Color.FromArgb(230, 236, 245);
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            headerStyle.ForeColor = System.Drawing.Color.FromArgb(9, 26, 58);

            altStyle.BackColor = System.Drawing.Color.FromArgb(247, 250, 252);

            cellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            cellStyle.BackColor = System.Drawing.Color.White;
            cellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            cellStyle.ForeColor = System.Drawing.Color.FromArgb(9, 26, 58);
            cellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(207, 241, 249);
            cellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(9, 26, 58);

            // 
            // tsBarra
            // 
            this.tsBarra.AutoSize = false;
            this.tsBarra.BackColor = System.Drawing.Color.White;
            this.tsBarra.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsBarra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbImprimir,
            this.tsbVistaPrevia,
            this.tssSep1,
            this.tsbSalir});
            this.tsBarra.Location = new System.Drawing.Point(0, 0);
            this.tsBarra.Name = "tsBarra";
            this.tsBarra.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.tsBarra.Size = new System.Drawing.Size(1060, 44);
            this.tsBarra.TabIndex = 0;

            // 
            // tsbImprimir
            // 
            this.tsbImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbImprimir.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.tsbImprimir.ForeColor = System.Drawing.Color.FromArgb(9, 26, 58);
            this.tsbImprimir.Name = "tsbImprimir";
            this.tsbImprimir.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tsbImprimir.Text = "🖨 Imprimir";
            this.tsbImprimir.Click += new System.EventHandler(this.tsbImprimir_Click);

            // 
            // tsbVistaPrevia
            // 
            this.tsbVistaPrevia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbVistaPrevia.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.tsbVistaPrevia.ForeColor = System.Drawing.Color.FromArgb(9, 26, 58);
            this.tsbVistaPrevia.Name = "tsbVistaPrevia";
            this.tsbVistaPrevia.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tsbVistaPrevia.Text = "👁 Vista previa";
            this.tsbVistaPrevia.Click += new System.EventHandler(this.tsbVistaPrevia_Click);

            // 
            // tssSep1
            // 
            this.tssSep1.Name = "tssSep1";
            this.tssSep1.Size = new System.Drawing.Size(6, 44);

            // 
            // tsbSalir
            // 
            this.tsbSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSalir.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.tsbSalir.ForeColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tsbSalir.Text = "Salir";
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);

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
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(9, 26, 58);
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
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(16, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "LISTADO DE DESPACHO DE TRÁMITES";

            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(25, 193, 227);
            this.lblSubtitulo.Location = new System.Drawing.Point(18, 37);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Text = "GDCON Legal System — Despacho a Alcaldía y Diprove";

            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(840, 22);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Text = "Fecha: 19/11/2026";

            // 
            // pnlPie
            // 
            this.pnlPie.BackColor = System.Drawing.Color.FromArgb(244, 247, 250);
            this.pnlPie.Controls.Add(this.lblFirmaEntrega);
            this.pnlPie.Controls.Add(this.lblTotalDespachados);
            this.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPie.Location = new System.Drawing.Point(20, 624);
            this.pnlPie.Name = "pnlPie";
            this.pnlPie.Size = new System.Drawing.Size(988, 40);
            this.pnlPie.TabIndex = 1;

            // 
            // lblTotalDespachados
            // 
            this.lblTotalDespachados.AutoSize = true;
            this.lblTotalDespachados.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalDespachados.ForeColor = System.Drawing.Color.FromArgb(9, 26, 58);
            this.lblTotalDespachados.Location = new System.Drawing.Point(16, 11);
            this.lblTotalDespachados.Name = "lblTotalDespachados";
            this.lblTotalDespachados.Text = "Total despachados: 0";

            // 
            // lblFirmaEntrega
            // 
            this.lblFirmaEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirmaEntrega.AutoSize = true;
            this.lblFirmaEntrega.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFirmaEntrega.ForeColor = System.Drawing.Color.FromArgb(91, 107, 124);
            this.lblFirmaEntrega.Location = new System.Drawing.Point(690, 11);
            this.lblFirmaEntrega.Name = "lblFirmaEntrega";
            this.lblFirmaEntrega.Text = "Firma de entrega: ______________________";

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
            this.pnlSecContado.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlSecContado.Name = "pnlSecContado";

            // 
            // lblSecContado
            // 
            this.lblSecContado.BackColor = System.Drawing.Color.FromArgb(9, 26, 58);
            this.lblSecContado.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSecContado.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSecContado.ForeColor = System.Drawing.Color.White;
            this.lblSecContado.Name = "lblSecContado";
            this.lblSecContado.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblSecContado.Size = new System.Drawing.Size(988, 28);
            this.lblSecContado.Text = "MODALIDAD: CONTADO";
            this.lblSecContado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // dgvContado
            // 
            this.dgvContado.AllowUserToAddRows = false;
            this.dgvContado.AllowUserToDeleteRows = false;
            this.dgvContado.AllowUserToResizeRows = false;
            this.dgvContado.AlternatingRowsDefaultCellStyle = altStyle;
            this.dgvContado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContado.BackgroundColor = System.Drawing.Color.White;
            this.dgvContado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContado.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvContado.ColumnHeadersHeight = 30;
            this.dgvContado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvContado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNroC, this.colClienteC, this.colChasisC, this.colPolizaC, this.colDestinoC});
            this.dgvContado.DefaultCellStyle = cellStyle;
            this.dgvContado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContado.EnableHeadersVisualStyles = false;
            this.dgvContado.GridColor = System.Drawing.Color.FromArgb(227, 233, 240);
            this.dgvContado.MultiSelect = false;
            this.dgvContado.Name = "dgvContado";
            this.dgvContado.ReadOnly = true;
            this.dgvContado.RowHeadersVisible = false;
            this.dgvContado.RowTemplate.Height = 28;
            this.dgvContado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.colNroC.FillWeight = 35F;
            this.colNroC.HeaderText = "N°";
            this.colNroC.Name = "colNroC";
            this.colClienteC.HeaderText = "Cliente";
            this.colClienteC.Name = "colClienteC";
            this.colChasisC.HeaderText = "Chasis";
            this.colChasisC.Name = "colChasisC";
            this.colPolizaC.FillWeight = 90F;
            this.colPolizaC.HeaderText = "N° Póliza";
            this.colPolizaC.Name = "colPolizaC";
            this.colDestinoC.HeaderText = "Destino";
            this.colDestinoC.Name = "colDestinoC";

            // 
            // pnlSecCredito
            // 
            this.pnlSecCredito.Controls.Add(this.dgvCredito);
            this.pnlSecCredito.Controls.Add(this.lblSecCredito);
            this.pnlSecCredito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSecCredito.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.pnlSecCredito.Name = "pnlSecCredito";

            // 
            // lblSecCredito
            // 
            this.lblSecCredito.BackColor = System.Drawing.Color.FromArgb(9, 26, 58);
            this.lblSecCredito.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSecCredito.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSecCredito.ForeColor = System.Drawing.Color.White;
            this.lblSecCredito.Name = "lblSecCredito";
            this.lblSecCredito.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblSecCredito.Size = new System.Drawing.Size(988, 28);
            this.lblSecCredito.Text = "MODALIDAD: CRÉDITO";
            this.lblSecCredito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // dgvCredito
            // 
            this.dgvCredito.AllowUserToAddRows = false;
            this.dgvCredito.AllowUserToDeleteRows = false;
            this.dgvCredito.AllowUserToResizeRows = false;
            this.dgvCredito.AlternatingRowsDefaultCellStyle = altStyle;
            this.dgvCredito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCredito.BackgroundColor = System.Drawing.Color.White;
            this.dgvCredito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCredito.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvCredito.ColumnHeadersHeight = 30;
            this.dgvCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCredito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNroCr, this.colClienteCr, this.colChasisCr, this.colPolizaCr, this.colDestinoCr});
            this.dgvCredito.DefaultCellStyle = cellStyle;
            this.dgvCredito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCredito.EnableHeadersVisualStyles = false;
            this.dgvCredito.GridColor = System.Drawing.Color.FromArgb(227, 233, 240);
            this.dgvCredito.MultiSelect = false;
            this.dgvCredito.Name = "dgvCredito";
            this.dgvCredito.ReadOnly = true;
            this.dgvCredito.RowHeadersVisible = false;
            this.dgvCredito.RowTemplate.Height = 28;
            this.dgvCredito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.colNroCr.FillWeight = 35F;
            this.colNroCr.HeaderText = "N°";
            this.colNroCr.Name = "colNroCr";
            this.colClienteCr.HeaderText = "Cliente";
            this.colClienteCr.Name = "colClienteCr";
            this.colChasisCr.HeaderText = "Chasis";
            this.colChasisCr.Name = "colChasisCr";
            this.colPolizaCr.FillWeight = 90F;
            this.colPolizaCr.HeaderText = "N° Póliza";
            this.colPolizaCr.Name = "colPolizaCr";
            this.colDestinoCr.HeaderText = "Destino";
            this.colDestinoCr.Name = "colDestinoCr";

            // 
            // FrmListadoDespacho
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(244, 247, 250);
            this.ClientSize = new System.Drawing.Size(1060, 760);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.tsBarra);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListadoDespacho";
            this.Text = "Listado de Despacho";

            this.tsBarra.ResumeLayout(false);
            this.tsBarra.PerformLayout();
            this.pnlContenedor.ResumeLayout(false);
            this.pnlHoja.ResumeLayout(false);
            this.pnlPie.ResumeLayout(false);
            this.pnlPie.PerformLayout();
            this.tlpTablas.ResumeLayout(false);
            this.pnlSecContado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContado)).EndInit();
            this.pnlSecCredito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredito)).EndInit();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ToolStrip tsBarra;
        private System.Windows.Forms.ToolStripButton tsbImprimir;
        private System.Windows.Forms.ToolStripButton tsbVistaPrevia;
        private System.Windows.Forms.ToolStripSeparator tssSep1;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnlHoja;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel pnlPie;
        private System.Windows.Forms.Label lblTotalDespachados;
        private System.Windows.Forms.Label lblFirmaEntrega;
        private System.Windows.Forms.TableLayoutPanel tlpTablas;
        private System.Windows.Forms.Panel pnlSecContado;
        private System.Windows.Forms.Label lblSecContado;
        private System.Windows.Forms.DataGridView dgvContado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClienteC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChasisC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPolizaC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDestinoC;
        private System.Windows.Forms.Panel pnlSecCredito;
        private System.Windows.Forms.Label lblSecCredito;
        private System.Windows.Forms.DataGridView dgvCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroCr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClienteCr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChasisCr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPolizaCr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDestinoCr;
    }
}