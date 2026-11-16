namespace CapaPresentacion
{
    partial class FrmPlacasPagos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlacasPagos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lblPaso1 = new System.Windows.Forms.Label();
            this.lblPaso2 = new System.Windows.Forms.Label();
            this.lblPaso3 = new System.Windows.Forms.Label();
            this.lblPaso4 = new System.Windows.Forms.Label();
            this.lblPaso5 = new System.Windows.Forms.Label();
            this.pnlBordePasos = new System.Windows.Forms.Panel();
            this.pnlCuerpo = new System.Windows.Forms.Panel();
            this.pnlLista = new System.Windows.Forms.Panel();
            this.dgvPlacas = new System.Windows.Forms.DataGridView();
            this.colChasis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEncabezadoLista = new System.Windows.Forms.Label();
            this.pnlSeparador = new System.Windows.Forms.Panel();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.pnlAviso = new System.Windows.Forms.Panel();
            this.lblAviso = new System.Windows.Forms.Label();
            this.pnlBordeAviso = new System.Windows.Forms.Panel();
            this.tlpCampos = new System.Windows.Forms.TableLayoutPanel();
            this.lblChasis = new System.Windows.Forms.Label();
            this.txtChasis = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblModalidad = new System.Windows.Forms.Label();
            this.lblFechaAsignacion = new System.Windows.Forms.Label();
            this.txtModalidad = new System.Windows.Forms.TextBox();
            this.dtpFechaAsignacion = new System.Windows.Forms.DateTimePicker();
            this.chkRuat = new System.Windows.Forms.CheckBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblComprobante = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtComprobante = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.chkPago = new System.Windows.Forms.CheckBox();
            this.lblEncabezadoDatos = new System.Windows.Forms.Label();
            this.epValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.tsAcciones.SuspendLayout();
            this.pnlPasos.SuspendLayout();
            this.pnlCuerpo.SuspendLayout();
            this.pnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlacas)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.pnlAviso.SuspendLayout();
            this.tlpCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidacion)).BeginInit();
            this.SuspendLayout();
            // 
            // tsAcciones
            // 
            this.tsAcciones.BackColor = System.Drawing.Color.White;
            this.tsAcciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsAcciones.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsAcciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbGuardar,
            this.tsbModificar,
            this.tsbEliminar,
            this.tsbLimpiar,
            this.tsbCerrar,
            this.tsbBuscar,
            this.txtBuscar,
            this.btnSalir});
            this.tsAcciones.Location = new System.Drawing.Point(0, 0);
            this.tsAcciones.Name = "tsAcciones";
            this.tsAcciones.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tsAcciones.Size = new System.Drawing.Size(1060, 39);
            this.tsAcciones.TabIndex = 0;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(70, 35);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.ToolTipText = "Nuevo";
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(77, 35);
            this.tsbGuardar.Text = "Guardar";
            // 
            // tsbModificar
            // 
            this.tsbModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsbModificar.Image")));
            this.tsbModificar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(86, 35);
            this.tsbModificar.Text = "Modificar";
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(78, 35);
            this.tsbEliminar.Text = "Eliminar";
            // 
            // tsbLimpiar
            // 
            this.tsbLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("tsbLimpiar.Image")));
            this.tsbLimpiar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tsbLimpiar.Name = "tsbLimpiar";
            this.tsbLimpiar.Size = new System.Drawing.Size(75, 35);
            this.tsbLimpiar.Text = "Limpiar";
            // 
            // tsbCerrar
            // 
            this.tsbCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCerrar.Margin = new System.Windows.Forms.Padding(8, 2, 4, 2);
            this.tsbCerrar.Name = "tsbCerrar";
            this.tsbCerrar.Size = new System.Drawing.Size(43, 35);
            this.tsbCerrar.Text = "Cerrar";
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbBuscar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(46, 35);
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
            this.txtBuscar.Size = new System.Drawing.Size(220, 23);
            // 
            // pnlPasos
            // 
            this.pnlPasos.BackColor = System.Drawing.Color.White;
            this.pnlPasos.Controls.Add(this.lblPaso1);
            this.pnlPasos.Controls.Add(this.lblPaso2);
            this.pnlPasos.Controls.Add(this.lblPaso3);
            this.pnlPasos.Controls.Add(this.lblPaso4);
            this.pnlPasos.Controls.Add(this.lblPaso5);
            this.pnlPasos.Controls.Add(this.pnlBordePasos);
            this.pnlPasos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPasos.Location = new System.Drawing.Point(0, 39);
            this.pnlPasos.Name = "pnlPasos";
            this.pnlPasos.Size = new System.Drawing.Size(1060, 44);
            this.pnlPasos.TabIndex = 1;
            // 
            // lblPaso1
            // 
            this.lblPaso1.AutoSize = true;
            this.lblPaso1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(167)))), ((int)(((byte)(182)))));
            this.lblPaso1.Location = new System.Drawing.Point(190, 14);
            this.lblPaso1.Name = "lblPaso1";
            this.lblPaso1.Size = new System.Drawing.Size(114, 15);
            this.lblPaso1.TabIndex = 1;
            this.lblPaso1.Text = "① Recepción   ─────";
            // 
            // lblPaso2
            // 
            this.lblPaso2.AutoSize = true;
            this.lblPaso2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(167)))), ((int)(((byte)(182)))));
            this.lblPaso2.Location = new System.Drawing.Point(335, 14);
            this.lblPaso2.Name = "lblPaso2";
            this.lblPaso2.Size = new System.Drawing.Size(111, 15);
            this.lblPaso2.TabIndex = 2;
            this.lblPaso2.Text = "② Despacho   ─────";
            // 
            // lblPaso3
            // 
            this.lblPaso3.AutoSize = true;
            this.lblPaso3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPaso3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(193)))), ((int)(((byte)(227)))));
            this.lblPaso3.Location = new System.Drawing.Point(480, 14);
            this.lblPaso3.Name = "lblPaso3";
            this.lblPaso3.Size = new System.Drawing.Size(142, 15);
            this.lblPaso3.TabIndex = 3;
            this.lblPaso3.Text = "③ Placas y Pagos   ─────";
            // 
            // lblPaso4
            // 
            this.lblPaso4.AutoSize = true;
            this.lblPaso4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(167)))), ((int)(((byte)(182)))));
            this.lblPaso4.Location = new System.Drawing.Point(665, 14);
            this.lblPaso4.Name = "lblPaso4";
            this.lblPaso4.Size = new System.Drawing.Size(101, 15);
            this.lblPaso4.TabIndex = 4;
            this.lblPaso4.Text = "④ Tránsito   ─────";
            // 
            // lblPaso5
            // 
            this.lblPaso5.AutoSize = true;
            this.lblPaso5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(167)))), ((int)(((byte)(182)))));
            this.lblPaso5.Location = new System.Drawing.Point(795, 14);
            this.lblPaso5.Name = "lblPaso5";
            this.lblPaso5.Size = new System.Drawing.Size(60, 15);
            this.lblPaso5.TabIndex = 5;
            this.lblPaso5.Text = "⑤ Entrega";
            // 
            // pnlBordePasos
            // 
            this.pnlBordePasos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(221)))), ((int)(((byte)(230)))));
            this.pnlBordePasos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBordePasos.Location = new System.Drawing.Point(0, 43);
            this.pnlBordePasos.Name = "pnlBordePasos";
            this.pnlBordePasos.Size = new System.Drawing.Size(1060, 1);
            this.pnlBordePasos.TabIndex = 0;
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlCuerpo.Controls.Add(this.pnlLista);
            this.pnlCuerpo.Controls.Add(this.pnlSeparador);
            this.pnlCuerpo.Controls.Add(this.pnlDatos);
            this.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCuerpo.Location = new System.Drawing.Point(0, 83);
            this.pnlCuerpo.Name = "pnlCuerpo";
            this.pnlCuerpo.Padding = new System.Windows.Forms.Padding(12);
            this.pnlCuerpo.Size = new System.Drawing.Size(1060, 666);
            this.pnlCuerpo.TabIndex = 2;
            // 
            // pnlLista
            // 
            this.pnlLista.BackColor = System.Drawing.Color.White;
            this.pnlLista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLista.Controls.Add(this.dgvPlacas);
            this.pnlLista.Controls.Add(this.lblEncabezadoLista);
            this.pnlLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLista.Location = new System.Drawing.Point(364, 12);
            this.pnlLista.Name = "pnlLista";
            this.pnlLista.Size = new System.Drawing.Size(684, 642);
            this.pnlLista.TabIndex = 2;
            // 
            // dgvPlacas
            // 
            this.dgvPlacas.AllowUserToAddRows = false;
            this.dgvPlacas.AllowUserToDeleteRows = false;
            this.dgvPlacas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvPlacas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlacas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlacas.BackgroundColor = System.Drawing.Color.White;
            this.dgvPlacas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPlacas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlacas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPlacas.ColumnHeadersHeight = 30;
            this.dgvPlacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPlacas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChasis,
            this.colCliente,
            this.colModalidad,
            this.colPlaca,
            this.colRuat,
            this.colComprobante,
            this.colMonto,
            this.colPago});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlacas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPlacas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlacas.EnableHeadersVisualStyles = false;
            this.dgvPlacas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.dgvPlacas.Location = new System.Drawing.Point(0, 30);
            this.dgvPlacas.MultiSelect = false;
            this.dgvPlacas.Name = "dgvPlacas";
            this.dgvPlacas.ReadOnly = true;
            this.dgvPlacas.RowHeadersVisible = false;
            this.dgvPlacas.RowTemplate.Height = 28;
            this.dgvPlacas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlacas.Size = new System.Drawing.Size(682, 610);
            this.dgvPlacas.TabIndex = 1;
            // 
            // colChasis
            // 
            this.colChasis.FillWeight = 135F;
            this.colChasis.HeaderText = "Chasis";
            this.colChasis.Name = "colChasis";
            this.colChasis.ReadOnly = true;
            // 
            // colCliente
            // 
            this.colCliente.FillWeight = 155F;
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            // 
            // colModalidad
            // 
            this.colModalidad.FillWeight = 75F;
            this.colModalidad.HeaderText = "Modalidad";
            this.colModalidad.Name = "colModalidad";
            this.colModalidad.ReadOnly = true;
            // 
            // colPlaca
            // 
            this.colPlaca.FillWeight = 70F;
            this.colPlaca.HeaderText = "Placa";
            this.colPlaca.Name = "colPlaca";
            this.colPlaca.ReadOnly = true;
            // 
            // colRuat
            // 
            this.colRuat.FillWeight = 45F;
            this.colRuat.HeaderText = "RUAT";
            this.colRuat.Name = "colRuat";
            this.colRuat.ReadOnly = true;
            // 
            // colComprobante
            // 
            this.colComprobante.FillWeight = 95F;
            this.colComprobante.HeaderText = "N° comprobante";
            this.colComprobante.Name = "colComprobante";
            this.colComprobante.ReadOnly = true;
            // 
            // colMonto
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colMonto.DefaultCellStyle = dataGridViewCellStyle3;
            this.colMonto.FillWeight = 65F;
            this.colMonto.HeaderText = "Monto";
            this.colMonto.Name = "colMonto";
            this.colMonto.ReadOnly = true;
            // 
            // colPago
            // 
            this.colPago.FillWeight = 75F;
            this.colPago.HeaderText = "Pago";
            this.colPago.Name = "colPago";
            this.colPago.ReadOnly = true;
            // 
            // lblEncabezadoLista
            // 
            this.lblEncabezadoLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblEncabezadoLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEncabezadoLista.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEncabezadoLista.ForeColor = System.Drawing.Color.White;
            this.lblEncabezadoLista.Location = new System.Drawing.Point(0, 0);
            this.lblEncabezadoLista.Name = "lblEncabezadoLista";
            this.lblEncabezadoLista.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblEncabezadoLista.Size = new System.Drawing.Size(682, 30);
            this.lblEncabezadoLista.TabIndex = 0;
            this.lblEncabezadoLista.Text = "Placas y pagos registrados";
            this.lblEncabezadoLista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSeparador
            // 
            this.pnlSeparador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlSeparador.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSeparador.Location = new System.Drawing.Point(352, 12);
            this.pnlSeparador.Name = "pnlSeparador";
            this.pnlSeparador.Size = new System.Drawing.Size(12, 642);
            this.pnlSeparador.TabIndex = 1;
            // 
            // pnlDatos
            // 
            this.pnlDatos.BackColor = System.Drawing.Color.White;
            this.pnlDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatos.Controls.Add(this.pnlAviso);
            this.pnlDatos.Controls.Add(this.tlpCampos);
            this.pnlDatos.Controls.Add(this.lblEncabezadoDatos);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDatos.Location = new System.Drawing.Point(12, 12);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(340, 642);
            this.pnlDatos.TabIndex = 0;
            // 
            // pnlAviso
            // 
            this.pnlAviso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAviso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(224)))));
            this.pnlAviso.Controls.Add(this.lblAviso);
            this.pnlAviso.Controls.Add(this.pnlBordeAviso);
            this.pnlAviso.Location = new System.Drawing.Point(12, 440);
            this.pnlAviso.Name = "pnlAviso";
            this.pnlAviso.Size = new System.Drawing.Size(314, 42);
            this.pnlAviso.TabIndex = 2;
            // 
            // lblAviso
            // 
            this.lblAviso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAviso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(74)))), ((int)(((byte)(0)))));
            this.lblAviso.Location = new System.Drawing.Point(4, 0);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Padding = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.lblAviso.Size = new System.Drawing.Size(310, 42);
            this.lblAviso.TabIndex = 1;
            this.lblAviso.Text = "⚠  Sin placa no se puede registrar el pago.";
            this.lblAviso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBordeAviso
            // 
            this.pnlBordeAviso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(168)))), ((int)(((byte)(37)))));
            this.pnlBordeAviso.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBordeAviso.Location = new System.Drawing.Point(0, 0);
            this.pnlBordeAviso.Name = "pnlBordeAviso";
            this.pnlBordeAviso.Size = new System.Drawing.Size(4, 42);
            this.pnlBordeAviso.TabIndex = 0;
            // 
            // tlpCampos
            // 
            this.tlpCampos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCampos.ColumnCount = 2;
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCampos.Controls.Add(this.lblChasis, 0, 0);
            this.tlpCampos.Controls.Add(this.txtChasis, 0, 1);
            this.tlpCampos.Controls.Add(this.lblCliente, 0, 2);
            this.tlpCampos.Controls.Add(this.txtCliente, 0, 3);
            this.tlpCampos.Controls.Add(this.lblModalidad, 0, 4);
            this.tlpCampos.Controls.Add(this.lblFechaAsignacion, 1, 4);
            this.tlpCampos.Controls.Add(this.txtModalidad, 0, 5);
            this.tlpCampos.Controls.Add(this.dtpFechaAsignacion, 1, 5);
            this.tlpCampos.Controls.Add(this.chkRuat, 0, 6);
            this.tlpCampos.Controls.Add(this.lblPlaca, 0, 7);
            this.tlpCampos.Controls.Add(this.txtPlaca, 0, 8);
            this.tlpCampos.Controls.Add(this.lblComprobante, 0, 9);
            this.tlpCampos.Controls.Add(this.lblMonto, 1, 9);
            this.tlpCampos.Controls.Add(this.txtComprobante, 0, 10);
            this.tlpCampos.Controls.Add(this.txtMonto, 1, 10);
            this.tlpCampos.Controls.Add(this.chkPago, 0, 11);
            this.tlpCampos.Location = new System.Drawing.Point(12, 42);
            this.tlpCampos.Name = "tlpCampos";
            this.tlpCampos.RowCount = 12;
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.Size = new System.Drawing.Size(314, 390);
            this.tlpCampos.TabIndex = 1;
            // 
            // lblChasis
            // 
            this.lblChasis.AutoSize = true;
            this.tlpCampos.SetColumnSpan(this.lblChasis, 2);
            this.lblChasis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblChasis.Location = new System.Drawing.Point(0, 4);
            this.lblChasis.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.lblChasis.Name = "lblChasis";
            this.lblChasis.Size = new System.Drawing.Size(41, 15);
            this.lblChasis.TabIndex = 0;
            this.lblChasis.Text = "Chasis";
            // 
            // txtChasis
            // 
            this.txtChasis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tlpCampos.SetColumnSpan(this.txtChasis, 2);
            this.txtChasis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtChasis.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtChasis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.txtChasis.Location = new System.Drawing.Point(0, 21);
            this.txtChasis.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.txtChasis.Name = "txtChasis";
            this.txtChasis.Size = new System.Drawing.Size(314, 25);
            this.txtChasis.TabIndex = 0;
            this.txtChasis.Text = "JM7DM2W7AV0700104";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.tlpCampos.SetColumnSpan(this.lblCliente, 2);
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblCliente.Location = new System.Drawing.Point(0, 58);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(44, 15);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.tlpCampos.SetColumnSpan(this.txtCliente, 2);
            this.txtCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCliente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(107)))));
            this.txtCliente.Location = new System.Drawing.Point(0, 75);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(314, 25);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.TabStop = false;
            this.txtCliente.Text = "LUCIA FERNANDA ROCA PINTO";
            // 
            // lblModalidad
            // 
            this.lblModalidad.AutoSize = true;
            this.lblModalidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblModalidad.Location = new System.Drawing.Point(0, 112);
            this.lblModalidad.Margin = new System.Windows.Forms.Padding(0, 4, 4, 2);
            this.lblModalidad.Name = "lblModalidad";
            this.lblModalidad.Size = new System.Drawing.Size(64, 15);
            this.lblModalidad.TabIndex = 2;
            this.lblModalidad.Text = "Modalidad";
            // 
            // lblFechaAsignacion
            // 
            this.lblFechaAsignacion.AutoSize = true;
            this.lblFechaAsignacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblFechaAsignacion.Location = new System.Drawing.Point(161, 112);
            this.lblFechaAsignacion.Margin = new System.Windows.Forms.Padding(4, 4, 0, 2);
            this.lblFechaAsignacion.Name = "lblFechaAsignacion";
            this.lblFechaAsignacion.Size = new System.Drawing.Size(114, 15);
            this.lblFechaAsignacion.TabIndex = 3;
            this.lblFechaAsignacion.Text = "Fecha de asignación";
            // 
            // txtModalidad
            // 
            this.txtModalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtModalidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModalidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtModalidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(107)))));
            this.txtModalidad.Location = new System.Drawing.Point(0, 129);
            this.txtModalidad.Margin = new System.Windows.Forms.Padding(0, 0, 4, 8);
            this.txtModalidad.Name = "txtModalidad";
            this.txtModalidad.ReadOnly = true;
            this.txtModalidad.Size = new System.Drawing.Size(153, 25);
            this.txtModalidad.TabIndex = 2;
            this.txtModalidad.TabStop = false;
            this.txtModalidad.Text = "CREDITO";
            // 
            // dtpFechaAsignacion
            // 
            this.dtpFechaAsignacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFechaAsignacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFechaAsignacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAsignacion.Location = new System.Drawing.Point(161, 129);
            this.dtpFechaAsignacion.Margin = new System.Windows.Forms.Padding(4, 0, 0, 8);
            this.dtpFechaAsignacion.Name = "dtpFechaAsignacion";
            this.dtpFechaAsignacion.Size = new System.Drawing.Size(153, 25);
            this.dtpFechaAsignacion.TabIndex = 3;
            // 
            // chkRuat
            // 
            this.chkRuat.AutoSize = true;
            this.chkRuat.Checked = true;
            this.chkRuat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tlpCampos.SetColumnSpan(this.chkRuat, 2);
            this.chkRuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.chkRuat.Location = new System.Drawing.Point(0, 166);
            this.chkRuat.Margin = new System.Windows.Forms.Padding(0, 4, 0, 8);
            this.chkRuat.Name = "chkRuat";
            this.chkRuat.Size = new System.Drawing.Size(182, 19);
            this.chkRuat.TabIndex = 4;
            this.chkRuat.Text = "Verificado en la web del RUAT";
            this.chkRuat.UseVisualStyleBackColor = true;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.tlpCampos.SetColumnSpan(this.lblPlaca, 2);
            this.lblPlaca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblPlaca.Location = new System.Drawing.Point(0, 197);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(85, 15);
            this.lblPlaca.TabIndex = 5;
            this.lblPlaca.Text = "Placa asignada";
            // 
            // txtPlaca
            // 
            this.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tlpCampos.SetColumnSpan(this.txtPlaca, 2);
            this.txtPlaca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPlaca.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPlaca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.txtPlaca.Location = new System.Drawing.Point(0, 214);
            this.txtPlaca.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.txtPlaca.MaxLength = 7;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(314, 25);
            this.txtPlaca.TabIndex = 5;
            this.txtPlaca.Text = "6901ABH";
            // 
            // lblComprobante
            // 
            this.lblComprobante.AutoSize = true;
            this.lblComprobante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblComprobante.Location = new System.Drawing.Point(0, 251);
            this.lblComprobante.Margin = new System.Windows.Forms.Padding(0, 4, 4, 2);
            this.lblComprobante.Name = "lblComprobante";
            this.lblComprobante.Size = new System.Drawing.Size(112, 15);
            this.lblComprobante.TabIndex = 6;
            this.lblComprobante.Text = "N° de comprobante";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblMonto.Location = new System.Drawing.Point(161, 251);
            this.lblMonto.Margin = new System.Windows.Forms.Padding(4, 4, 0, 2);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(66, 15);
            this.lblMonto.TabIndex = 7;
            this.lblMonto.Text = "Monto (Bs)";
            // 
            // txtComprobante
            // 
            this.txtComprobante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComprobante.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtComprobante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.txtComprobante.Location = new System.Drawing.Point(0, 268);
            this.txtComprobante.Margin = new System.Windows.Forms.Padding(0, 0, 4, 8);
            this.txtComprobante.Name = "txtComprobante";
            this.txtComprobante.Size = new System.Drawing.Size(153, 25);
            this.txtComprobante.TabIndex = 6;
            this.txtComprobante.Text = "TRX-480104";
            // 
            // txtMonto
            // 
            this.txtMonto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.txtMonto.Location = new System.Drawing.Point(161, 268);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4, 0, 0, 8);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(153, 25);
            this.txtMonto.TabIndex = 7;
            this.txtMonto.Text = "450.00";
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkPago
            // 
            this.chkPago.AutoSize = true;
            this.tlpCampos.SetColumnSpan(this.chkPago, 2);
            this.chkPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.chkPago.Location = new System.Drawing.Point(0, 305);
            this.chkPago.Margin = new System.Windows.Forms.Padding(0, 4, 0, 8);
            this.chkPago.Name = "chkPago";
            this.chkPago.Size = new System.Drawing.Size(103, 19);
            this.chkPago.TabIndex = 8;
            this.chkPago.Text = "Pago realizado";
            this.chkPago.UseVisualStyleBackColor = true;
            // 
            // lblEncabezadoDatos
            // 
            this.lblEncabezadoDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.lblEncabezadoDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEncabezadoDatos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEncabezadoDatos.ForeColor = System.Drawing.Color.White;
            this.lblEncabezadoDatos.Location = new System.Drawing.Point(0, 0);
            this.lblEncabezadoDatos.Name = "lblEncabezadoDatos";
            this.lblEncabezadoDatos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblEncabezadoDatos.Size = new System.Drawing.Size(338, 30);
            this.lblEncabezadoDatos.TabIndex = 0;
            this.lblEncabezadoDatos.Text = "Datos — Placas y Pagos";
            this.lblEncabezadoDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // epValidacion
            // 
            this.epValidacion.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epValidacion.ContainerControl = this;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(57, 36);
            this.btnSalir.Text = "Salir";
            // 
            // FrmPlacasPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1060, 749);
            this.Controls.Add(this.pnlCuerpo);
            this.Controls.Add(this.pnlPasos);
            this.Controls.Add(this.tsAcciones);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(900, 650);
            this.Name = "FrmPlacasPagos";
            this.Text = "Placas y Pagos";
            this.tsAcciones.ResumeLayout(false);
            this.tsAcciones.PerformLayout();
            this.pnlPasos.ResumeLayout(false);
            this.pnlPasos.PerformLayout();
            this.pnlCuerpo.ResumeLayout(false);
            this.pnlLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlacas)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlAviso.ResumeLayout(false);
            this.tlpCampos.ResumeLayout(false);
            this.tlpCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

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
        private System.Windows.Forms.Label lblPaso1;
        private System.Windows.Forms.Label lblPaso2;
        private System.Windows.Forms.Label lblPaso3;
        private System.Windows.Forms.Label lblPaso4;
        private System.Windows.Forms.Label lblPaso5;
        private System.Windows.Forms.Panel pnlCuerpo;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Label lblEncabezadoDatos;
        private System.Windows.Forms.TableLayoutPanel tlpCampos;
        private System.Windows.Forms.Label lblChasis;
        private System.Windows.Forms.TextBox txtChasis;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblModalidad;
        private System.Windows.Forms.Label lblFechaAsignacion;
        private System.Windows.Forms.TextBox txtModalidad;
        private System.Windows.Forms.DateTimePicker dtpFechaAsignacion;
        private System.Windows.Forms.CheckBox chkRuat;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblComprobante;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtComprobante;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.CheckBox chkPago;
        private System.Windows.Forms.Panel pnlAviso;
        private System.Windows.Forms.Panel pnlBordeAviso;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Panel pnlSeparador;
        private System.Windows.Forms.Panel pnlLista;
        private System.Windows.Forms.Label lblEncabezadoLista;
        private System.Windows.Forms.DataGridView dgvPlacas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChasis;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPago;
        private System.Windows.Forms.ErrorProvider epValidacion;
        private System.Windows.Forms.ToolStripButton btnSalir;
    }
}