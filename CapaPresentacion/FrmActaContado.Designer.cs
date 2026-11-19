namespace CapaPresentacion
{
    partial class FrmActaContado
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tsBarra = new System.Windows.Forms.ToolStrip();
            this.tsbImprimir = new System.Windows.Forms.ToolStripButton();
            this.tsbVistaPrevia = new System.Windows.Forms.ToolStripButton();
            this.tssSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.pnlHoja = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblQrTxt = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlLineaTitulo = new System.Windows.Forms.Panel();
            this.lblClienteT = new System.Windows.Forms.Label();
            this.lblClienteV = new System.Windows.Forms.Label();
            this.lblNitCiT = new System.Windows.Forms.Label();
            this.lblNitCiV = new System.Windows.Forms.Label();
            this.lblDescVehiculo = new System.Windows.Forms.Label();
            this.tlpVehiculo = new System.Windows.Forms.TableLayoutPanel();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblClase = new System.Windows.Forms.Label();
            this.lblChasis = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.pnlLineaDetalle = new System.Windows.Forms.Panel();
            this.tlpDetalle = new System.Windows.Forms.TableLayoutPanel();
            this.lblHdrDesc = new System.Windows.Forms.Label();
            this.lblHdrConf = new System.Windows.Forms.Label();
            this.lblDoc1 = new System.Windows.Forms.Label();
            this.chkItem1 = new System.Windows.Forms.CheckBox();
            this.lblDoc2 = new System.Windows.Forms.Label();
            this.chkItem2 = new System.Windows.Forms.CheckBox();
            this.lblDoc3 = new System.Windows.Forms.Label();
            this.chkItem3 = new System.Windows.Forms.CheckBox();
            this.lblDoc4 = new System.Windows.Forms.Label();
            this.chkItem4 = new System.Windows.Forms.CheckBox();
            this.lblDoc5 = new System.Windows.Forms.Label();
            this.chkItem5 = new System.Windows.Forms.CheckBox();
            this.lblDoc6 = new System.Windows.Forms.Label();
            this.chkItem6 = new System.Windows.Forms.CheckBox();
            this.lblDoc7 = new System.Windows.Forms.Label();
            this.chkItem7 = new System.Windows.Forms.CheckBox();
            this.lblDoc8 = new System.Windows.Forms.Label();
            this.chkItem8 = new System.Windows.Forms.CheckBox();
            this.lblDoc9 = new System.Windows.Forms.Label();
            this.chkItem9 = new System.Windows.Forms.CheckBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblFirmamos = new System.Windows.Forms.Label();
            this.lblLugarFecha = new System.Windows.Forms.Label();
            this.pnlFirmaEntregue = new System.Windows.Forms.Panel();
            this.pnlFirmaRecibi = new System.Windows.Forms.Panel();
            this.lblEntregue = new System.Windows.Forms.Label();
            this.lblRecibi = new System.Windows.Forms.Label();
            this.lblNitCiFirma = new System.Windows.Forms.Label();
            this.picQr = new System.Windows.Forms.PictureBox();
            this.tsBarra.SuspendLayout();
            this.pnlFondo.SuspendLayout();
            this.pnlHoja.SuspendLayout();
            this.tlpVehiculo.SuspendLayout();
            this.tlpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQr)).BeginInit();
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
            this.tssSep1,
            this.tsbSalir});
            this.tsBarra.Location = new System.Drawing.Point(0, 0);
            this.tsBarra.Name = "tsBarra";
            this.tsBarra.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.tsBarra.Size = new System.Drawing.Size(1060, 44);
            this.tsBarra.TabIndex = 0;
            this.tsBarra.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsBarra_ItemClicked);
            // 
            // tsbImprimir
            // 
            this.tsbImprimir.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.tsbImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.tsbImprimir.Image = global::CapaPresentacion.Properties.Resources.IMPRIMIR;
            this.tsbImprimir.Name = "tsbImprimir";
            this.tsbImprimir.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tsbImprimir.Size = new System.Drawing.Size(98, 41);
            this.tsbImprimir.Text = "Imprimir";
            this.tsbImprimir.Click += new System.EventHandler(this.tsbImprimir_Click);
            // 
            // tsbVistaPrevia
            // 
            this.tsbVistaPrevia.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.tsbVistaPrevia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.tsbVistaPrevia.Image = global::CapaPresentacion.Properties.Resources.VISTA_PREVIA;
            this.tsbVistaPrevia.Name = "tsbVistaPrevia";
            this.tsbVistaPrevia.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tsbVistaPrevia.Size = new System.Drawing.Size(117, 41);
            this.tsbVistaPrevia.Text = "Vista previa";
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
            this.tsbSalir.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.tsbSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.tsbSalir.Image = global::CapaPresentacion.Properties.Resources.SALIR;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tsbSalir.Size = new System.Drawing.Size(71, 41);
            this.tsbSalir.Text = "Salir";
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // pnlFondo
            // 
            this.pnlFondo.AutoScroll = true;
            this.pnlFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(209)))), ((int)(((byte)(218)))));
            this.pnlFondo.Controls.Add(this.pnlHoja);
            this.pnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFondo.Location = new System.Drawing.Point(0, 44);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(1060, 716);
            this.pnlFondo.TabIndex = 1;
            // 
            // pnlHoja
            // 
            this.pnlHoja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlHoja.BackColor = System.Drawing.Color.White;
            this.pnlHoja.Controls.Add(this.lblLogo);
            this.pnlHoja.Controls.Add(this.picQr);
            this.pnlHoja.Controls.Add(this.lblQrTxt);
            this.pnlHoja.Controls.Add(this.lblTitulo);
            this.pnlHoja.Controls.Add(this.pnlLineaTitulo);
            this.pnlHoja.Controls.Add(this.lblClienteT);
            this.pnlHoja.Controls.Add(this.lblClienteV);
            this.pnlHoja.Controls.Add(this.lblNitCiT);
            this.pnlHoja.Controls.Add(this.lblNitCiV);
            this.pnlHoja.Controls.Add(this.lblDescVehiculo);
            this.pnlHoja.Controls.Add(this.tlpVehiculo);
            this.pnlHoja.Controls.Add(this.lblDetalle);
            this.pnlHoja.Controls.Add(this.pnlLineaDetalle);
            this.pnlHoja.Controls.Add(this.tlpDetalle);
            this.pnlHoja.Controls.Add(this.lblObservaciones);
            this.pnlHoja.Controls.Add(this.txtObservaciones);
            this.pnlHoja.Controls.Add(this.lblFirmamos);
            this.pnlHoja.Controls.Add(this.lblLugarFecha);
            this.pnlHoja.Controls.Add(this.pnlFirmaEntregue);
            this.pnlHoja.Controls.Add(this.pnlFirmaRecibi);
            this.pnlHoja.Controls.Add(this.lblEntregue);
            this.pnlHoja.Controls.Add(this.lblRecibi);
            this.pnlHoja.Controls.Add(this.lblNitCiFirma);
            this.pnlHoja.Location = new System.Drawing.Point(211, 16);
            this.pnlHoja.Name = "pnlHoja";
            this.pnlHoja.Size = new System.Drawing.Size(620, 972);
            this.pnlHoja.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblLogo.Location = new System.Drawing.Point(30, 24);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(200, 34);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "IMCRUZ";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQrTxt
            // 
            this.lblQrTxt.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblQrTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblQrTxt.Location = new System.Drawing.Point(470, 112);
            this.lblQrTxt.Name = "lblQrTxt";
            this.lblQrTxt.Size = new System.Drawing.Size(150, 18);
            this.lblQrTxt.TabIndex = 2;
            this.lblQrTxt.Text = "QR de verificación";
            this.lblQrTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblTitulo.Location = new System.Drawing.Point(30, 140);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(560, 30);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "ACTA DE ENTREGA DE DOCUMENTOS - CONTADO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLineaTitulo
            // 
            this.pnlLineaTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.pnlLineaTitulo.Location = new System.Drawing.Point(30, 172);
            this.pnlLineaTitulo.Name = "pnlLineaTitulo";
            this.pnlLineaTitulo.Size = new System.Drawing.Size(560, 2);
            this.pnlLineaTitulo.TabIndex = 4;
            // 
            // lblClienteT
            // 
            this.lblClienteT.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblClienteT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblClienteT.Location = new System.Drawing.Point(30, 190);
            this.lblClienteT.Name = "lblClienteT";
            this.lblClienteT.Size = new System.Drawing.Size(150, 24);
            this.lblClienteT.TabIndex = 5;
            this.lblClienteT.Text = "Cliente/Propietario:";
            this.lblClienteT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClienteV
            // 
            this.lblClienteV.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblClienteV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblClienteV.Location = new System.Drawing.Point(185, 190);
            this.lblClienteV.Name = "lblClienteV";
            this.lblClienteV.Size = new System.Drawing.Size(405, 24);
            this.lblClienteV.TabIndex = 6;
            this.lblClienteV.Text = "-";
            this.lblClienteV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNitCiT
            // 
            this.lblNitCiT.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNitCiT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblNitCiT.Location = new System.Drawing.Point(30, 216);
            this.lblNitCiT.Name = "lblNitCiT";
            this.lblNitCiT.Size = new System.Drawing.Size(150, 24);
            this.lblNitCiT.TabIndex = 7;
            this.lblNitCiT.Text = "NIT/CI:";
            this.lblNitCiT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNitCiV
            // 
            this.lblNitCiV.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNitCiV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblNitCiV.Location = new System.Drawing.Point(185, 216);
            this.lblNitCiV.Name = "lblNitCiV";
            this.lblNitCiV.Size = new System.Drawing.Size(405, 24);
            this.lblNitCiV.TabIndex = 8;
            this.lblNitCiV.Text = "-";
            this.lblNitCiV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescVehiculo
            // 
            this.lblDescVehiculo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDescVehiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblDescVehiculo.Location = new System.Drawing.Point(30, 250);
            this.lblDescVehiculo.Name = "lblDescVehiculo";
            this.lblDescVehiculo.Size = new System.Drawing.Size(300, 24);
            this.lblDescVehiculo.TabIndex = 9;
            this.lblDescVehiculo.Text = "Descripción del Vehículo:";
            this.lblDescVehiculo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpVehiculo
            // 
            this.tlpVehiculo.ColumnCount = 3;
            this.tlpVehiculo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpVehiculo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpVehiculo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tlpVehiculo.Controls.Add(this.lblPlaca, 0, 0);
            this.tlpVehiculo.Controls.Add(this.lblModelo, 1, 0);
            this.tlpVehiculo.Controls.Add(this.lblMarca, 2, 0);
            this.tlpVehiculo.Controls.Add(this.lblColor, 0, 1);
            this.tlpVehiculo.Controls.Add(this.lblClase, 1, 1);
            this.tlpVehiculo.Controls.Add(this.lblChasis, 2, 1);
            this.tlpVehiculo.Location = new System.Drawing.Point(30, 276);
            this.tlpVehiculo.Name = "tlpVehiculo";
            this.tlpVehiculo.RowCount = 2;
            this.tlpVehiculo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpVehiculo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpVehiculo.Size = new System.Drawing.Size(560, 64);
            this.tlpVehiculo.TabIndex = 10;
            // 
            // lblPlaca
            // 
            this.lblPlaca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlaca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPlaca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblPlaca.Location = new System.Drawing.Point(0, 0);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(186, 32);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa:";
            this.lblPlaca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblModelo
            // 
            this.lblModelo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModelo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblModelo.Location = new System.Drawing.Point(186, 0);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(186, 32);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo:";
            this.lblModelo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMarca
            // 
            this.lblMarca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblMarca.Location = new System.Drawing.Point(372, 0);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(188, 32);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca:";
            this.lblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblColor
            // 
            this.lblColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblColor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblColor.Location = new System.Drawing.Point(0, 32);
            this.lblColor.Margin = new System.Windows.Forms.Padding(0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(186, 32);
            this.lblColor.TabIndex = 3;
            this.lblColor.Text = "Color:";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClase
            // 
            this.lblClase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblClase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblClase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblClase.Location = new System.Drawing.Point(186, 32);
            this.lblClase.Margin = new System.Windows.Forms.Padding(0);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(186, 32);
            this.lblClase.TabIndex = 4;
            this.lblClase.Text = "Clase:";
            this.lblClase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblChasis
            // 
            this.lblChasis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChasis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblChasis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblChasis.Location = new System.Drawing.Point(372, 32);
            this.lblChasis.Margin = new System.Windows.Forms.Padding(0);
            this.lblChasis.Name = "lblChasis";
            this.lblChasis.Size = new System.Drawing.Size(188, 32);
            this.lblChasis.TabIndex = 5;
            this.lblChasis.Text = "Chasis:";
            this.lblChasis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDetalle
            // 
            this.lblDetalle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblDetalle.Location = new System.Drawing.Point(30, 352);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(300, 24);
            this.lblDetalle.TabIndex = 11;
            this.lblDetalle.Text = "Detalle de Entrega";
            this.lblDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlLineaDetalle
            // 
            this.pnlLineaDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.pnlLineaDetalle.Location = new System.Drawing.Point(30, 376);
            this.pnlLineaDetalle.Name = "pnlLineaDetalle";
            this.pnlLineaDetalle.Size = new System.Drawing.Size(560, 2);
            this.pnlLineaDetalle.TabIndex = 12;
            // 
            // tlpDetalle
            // 
            this.tlpDetalle.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpDetalle.ColumnCount = 2;
            this.tlpDetalle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 430F));
            this.tlpDetalle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpDetalle.Controls.Add(this.lblHdrDesc, 0, 0);
            this.tlpDetalle.Controls.Add(this.lblHdrConf, 1, 0);
            this.tlpDetalle.Controls.Add(this.lblDoc1, 0, 1);
            this.tlpDetalle.Controls.Add(this.chkItem1, 1, 1);
            this.tlpDetalle.Controls.Add(this.lblDoc2, 0, 2);
            this.tlpDetalle.Controls.Add(this.chkItem2, 1, 2);
            this.tlpDetalle.Controls.Add(this.lblDoc3, 0, 3);
            this.tlpDetalle.Controls.Add(this.chkItem3, 1, 3);
            this.tlpDetalle.Controls.Add(this.lblDoc4, 0, 4);
            this.tlpDetalle.Controls.Add(this.chkItem4, 1, 4);
            this.tlpDetalle.Controls.Add(this.lblDoc5, 0, 5);
            this.tlpDetalle.Controls.Add(this.chkItem5, 1, 5);
            this.tlpDetalle.Controls.Add(this.lblDoc6, 0, 6);
            this.tlpDetalle.Controls.Add(this.chkItem6, 1, 6);
            this.tlpDetalle.Controls.Add(this.lblDoc7, 0, 7);
            this.tlpDetalle.Controls.Add(this.chkItem7, 1, 7);
            this.tlpDetalle.Controls.Add(this.lblDoc8, 0, 8);
            this.tlpDetalle.Controls.Add(this.chkItem8, 1, 8);
            this.tlpDetalle.Controls.Add(this.lblDoc9, 0, 9);
            this.tlpDetalle.Controls.Add(this.chkItem9, 1, 9);
            this.tlpDetalle.Location = new System.Drawing.Point(30, 384);
            this.tlpDetalle.Name = "tlpDetalle";
            this.tlpDetalle.RowCount = 10;
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpDetalle.Size = new System.Drawing.Size(560, 292);
            this.tlpDetalle.TabIndex = 13;
            // 
            // lblHdrDesc
            // 
            this.lblHdrDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHdrDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHdrDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblHdrDesc.Location = new System.Drawing.Point(1, 1);
            this.lblHdrDesc.Margin = new System.Windows.Forms.Padding(0);
            this.lblHdrDesc.Name = "lblHdrDesc";
            this.lblHdrDesc.Size = new System.Drawing.Size(430, 28);
            this.lblHdrDesc.TabIndex = 0;
            this.lblHdrDesc.Text = "Descripción";
            this.lblHdrDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHdrConf
            // 
            this.lblHdrConf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHdrConf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHdrConf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblHdrConf.Location = new System.Drawing.Point(432, 1);
            this.lblHdrConf.Margin = new System.Windows.Forms.Padding(0);
            this.lblHdrConf.Name = "lblHdrConf";
            this.lblHdrConf.Size = new System.Drawing.Size(130, 28);
            this.lblHdrConf.TabIndex = 1;
            this.lblHdrConf.Text = "Conformidad";
            this.lblHdrConf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDoc1
            // 
            this.lblDoc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDoc1.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDoc1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblDoc1.Location = new System.Drawing.Point(1, 30);
            this.lblDoc1.Margin = new System.Windows.Forms.Padding(0);
            this.lblDoc1.Name = "lblDoc1";
            this.lblDoc1.Size = new System.Drawing.Size(430, 28);
            this.lblDoc1.TabIndex = 2;
            this.lblDoc1.Text = "1. CARNET DE PROPIEDAD (Original)";
            this.lblDoc1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkItem1
            // 
            this.chkItem1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkItem1.AutoSize = true;
            this.chkItem1.Location = new System.Drawing.Point(489, 37);
            this.chkItem1.Name = "chkItem1";
            this.chkItem1.Size = new System.Drawing.Size(15, 14);
            this.chkItem1.TabIndex = 3;
            this.chkItem1.UseVisualStyleBackColor = true;
            // 
            // lblDoc2
            // 
            this.lblDoc2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDoc2.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDoc2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblDoc2.Location = new System.Drawing.Point(1, 59);
            this.lblDoc2.Margin = new System.Windows.Forms.Padding(0);
            this.lblDoc2.Name = "lblDoc2";
            this.lblDoc2.Size = new System.Drawing.Size(430, 28);
            this.lblDoc2.TabIndex = 4;
            this.lblDoc2.Text = "2. CERTIFICADO DE REGISTRO DE PROPIEDAD (Original)";
            this.lblDoc2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkItem2
            // 
            this.chkItem2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkItem2.AutoSize = true;
            this.chkItem2.Location = new System.Drawing.Point(489, 66);
            this.chkItem2.Name = "chkItem2";
            this.chkItem2.Size = new System.Drawing.Size(15, 14);
            this.chkItem2.TabIndex = 5;
            this.chkItem2.UseVisualStyleBackColor = true;
            // 
            // lblDoc3
            // 
            this.lblDoc3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDoc3.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDoc3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblDoc3.Location = new System.Drawing.Point(1, 88);
            this.lblDoc3.Margin = new System.Windows.Forms.Padding(0);
            this.lblDoc3.Name = "lblDoc3";
            this.lblDoc3.Size = new System.Drawing.Size(430, 28);
            this.lblDoc3.TabIndex = 6;
            this.lblDoc3.Text = "3. RESOLUCION DE INSCRIPCION DE TRANSITO (Original)";
            this.lblDoc3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkItem3
            // 
            this.chkItem3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkItem3.AutoSize = true;
            this.chkItem3.Location = new System.Drawing.Point(489, 95);
            this.chkItem3.Name = "chkItem3";
            this.chkItem3.Size = new System.Drawing.Size(15, 14);
            this.chkItem3.TabIndex = 7;
            this.chkItem3.UseVisualStyleBackColor = true;
            // 
            // lblDoc4
            // 
            this.lblDoc4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDoc4.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDoc4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblDoc4.Location = new System.Drawing.Point(1, 117);
            this.lblDoc4.Margin = new System.Windows.Forms.Padding(0);
            this.lblDoc4.Name = "lblDoc4";
            this.lblDoc4.Size = new System.Drawing.Size(430, 28);
            this.lblDoc4.TabIndex = 8;
            this.lblDoc4.Text = "4. COMPROBANTE DE PAGO DE RECAUDACIONES (Copia simple)";
            this.lblDoc4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkItem4
            // 
            this.chkItem4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkItem4.AutoSize = true;
            this.chkItem4.Location = new System.Drawing.Point(489, 124);
            this.chkItem4.Name = "chkItem4";
            this.chkItem4.Size = new System.Drawing.Size(15, 14);
            this.chkItem4.TabIndex = 9;
            this.chkItem4.UseVisualStyleBackColor = true;
            // 
            // lblDoc5
            // 
            this.lblDoc5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDoc5.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDoc5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblDoc5.Location = new System.Drawing.Point(1, 146);
            this.lblDoc5.Margin = new System.Windows.Forms.Padding(0);
            this.lblDoc5.Name = "lblDoc5";
            this.lblDoc5.Size = new System.Drawing.Size(430, 28);
            this.lblDoc5.TabIndex = 10;
            this.lblDoc5.Text = "5. FACTURA ADUANERA (Copia simple)";
            this.lblDoc5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkItem5
            // 
            this.chkItem5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkItem5.AutoSize = true;
            this.chkItem5.Location = new System.Drawing.Point(489, 153);
            this.chkItem5.Name = "chkItem5";
            this.chkItem5.Size = new System.Drawing.Size(15, 14);
            this.chkItem5.TabIndex = 11;
            this.chkItem5.UseVisualStyleBackColor = true;
            // 
            // lblDoc6
            // 
            this.lblDoc6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDoc6.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDoc6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblDoc6.Location = new System.Drawing.Point(1, 175);
            this.lblDoc6.Margin = new System.Windows.Forms.Padding(0);
            this.lblDoc6.Name = "lblDoc6";
            this.lblDoc6.Size = new System.Drawing.Size(430, 28);
            this.lblDoc6.TabIndex = 12;
            this.lblDoc6.Text = "6. PLANILLA ADUANERA (Copia simple)";
            this.lblDoc6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkItem6
            // 
            this.chkItem6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkItem6.AutoSize = true;
            this.chkItem6.Location = new System.Drawing.Point(489, 182);
            this.chkItem6.Name = "chkItem6";
            this.chkItem6.Size = new System.Drawing.Size(15, 14);
            this.chkItem6.TabIndex = 13;
            this.chkItem6.UseVisualStyleBackColor = true;
            // 
            // lblDoc7
            // 
            this.lblDoc7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDoc7.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDoc7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblDoc7.Location = new System.Drawing.Point(1, 204);
            this.lblDoc7.Margin = new System.Windows.Forms.Padding(0);
            this.lblDoc7.Name = "lblDoc7";
            this.lblDoc7.Size = new System.Drawing.Size(430, 28);
            this.lblDoc7.TabIndex = 14;
            this.lblDoc7.Text = "7. POLIZA/FRV - DECLARACION DE MERCANCIA DE IMPORTACION (Legalizada)";
            this.lblDoc7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkItem7
            // 
            this.chkItem7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkItem7.AutoSize = true;
            this.chkItem7.Location = new System.Drawing.Point(489, 211);
            this.chkItem7.Name = "chkItem7";
            this.chkItem7.Size = new System.Drawing.Size(15, 14);
            this.chkItem7.TabIndex = 15;
            this.chkItem7.UseVisualStyleBackColor = true;
            // 
            // lblDoc8
            // 
            this.lblDoc8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDoc8.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDoc8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblDoc8.Location = new System.Drawing.Point(1, 233);
            this.lblDoc8.Margin = new System.Windows.Forms.Padding(0);
            this.lblDoc8.Name = "lblDoc8";
            this.lblDoc8.Size = new System.Drawing.Size(430, 28);
            this.lblDoc8.TabIndex = 16;
            this.lblDoc8.Text = "8. SOAT 2026 (Copia simple)";
            this.lblDoc8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkItem8
            // 
            this.chkItem8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkItem8.AutoSize = true;
            this.chkItem8.Location = new System.Drawing.Point(489, 240);
            this.chkItem8.Name = "chkItem8";
            this.chkItem8.Size = new System.Drawing.Size(15, 14);
            this.chkItem8.TabIndex = 17;
            this.chkItem8.UseVisualStyleBackColor = true;
            // 
            // lblDoc9
            // 
            this.lblDoc9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDoc9.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDoc9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblDoc9.Location = new System.Drawing.Point(1, 262);
            this.lblDoc9.Margin = new System.Windows.Forms.Padding(0);
            this.lblDoc9.Name = "lblDoc9";
            this.lblDoc9.Size = new System.Drawing.Size(430, 28);
            this.lblDoc9.TabIndex = 18;
            this.lblDoc9.Text = "9. PAR DE PLACAS N° 0000XXX (Originales)";
            this.lblDoc9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkItem9
            // 
            this.chkItem9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkItem9.AutoSize = true;
            this.chkItem9.Location = new System.Drawing.Point(489, 269);
            this.chkItem9.Name = "chkItem9";
            this.chkItem9.Size = new System.Drawing.Size(15, 14);
            this.chkItem9.TabIndex = 19;
            this.chkItem9.UseVisualStyleBackColor = true;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblObservaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblObservaciones.Location = new System.Drawing.Point(30, 680);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(300, 22);
            this.lblObservaciones.TabIndex = 14;
            this.lblObservaciones.Text = "Observaciones Generales.";
            this.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(30, 704);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(560, 50);
            this.txtObservaciones.TabIndex = 15;
            // 
            // lblFirmamos
            // 
            this.lblFirmamos.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFirmamos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblFirmamos.Location = new System.Drawing.Point(30, 776);
            this.lblFirmamos.Name = "lblFirmamos";
            this.lblFirmamos.Size = new System.Drawing.Size(560, 22);
            this.lblFirmamos.TabIndex = 16;
            this.lblFirmamos.Text = "Firmamos en señal de conformidad.";
            this.lblFirmamos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLugarFecha
            // 
            this.lblLugarFecha.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblLugarFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblLugarFecha.Location = new System.Drawing.Point(30, 800);
            this.lblLugarFecha.Name = "lblLugarFecha";
            this.lblLugarFecha.Size = new System.Drawing.Size(560, 22);
            this.lblLugarFecha.TabIndex = 17;
            this.lblLugarFecha.Text = "Santa Cruz, .....de.....................de..........";
            this.lblLugarFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFirmaEntregue
            // 
            this.pnlFirmaEntregue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.pnlFirmaEntregue.Location = new System.Drawing.Point(60, 882);
            this.pnlFirmaEntregue.Name = "pnlFirmaEntregue";
            this.pnlFirmaEntregue.Size = new System.Drawing.Size(200, 2);
            this.pnlFirmaEntregue.TabIndex = 18;
            // 
            // pnlFirmaRecibi
            // 
            this.pnlFirmaRecibi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.pnlFirmaRecibi.Location = new System.Drawing.Point(360, 882);
            this.pnlFirmaRecibi.Name = "pnlFirmaRecibi";
            this.pnlFirmaRecibi.Size = new System.Drawing.Size(200, 2);
            this.pnlFirmaRecibi.TabIndex = 19;
            // 
            // lblEntregue
            // 
            this.lblEntregue.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblEntregue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblEntregue.Location = new System.Drawing.Point(60, 886);
            this.lblEntregue.Name = "lblEntregue";
            this.lblEntregue.Size = new System.Drawing.Size(200, 22);
            this.lblEntregue.TabIndex = 20;
            this.lblEntregue.Text = "Entregué Conforme";
            this.lblEntregue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecibi
            // 
            this.lblRecibi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblRecibi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblRecibi.Location = new System.Drawing.Point(360, 886);
            this.lblRecibi.Name = "lblRecibi";
            this.lblRecibi.Size = new System.Drawing.Size(200, 22);
            this.lblRecibi.TabIndex = 21;
            this.lblRecibi.Text = "Recibí Conforme";
            this.lblRecibi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNitCiFirma
            // 
            this.lblNitCiFirma.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNitCiFirma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblNitCiFirma.Location = new System.Drawing.Point(360, 910);
            this.lblNitCiFirma.Name = "lblNitCiFirma";
            this.lblNitCiFirma.Size = new System.Drawing.Size(200, 22);
            this.lblNitCiFirma.TabIndex = 22;
            this.lblNitCiFirma.Text = "NIT/CI:";
            this.lblNitCiFirma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picQr
            // 
            this.picQr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picQr.Location = new System.Drawing.Point(500, 20);
            this.picQr.Name = "picQr";
            this.picQr.Size = new System.Drawing.Size(90, 90);
            this.picQr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQr.TabIndex = 1;
            this.picQr.TabStop = false;
            // 
            // FrmActaContado
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(209)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1060, 760);
            this.Controls.Add(this.pnlFondo);
            this.Controls.Add(this.tsBarra);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmActaContado";
            this.Text = "Acta de Entrega de Documentos - Contado";
            this.tsBarra.ResumeLayout(false);
            this.tsBarra.PerformLayout();
            this.pnlFondo.ResumeLayout(false);
            this.pnlHoja.ResumeLayout(false);
            this.pnlHoja.PerformLayout();
            this.tlpVehiculo.ResumeLayout(false);
            this.tlpDetalle.ResumeLayout(false);
            this.tlpDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsBarra;
        private System.Windows.Forms.ToolStripButton tsbImprimir;
        private System.Windows.Forms.ToolStripButton tsbVistaPrevia;
        private System.Windows.Forms.ToolStripSeparator tssSep1;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.Panel pnlHoja;
        private System.Windows.Forms.PictureBox picQr;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Panel pnlLineaTitulo;
        private System.Windows.Forms.Panel pnlLineaDetalle;
        private System.Windows.Forms.Panel pnlFirmaEntregue;
        private System.Windows.Forms.Panel pnlFirmaRecibi;
        private System.Windows.Forms.TableLayoutPanel tlpVehiculo;
        private System.Windows.Forms.TableLayoutPanel tlpDetalle;
        private System.Windows.Forms.Label lblHdrDesc;
        private System.Windows.Forms.Label lblHdrConf;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblQrTxt;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblClienteT;
        private System.Windows.Forms.Label lblClienteV;
        private System.Windows.Forms.Label lblNitCiT;
        private System.Windows.Forms.Label lblNitCiV;
        private System.Windows.Forms.Label lblDescVehiculo;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblFirmamos;
        private System.Windows.Forms.Label lblLugarFecha;
        private System.Windows.Forms.Label lblEntregue;
        private System.Windows.Forms.Label lblRecibi;
        private System.Windows.Forms.Label lblNitCiFirma;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblClase;
        private System.Windows.Forms.Label lblChasis;
        private System.Windows.Forms.Label lblDoc1;
        private System.Windows.Forms.CheckBox chkItem1;
        private System.Windows.Forms.Label lblDoc2;
        private System.Windows.Forms.CheckBox chkItem2;
        private System.Windows.Forms.Label lblDoc3;
        private System.Windows.Forms.CheckBox chkItem3;
        private System.Windows.Forms.Label lblDoc4;
        private System.Windows.Forms.CheckBox chkItem4;
        private System.Windows.Forms.Label lblDoc5;
        private System.Windows.Forms.CheckBox chkItem5;
        private System.Windows.Forms.Label lblDoc6;
        private System.Windows.Forms.CheckBox chkItem6;
        private System.Windows.Forms.Label lblDoc7;
        private System.Windows.Forms.CheckBox chkItem7;
        private System.Windows.Forms.Label lblDoc8;
        private System.Windows.Forms.CheckBox chkItem8;
        private System.Windows.Forms.Label lblDoc9;
        private System.Windows.Forms.CheckBox chkItem9;
    }
}
