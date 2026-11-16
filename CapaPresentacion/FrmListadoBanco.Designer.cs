namespace CapaPresentacion
{
    partial class FrmListadoBanco
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

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsAcciones = new System.Windows.Forms.ToolStrip();
            this.tsbImprimir = new System.Windows.Forms.ToolStripButton();
            this.tsbVistaPrevia = new System.Windows.Forms.ToolStripButton();
            this.tsbLimpiar = new System.Windows.Forms.ToolStripButton();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.txtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.pnlCuerpo = new System.Windows.Forms.Panel();
            this.pnlHoja = new System.Windows.Forms.Panel();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPropietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.lblEtiquetaTotal = new System.Windows.Forms.Label();
            this.pnlPieFirma = new System.Windows.Forms.Panel();
            this.lblCargoDerecha = new System.Windows.Forms.Label();
            this.lblLineaFirmaDerecha = new System.Windows.Forms.Label();
            this.lblCargoIzquierda = new System.Windows.Forms.Label();
            this.lblLineaFirmaIzquierda = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlLineaDivisoria = new System.Windows.Forms.Panel();
            this.pnlEncabezadoHoja = new System.Windows.Forms.Panel();
            this.lblFechaEmision = new System.Windows.Forms.Label();
            this.lblCodigoReporte = new System.Windows.Forms.Label();
            this.lblSubtituloEmpresa = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.tsAcciones.SuspendLayout();
            this.pnlCuerpo.SuspendLayout();
            this.pnlHoja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.pnlTotal.SuspendLayout();
            this.pnlPieFirma.SuspendLayout();
            this.pnlEncabezadoHoja.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsAcciones
            // 
            this.tsAcciones.AutoSize = false;
            this.tsAcciones.BackColor = System.Drawing.Color.White;
            this.tsAcciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.tsAcciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsAcciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbImprimir,
            this.tsbVistaPrevia,
            this.tsbLimpiar,
            this.tsbCerrar,
            this.tsbBuscar,
            this.txtBuscar});
            this.tsAcciones.Location = new System.Drawing.Point(0, 0);
            this.tsAcciones.Name = "tsAcciones";
            this.tsAcciones.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tsAcciones.Size = new System.Drawing.Size(1060, 44);
            this.tsAcciones.TabIndex = 0;
            // 
            // tsbImprimir
            // 
            this.tsbImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.tsbImprimir.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tsbImprimir.Name = "tsbImprimir";
            this.tsbImprimir.Size = new System.Drawing.Size(76, 40);
            this.tsbImprimir.Text = "Imprimir";
            // 
            // tsbVistaPrevia
            // 
            this.tsbVistaPrevia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.tsbVistaPrevia.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tsbVistaPrevia.Name = "tsbVistaPrevia";
            this.tsbVistaPrevia.Size = new System.Drawing.Size(92, 40);
            this.tsbVistaPrevia.Text = "Vista previa";
            // 
            // tsbLimpiar
            // 
            this.tsbLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.tsbLimpiar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tsbLimpiar.Name = "tsbLimpiar";
            this.tsbLimpiar.Size = new System.Drawing.Size(67, 40);
            this.tsbLimpiar.Text = "Limpiar";
            // 
            // tsbCerrar
            // 
            this.tsbCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.tsbCerrar.Margin = new System.Windows.Forms.Padding(8, 2, 4, 2);
            this.tsbCerrar.Name = "tsbCerrar";
            this.tsbCerrar.Size = new System.Drawing.Size(59, 40);
            this.tsbCerrar.Text = "Cerrar";
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
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
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(220, 28);
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlCuerpo.Controls.Add(this.pnlHoja);
            this.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCuerpo.Location = new System.Drawing.Point(0, 44);
            this.pnlCuerpo.Name = "pnlCuerpo";
            this.pnlCuerpo.Padding = new System.Windows.Forms.Padding(36, 16, 36, 16);
            this.pnlCuerpo.Size = new System.Drawing.Size(1060, 716);
            this.pnlCuerpo.TabIndex = 1;
            // 
            // pnlHoja
            // 
            this.pnlHoja.BackColor = System.Drawing.Color.White;
            this.pnlHoja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHoja.Controls.Add(this.dgvPagos);
            this.pnlHoja.Controls.Add(this.pnlTotal);
            this.pnlHoja.Controls.Add(this.pnlPieFirma);
            this.pnlHoja.Controls.Add(this.lblTitulo);
            this.pnlHoja.Controls.Add(this.pnlLineaDivisoria);
            this.pnlHoja.Controls.Add(this.pnlEncabezadoHoja);
            this.pnlHoja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHoja.Location = new System.Drawing.Point(36, 16);
            this.pnlHoja.Name = "pnlHoja";
            this.pnlHoja.Padding = new System.Windows.Forms.Padding(28, 20, 28, 20);
            this.pnlHoja.Size = new System.Drawing.Size(988, 684);
            this.pnlHoja.TabIndex = 0;
            // 
            // dgvPagos
            // 
            this.dgvPagos.AllowUserToAddRows = false;
            this.dgvPagos.AllowUserToDeleteRows = false;
            this.dgvPagos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvPagos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPagos.BackgroundColor = System.Drawing.Color.White;
            this.dgvPagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPagos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPagos.ColumnHeadersHeight = 32;
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumero,
            this.colPropietario,
            this.colPlaca,
            this.colModalidad,
            this.colMonto});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPagos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPagos.EnableHeadersVisualStyles = false;
            this.dgvPagos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.dgvPagos.Location = new System.Drawing.Point(28, 114);
            this.dgvPagos.MultiSelect = false;
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.ReadOnly = true;
            this.dgvPagos.RowHeadersVisible = false;
            this.dgvPagos.RowTemplate.Height = 28;
            this.dgvPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagos.Size = new System.Drawing.Size(930, 424);
            this.dgvPagos.TabIndex = 0;
            // 
            // colNumero
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colNumero.DefaultCellStyle = dataGridViewCellStyle3;
            this.colNumero.FillWeight = 30F;
            this.colNumero.HeaderText = "N°";
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            // 
            // colPropietario
            // 
            this.colPropietario.FillWeight = 180F;
            this.colPropietario.HeaderText = "Propietario";
            this.colPropietario.Name = "colPropietario";
            this.colPropietario.ReadOnly = true;
            // 
            // colPlaca
            // 
            this.colPlaca.FillWeight = 80F;
            this.colPlaca.HeaderText = "Placa";
            this.colPlaca.Name = "colPlaca";
            this.colPlaca.ReadOnly = true;
            // 
            // colModalidad
            // 
            this.colModalidad.FillWeight = 80F;
            this.colModalidad.HeaderText = "Modalidad";
            this.colModalidad.Name = "colModalidad";
            this.colModalidad.ReadOnly = true;
            // 
            // colMonto
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colMonto.DefaultCellStyle = dataGridViewCellStyle4;
            this.colMonto.FillWeight = 80F;
            this.colMonto.HeaderText = "Monto (Bs)";
            this.colMonto.Name = "colMonto";
            this.colMonto.ReadOnly = true;
            // 
            // pnlTotal
            // 
            this.pnlTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.pnlTotal.Controls.Add(this.lblMontoTotal);
            this.pnlTotal.Controls.Add(this.lblEtiquetaTotal);
            this.pnlTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotal.Location = new System.Drawing.Point(28, 538);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.pnlTotal.Size = new System.Drawing.Size(930, 38);
            this.pnlTotal.TabIndex = 1;
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMontoTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMontoTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblMontoTotal.Location = new System.Drawing.Point(758, 0);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(160, 38);
            this.lblMontoTotal.TabIndex = 0;
            this.lblMontoTotal.Text = "Bs 1,800.00";
            this.lblMontoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEtiquetaTotal
            // 
            this.lblEtiquetaTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEtiquetaTotal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblEtiquetaTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblEtiquetaTotal.Location = new System.Drawing.Point(12, 0);
            this.lblEtiquetaTotal.Name = "lblEtiquetaTotal";
            this.lblEtiquetaTotal.Size = new System.Drawing.Size(906, 38);
            this.lblEtiquetaTotal.TabIndex = 1;
            this.lblEtiquetaTotal.Text = "TOTAL GENERAL PARA DESEMBOLSO BANCARIO:";
            this.lblEtiquetaTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlPieFirma
            // 
            this.pnlPieFirma.BackColor = System.Drawing.Color.White;
            this.pnlPieFirma.Controls.Add(this.lblCargoDerecha);
            this.pnlPieFirma.Controls.Add(this.lblLineaFirmaDerecha);
            this.pnlPieFirma.Controls.Add(this.lblCargoIzquierda);
            this.pnlPieFirma.Controls.Add(this.lblLineaFirmaIzquierda);
            this.pnlPieFirma.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPieFirma.Location = new System.Drawing.Point(28, 576);
            this.pnlPieFirma.Name = "pnlPieFirma";
            this.pnlPieFirma.Size = new System.Drawing.Size(930, 86);
            this.pnlPieFirma.TabIndex = 2;
            // 
            // lblCargoDerecha
            // 
            this.lblCargoDerecha.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCargoDerecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblCargoDerecha.Location = new System.Drawing.Point(540, 56);
            this.lblCargoDerecha.Name = "lblCargoDerecha";
            this.lblCargoDerecha.Size = new System.Drawing.Size(260, 20);
            this.lblCargoDerecha.TabIndex = 3;
            this.lblCargoDerecha.Text = "Autorizado por — Administración / Banco";
            this.lblCargoDerecha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLineaFirmaDerecha
            // 
            this.lblLineaFirmaDerecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblLineaFirmaDerecha.Location = new System.Drawing.Point(540, 36);
            this.lblLineaFirmaDerecha.Name = "lblLineaFirmaDerecha";
            this.lblLineaFirmaDerecha.Size = new System.Drawing.Size(260, 18);
            this.lblLineaFirmaDerecha.TabIndex = 2;
            this.lblLineaFirmaDerecha.Text = "____________________________________";
            this.lblLineaFirmaDerecha.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCargoIzquierda
            // 
            this.lblCargoIzquierda.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCargoIzquierda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblCargoIzquierda.Location = new System.Drawing.Point(130, 56);
            this.lblCargoIzquierda.Name = "lblCargoIzquierda";
            this.lblCargoIzquierda.Size = new System.Drawing.Size(260, 20);
            this.lblCargoIzquierda.TabIndex = 1;
            this.lblCargoIzquierda.Text = "Elaborado por — Encargado de Placas y Pagos";
            this.lblCargoIzquierda.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLineaFirmaIzquierda
            // 
            this.lblLineaFirmaIzquierda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblLineaFirmaIzquierda.Location = new System.Drawing.Point(130, 36);
            this.lblLineaFirmaIzquierda.Name = "lblLineaFirmaIzquierda";
            this.lblLineaFirmaIzquierda.Size = new System.Drawing.Size(260, 18);
            this.lblLineaFirmaIzquierda.TabIndex = 0;
            this.lblLineaFirmaIzquierda.Text = "____________________________________";
            this.lblLineaFirmaIzquierda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblTitulo.Location = new System.Drawing.Point(28, 72);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(930, 42);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "LISTADO DE PAGOS Y TRÁMITES PARA BANCO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLineaDivisoria
            // 
            this.pnlLineaDivisoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.pnlLineaDivisoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLineaDivisoria.Location = new System.Drawing.Point(28, 70);
            this.pnlLineaDivisoria.Name = "pnlLineaDivisoria";
            this.pnlLineaDivisoria.Size = new System.Drawing.Size(930, 2);
            this.pnlLineaDivisoria.TabIndex = 4;
            // 
            // pnlEncabezadoHoja
            // 
            this.pnlEncabezadoHoja.BackColor = System.Drawing.Color.White;
            this.pnlEncabezadoHoja.Controls.Add(this.lblFechaEmision);
            this.pnlEncabezadoHoja.Controls.Add(this.lblCodigoReporte);
            this.pnlEncabezadoHoja.Controls.Add(this.lblSubtituloEmpresa);
            this.pnlEncabezadoHoja.Controls.Add(this.lblEmpresa);
            this.pnlEncabezadoHoja.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezadoHoja.Location = new System.Drawing.Point(28, 20);
            this.pnlEncabezadoHoja.Name = "pnlEncabezadoHoja";
            this.pnlEncabezadoHoja.Size = new System.Drawing.Size(930, 50);
            this.pnlEncabezadoHoja.TabIndex = 5;
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaEmision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblFechaEmision.Location = new System.Drawing.Point(710, 24);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Size = new System.Drawing.Size(220, 18);
            this.lblFechaEmision.TabIndex = 3;
            this.lblFechaEmision.Text = "Fecha de emisión: 15/11/2026";
            this.lblFechaEmision.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCodigoReporte
            // 
            this.lblCodigoReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigoReporte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCodigoReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblCodigoReporte.Location = new System.Drawing.Point(710, 4);
            this.lblCodigoReporte.Name = "lblCodigoReporte";
            this.lblCodigoReporte.Size = new System.Drawing.Size(220, 18);
            this.lblCodigoReporte.TabIndex = 2;
            this.lblCodigoReporte.Text = "Reporte N°: BAN-2026-001";
            this.lblCodigoReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubtituloEmpresa
            // 
            this.lblSubtituloEmpresa.AutoSize = true;
            this.lblSubtituloEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblSubtituloEmpresa.Location = new System.Drawing.Point(0, 24);
            this.lblSubtituloEmpresa.Name = "lblSubtituloEmpresa";
            this.lblSubtituloEmpresa.Size = new System.Drawing.Size(298, 15);
            this.lblSubtituloEmpresa.TabIndex = 1;
            this.lblSubtituloEmpresa.Text = "Gestión Documental y Legal — Módulo de Placas y Pagos";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblEmpresa.Location = new System.Drawing.Point(0, 4);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(156, 19);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "GDCON LEGAL SYSTEM";
            // 
            // FrmListadoBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1060, 760);
            this.Controls.Add(this.pnlCuerpo);
            this.Controls.Add(this.tsAcciones);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(900, 650);
            this.Name = "FrmListadoBanco";
            this.Text = "Listado para el Banco";
            this.tsAcciones.ResumeLayout(false);
            this.tsAcciones.PerformLayout();
            this.pnlCuerpo.ResumeLayout(false);
            this.pnlHoja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.pnlTotal.ResumeLayout(false);
            this.pnlPieFirma.ResumeLayout(false);
            this.pnlEncabezadoHoja.ResumeLayout(false);
            this.pnlEncabezadoHoja.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ToolStrip tsAcciones;
        private System.Windows.Forms.ToolStripButton tsbImprimir;
        private System.Windows.Forms.ToolStripButton tsbVistaPrevia;
        private System.Windows.Forms.ToolStripButton tsbLimpiar;
        private System.Windows.Forms.ToolStripButton tsbCerrar;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.ToolStripTextBox txtBuscar;
        private System.Windows.Forms.Panel pnlCuerpo;
        private System.Windows.Forms.Panel pnlHoja;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPropietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonto;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.Label lblEtiquetaTotal;
        private System.Windows.Forms.Panel pnlPieFirma;
        private System.Windows.Forms.Label lblCargoDerecha;
        private System.Windows.Forms.Label lblLineaFirmaDerecha;
        private System.Windows.Forms.Label lblCargoIzquierda;
        private System.Windows.Forms.Label lblLineaFirmaIzquierda;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlLineaDivisoria;
        private System.Windows.Forms.Panel pnlEncabezadoHoja;
        private System.Windows.Forms.Label lblFechaEmision;
        private System.Windows.Forms.Label lblCodigoReporte;
        private System.Windows.Forms.Label lblSubtituloEmpresa;
        private System.Windows.Forms.Label lblEmpresa;
    }
}