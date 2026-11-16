namespace CapaPresentacion
{
    partial class FrmTransito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransito));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsAcciones = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbLimpiar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.txtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.pnlPasos = new System.Windows.Forms.Panel();
            this.lblPaso1 = new System.Windows.Forms.Label();
            this.lblPaso2 = new System.Windows.Forms.Label();
            this.lblPaso3 = new System.Windows.Forms.Label();
            this.lblPaso4 = new System.Windows.Forms.Label();
            this.lblPaso5 = new System.Windows.Forms.Label();
            this.pnlBordePasos = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pnlCuerpo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlLista = new System.Windows.Forms.Panel();
            this.dgvPlacas = new System.Windows.Forms.DataGridView();
            this.colChasis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInforme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRetorno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnvioTransito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEncabezadoLista = new System.Windows.Forms.Label();
            this.pnlSeparador = new System.Windows.Forms.Panel();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.btnEnviarTransito = new System.Windows.Forms.Button();
            this.pnlAviso = new System.Windows.Forms.Panel();
            this.lblAviso = new System.Windows.Forms.Label();
            this.pnlBordeAviso = new System.Windows.Forms.Panel();
            this.tlpCampos = new System.Windows.Forms.TableLayoutPanel();
            this.txtComprobantePago = new System.Windows.Forms.TextBox();
            this.txtChasis = new System.Windows.Forms.TextBox();
            this.txtNroInforme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblChasis = new System.Windows.Forms.Label();
            this.lblFechaEnvio = new System.Windows.Forms.Label();
            this.lblFechaAsignacion = new System.Windows.Forms.Label();
            this.txtContado = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblModalidad = new System.Windows.Forms.Label();
            this.dtpFechaRetorno = new System.Windows.Forms.DateTimePicker();
            this.lblComprobante = new System.Windows.Forms.Label();
            this.txtFechaEnvioTransito = new System.Windows.Forms.TextBox();
            this.lblEncabezadoDatos = new System.Windows.Forms.Label();
            this.tsAcciones.SuspendLayout();
            this.pnlPasos.SuspendLayout();
            this.pnlCuerpo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlacas)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.pnlAviso.SuspendLayout();
            this.tlpCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsAcciones
            // 
            this.tsAcciones.AutoSize = false;
            this.tsAcciones.BackColor = System.Drawing.Color.White;
            this.tsAcciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsAcciones.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsAcciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbGuardar,
            this.tsbModificar,
            this.tsbEliminar,
            this.tsbLimpiar,
            this.btnSalir,
            this.tsbCerrar,
            this.toolStripSeparator1,
            this.tsbBuscar,
            this.txtBuscar});
            this.tsAcciones.Location = new System.Drawing.Point(0, 0);
            this.tsAcciones.Name = "tsAcciones";
            this.tsAcciones.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tsAcciones.Size = new System.Drawing.Size(1060, 44);
            this.tsAcciones.TabIndex = 1;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(80, 40);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.ToolTipText = "Nuevo";
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(90, 40);
            this.tsbGuardar.Text = "Guardar";
            // 
            // tsbModificar
            // 
            this.tsbModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsbModificar.Image")));
            this.tsbModificar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(101, 40);
            this.tsbModificar.Text = "Modificar";
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(91, 40);
            this.tsbEliminar.Text = "Eliminar";
            // 
            // tsbLimpiar
            // 
            this.tsbLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("tsbLimpiar.Image")));
            this.tsbLimpiar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tsbLimpiar.Name = "tsbLimpiar";
            this.tsbLimpiar.Size = new System.Drawing.Size(87, 40);
            this.tsbLimpiar.Text = "Limpiar";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(66, 41);
            this.btnSalir.Text = "Salir";
            // 
            // tsbCerrar
            // 
            this.tsbCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCerrar.Image")));
            this.tsbCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrar.Name = "tsbCerrar";
            this.tsbCerrar.Size = new System.Drawing.Size(53, 41);
            this.tsbCerrar.Text = "Cerrar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscar.Image")));
            this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(56, 41);
            this.tsbBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtBuscar.AutoSize = false;
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(167)))), ((int)(((byte)(182)))));
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(220, 29);
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
            this.pnlPasos.Location = new System.Drawing.Point(0, 44);
            this.pnlPasos.Name = "pnlPasos";
            this.pnlPasos.Size = new System.Drawing.Size(1060, 44);
            this.pnlPasos.TabIndex = 2;
            // 
            // lblPaso1
            // 
            this.lblPaso1.AutoSize = true;
            this.lblPaso1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(167)))), ((int)(((byte)(182)))));
            this.lblPaso1.Location = new System.Drawing.Point(190, 14);
            this.lblPaso1.Name = "lblPaso1";
            this.lblPaso1.Size = new System.Drawing.Size(147, 20);
            this.lblPaso1.TabIndex = 1;
            this.lblPaso1.Text = "① Recepción   ─────";
            // 
            // lblPaso2
            // 
            this.lblPaso2.AutoSize = true;
            this.lblPaso2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(167)))), ((int)(((byte)(182)))));
            this.lblPaso2.Location = new System.Drawing.Point(335, 14);
            this.lblPaso2.Name = "lblPaso2";
            this.lblPaso2.Size = new System.Drawing.Size(144, 20);
            this.lblPaso2.TabIndex = 2;
            this.lblPaso2.Text = "② Despacho   ─────";
            // 
            // lblPaso3
            // 
            this.lblPaso3.AutoSize = true;
            this.lblPaso3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaso3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(167)))), ((int)(((byte)(182)))));
            this.lblPaso3.Location = new System.Drawing.Point(480, 14);
            this.lblPaso3.Name = "lblPaso3";
            this.lblPaso3.Size = new System.Drawing.Size(173, 20);
            this.lblPaso3.TabIndex = 3;
            this.lblPaso3.Text = "③ Placas y Pagos   ─────";
            // 
            // lblPaso4
            // 
            this.lblPaso4.AutoSize = true;
            this.lblPaso4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaso4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(193)))), ((int)(((byte)(227)))));
            this.lblPaso4.Location = new System.Drawing.Point(665, 14);
            this.lblPaso4.Name = "lblPaso4";
            this.lblPaso4.Size = new System.Drawing.Size(141, 20);
            this.lblPaso4.TabIndex = 4;
            this.lblPaso4.Text = "④ Tránsito   ─────";
            // 
            // lblPaso5
            // 
            this.lblPaso5.AutoSize = true;
            this.lblPaso5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(167)))), ((int)(((byte)(182)))));
            this.lblPaso5.Location = new System.Drawing.Point(795, 14);
            this.lblPaso5.Name = "lblPaso5";
            this.lblPaso5.Size = new System.Drawing.Size(77, 20);
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 158);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.Controls.Add(this.panel1);
            this.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCuerpo.Location = new System.Drawing.Point(0, 0);
            this.pnlCuerpo.Name = "pnlCuerpo";
            this.pnlCuerpo.Padding = new System.Windows.Forms.Padding(12);
            this.pnlCuerpo.Size = new System.Drawing.Size(1060, 760);
            this.pnlCuerpo.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.pnlLista);
            this.panel1.Controls.Add(this.pnlSeparador);
            this.panel1.Controls.Add(this.pnlDatos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(12);
            this.panel1.Size = new System.Drawing.Size(1036, 666);
            this.panel1.TabIndex = 3;
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
            this.pnlLista.Size = new System.Drawing.Size(660, 642);
            this.pnlLista.TabIndex = 2;
            // 
            // dgvPlacas
            // 
            this.dgvPlacas.AllowUserToAddRows = false;
            this.dgvPlacas.AllowUserToDeleteRows = false;
            this.dgvPlacas.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvPlacas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPlacas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlacas.BackgroundColor = System.Drawing.Color.White;
            this.dgvPlacas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPlacas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlacas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPlacas.ColumnHeadersHeight = 30;
            this.dgvPlacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPlacas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChasis,
            this.colPlaca,
            this.colModalidad,
            this.colInforme,
            this.colRetorno,
            this.colEnvioTransito,
            this.colEstado});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlacas.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPlacas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlacas.EnableHeadersVisualStyles = false;
            this.dgvPlacas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.dgvPlacas.Location = new System.Drawing.Point(0, 30);
            this.dgvPlacas.MultiSelect = false;
            this.dgvPlacas.Name = "dgvPlacas";
            this.dgvPlacas.ReadOnly = true;
            this.dgvPlacas.RowHeadersVisible = false;
            this.dgvPlacas.RowHeadersWidth = 51;
            this.dgvPlacas.RowTemplate.Height = 28;
            this.dgvPlacas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlacas.Size = new System.Drawing.Size(658, 610);
            this.dgvPlacas.TabIndex = 1;
            // 
            // colChasis
            // 
            this.colChasis.FillWeight = 135F;
            this.colChasis.HeaderText = "Chasis";
            this.colChasis.MinimumWidth = 6;
            this.colChasis.Name = "colChasis";
            this.colChasis.ReadOnly = true;
            // 
            // colPlaca
            // 
            this.colPlaca.FillWeight = 155F;
            this.colPlaca.HeaderText = "Placa";
            this.colPlaca.MinimumWidth = 6;
            this.colPlaca.Name = "colPlaca";
            this.colPlaca.ReadOnly = true;
            // 
            // colModalidad
            // 
            this.colModalidad.FillWeight = 75F;
            this.colModalidad.HeaderText = "Modalidad";
            this.colModalidad.MinimumWidth = 6;
            this.colModalidad.Name = "colModalidad";
            this.colModalidad.ReadOnly = true;
            // 
            // colInforme
            // 
            this.colInforme.FillWeight = 70F;
            this.colInforme.HeaderText = "Informe";
            this.colInforme.MinimumWidth = 6;
            this.colInforme.Name = "colInforme";
            this.colInforme.ReadOnly = true;
            // 
            // colRetorno
            // 
            this.colRetorno.FillWeight = 45F;
            this.colRetorno.HeaderText = "Retorno";
            this.colRetorno.MinimumWidth = 6;
            this.colRetorno.Name = "colRetorno";
            this.colRetorno.ReadOnly = true;
            // 
            // colEnvioTransito
            // 
            this.colEnvioTransito.FillWeight = 95F;
            this.colEnvioTransito.HeaderText = "Envío Tránsito";
            this.colEnvioTransito.MinimumWidth = 6;
            this.colEnvioTransito.Name = "colEnvioTransito";
            this.colEnvioTransito.ReadOnly = true;
            // 
            // colEstado
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colEstado.DefaultCellStyle = dataGridViewCellStyle11;
            this.colEstado.FillWeight = 65F;
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 6;
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
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
            this.lblEncabezadoLista.Size = new System.Drawing.Size(658, 30);
            this.lblEncabezadoLista.TabIndex = 0;
            this.lblEncabezadoLista.Text = "Trámites con placa y pago";
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
            this.pnlDatos.Controls.Add(this.btnEnviarTransito);
            this.pnlDatos.Controls.Add(this.pnlAviso);
            this.pnlDatos.Controls.Add(this.tlpCampos);
            this.pnlDatos.Controls.Add(this.lblEncabezadoDatos);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDatos.Location = new System.Drawing.Point(12, 12);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(340, 642);
            this.pnlDatos.TabIndex = 0;
            // 
            // btnEnviarTransito
            // 
            this.btnEnviarTransito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.btnEnviarTransito.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarTransito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(107)))));
            this.btnEnviarTransito.Location = new System.Drawing.Point(12, 413);
            this.btnEnviarTransito.Name = "btnEnviarTransito";
            this.btnEnviarTransito.Size = new System.Drawing.Size(311, 37);
            this.btnEnviarTransito.TabIndex = 3;
            this.btnEnviarTransito.Text = "Enviar a Tránsito";
            this.btnEnviarTransito.UseVisualStyleBackColor = false;
            // 
            // pnlAviso
            // 
            this.pnlAviso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAviso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.pnlAviso.Controls.Add(this.lblAviso);
            this.pnlAviso.Controls.Add(this.pnlBordeAviso);
            this.pnlAviso.Location = new System.Drawing.Point(9, 347);
            this.pnlAviso.Name = "pnlAviso";
            this.pnlAviso.Size = new System.Drawing.Size(314, 55);
            this.pnlAviso.TabIndex = 2;
            // 
            // lblAviso
            // 
            this.lblAviso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lblAviso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblAviso.Location = new System.Drawing.Point(4, 4);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblAviso.Size = new System.Drawing.Size(310, 48);
            this.lblAviso.TabIndex = 1;
            this.lblAviso.Text = "🚫 Sin informe de Diprove y comprobante de pago no se envía a Tránsito";
            this.lblAviso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAviso.Click += new System.EventHandler(this.lblAviso_Click_1);
            // 
            // pnlBordeAviso
            // 
            this.pnlBordeAviso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(168)))), ((int)(((byte)(37)))));
            this.pnlBordeAviso.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBordeAviso.Location = new System.Drawing.Point(0, 0);
            this.pnlBordeAviso.Name = "pnlBordeAviso";
            this.pnlBordeAviso.Size = new System.Drawing.Size(4, 55);
            this.pnlBordeAviso.TabIndex = 0;
            // 
            // tlpCampos
            // 
            this.tlpCampos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCampos.ColumnCount = 2;
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCampos.Controls.Add(this.txtComprobantePago, 1, 7);
            this.tlpCampos.Controls.Add(this.txtChasis, 1, 0);
            this.tlpCampos.Controls.Add(this.txtNroInforme, 0, 5);
            this.tlpCampos.Controls.Add(this.label1, 0, 4);
            this.tlpCampos.Controls.Add(this.lblChasis, 0, 0);
            this.tlpCampos.Controls.Add(this.lblFechaEnvio, 0, 9);
            this.tlpCampos.Controls.Add(this.lblFechaAsignacion, 0, 6);
            this.tlpCampos.Controls.Add(this.txtContado, 1, 3);
            this.tlpCampos.Controls.Add(this.lblPlaca, 0, 2);
            this.tlpCampos.Controls.Add(this.txtPlaca, 0, 3);
            this.tlpCampos.Controls.Add(this.lblModalidad, 1, 2);
            this.tlpCampos.Controls.Add(this.dtpFechaRetorno, 0, 7);
            this.tlpCampos.Controls.Add(this.lblComprobante, 0, 6);
            this.tlpCampos.Controls.Add(this.txtFechaEnvioTransito, 0, 11);
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
            this.tlpCampos.Size = new System.Drawing.Size(314, 278);
            this.tlpCampos.TabIndex = 1;
            // 
            // txtComprobantePago
            // 
            this.txtComprobantePago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtComprobantePago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComprobantePago.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtComprobantePago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(107)))));
            this.txtComprobantePago.Location = new System.Drawing.Point(157, 238);
            this.txtComprobantePago.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.txtComprobantePago.Name = "txtComprobantePago";
            this.txtComprobantePago.ReadOnly = true;
            this.txtComprobantePago.Size = new System.Drawing.Size(157, 30);
            this.txtComprobantePago.TabIndex = 14;
            this.txtComprobantePago.TabStop = false;
            this.txtComprobantePago.Text = "TRX-4800103";
            // 
            // txtChasis
            // 
            this.txtChasis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tlpCampos.SetColumnSpan(this.txtChasis, 2);
            this.txtChasis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtChasis.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtChasis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.txtChasis.Location = new System.Drawing.Point(0, 26);
            this.txtChasis.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.txtChasis.Name = "txtChasis";
            this.txtChasis.Size = new System.Drawing.Size(314, 30);
            this.txtChasis.TabIndex = 13;
            this.txtChasis.Text = "JM7DM2W7AV0700104";
            // 
            // txtNroInforme
            // 
            this.txtNroInforme.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tlpCampos.SetColumnSpan(this.txtNroInforme, 2);
            this.txtNroInforme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNroInforme.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNroInforme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.txtNroInforme.Location = new System.Drawing.Point(0, 154);
            this.txtNroInforme.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.txtNroInforme.Name = "txtNroInforme";
            this.txtNroInforme.Size = new System.Drawing.Size(314, 30);
            this.txtNroInforme.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tlpCampos.SetColumnSpan(this.label1, 2);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.label1.Location = new System.Drawing.Point(0, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "N° informe técnico Diprove";
            // 
            // lblChasis
            // 
            this.lblChasis.AutoSize = true;
            this.tlpCampos.SetColumnSpan(this.lblChasis, 2);
            this.lblChasis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblChasis.Location = new System.Drawing.Point(0, 4);
            this.lblChasis.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.lblChasis.Name = "lblChasis";
            this.lblChasis.Size = new System.Drawing.Size(50, 20);
            this.lblChasis.TabIndex = 0;
            this.lblChasis.Text = "Chasis";
            // 
            // lblFechaEnvio
            // 
            this.lblFechaEnvio.AutoSize = true;
            this.tlpCampos.SetColumnSpan(this.lblFechaEnvio, 2);
            this.lblFechaEnvio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblFechaEnvio.Location = new System.Drawing.Point(0, 280);
            this.lblFechaEnvio.Margin = new System.Windows.Forms.Padding(0, 4, 4, 2);
            this.lblFechaEnvio.Name = "lblFechaEnvio";
            this.lblFechaEnvio.Size = new System.Drawing.Size(176, 20);
            this.lblFechaEnvio.TabIndex = 6;
            this.lblFechaEnvio.Text = "Fecha de envío a Tránsito";
            // 
            // lblFechaAsignacion
            // 
            this.lblFechaAsignacion.AutoSize = true;
            this.lblFechaAsignacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblFechaAsignacion.Location = new System.Drawing.Point(0, 196);
            this.lblFechaAsignacion.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.lblFechaAsignacion.Name = "lblFechaAsignacion";
            this.lblFechaAsignacion.Size = new System.Drawing.Size(146, 40);
            this.lblFechaAsignacion.TabIndex = 5;
            this.lblFechaAsignacion.Text = "Fecha de retorno de Diprove";
            // 
            // txtContado
            // 
            this.txtContado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtContado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtContado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(107)))));
            this.txtContado.Location = new System.Drawing.Point(157, 90);
            this.txtContado.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.txtContado.Name = "txtContado";
            this.txtContado.ReadOnly = true;
            this.txtContado.Size = new System.Drawing.Size(157, 30);
            this.txtContado.TabIndex = 12;
            this.txtContado.TabStop = false;
            this.txtContado.Text = "CONTADO";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblPlaca.Location = new System.Drawing.Point(0, 68);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(44, 20);
            this.lblPlaca.TabIndex = 1;
            this.lblPlaca.Text = "Placa";
            this.lblPlaca.Click += new System.EventHandler(this.lblPlaca_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtPlaca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPlaca.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPlaca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(107)))));
            this.txtPlaca.Location = new System.Drawing.Point(0, 90);
            this.txtPlaca.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.ReadOnly = true;
            this.txtPlaca.Size = new System.Drawing.Size(157, 30);
            this.txtPlaca.TabIndex = 1;
            this.txtPlaca.TabStop = false;
            this.txtPlaca.Text = "6901ABF";
            // 
            // lblModalidad
            // 
            this.lblModalidad.AutoSize = true;
            this.lblModalidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblModalidad.Location = new System.Drawing.Point(157, 68);
            this.lblModalidad.Margin = new System.Windows.Forms.Padding(0, 4, 4, 2);
            this.lblModalidad.Name = "lblModalidad";
            this.lblModalidad.Size = new System.Drawing.Size(82, 20);
            this.lblModalidad.TabIndex = 2;
            this.lblModalidad.Text = "Modalidad";
            // 
            // dtpFechaRetorno
            // 
            this.dtpFechaRetorno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFechaRetorno.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFechaRetorno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRetorno.Location = new System.Drawing.Point(4, 238);
            this.dtpFechaRetorno.Margin = new System.Windows.Forms.Padding(4, 0, 0, 8);
            this.dtpFechaRetorno.Name = "dtpFechaRetorno";
            this.dtpFechaRetorno.Size = new System.Drawing.Size(153, 30);
            this.dtpFechaRetorno.TabIndex = 3;
            // 
            // lblComprobante
            // 
            this.lblComprobante.AutoSize = true;
            this.lblComprobante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.lblComprobante.Location = new System.Drawing.Point(161, 196);
            this.lblComprobante.Margin = new System.Windows.Forms.Padding(4, 4, 0, 2);
            this.lblComprobante.Name = "lblComprobante";
            this.lblComprobante.Size = new System.Drawing.Size(126, 40);
            this.lblComprobante.TabIndex = 3;
            this.lblComprobante.Text = "Comprobante de pago";
            // 
            // txtFechaEnvioTransito
            // 
            this.tlpCampos.SetColumnSpan(this.txtFechaEnvioTransito, 2);
            this.txtFechaEnvioTransito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFechaEnvioTransito.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaEnvioTransito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.txtFechaEnvioTransito.Location = new System.Drawing.Point(3, 305);
            this.txtFechaEnvioTransito.Name = "txtFechaEnvioTransito";
            this.txtFechaEnvioTransito.Size = new System.Drawing.Size(308, 29);
            this.txtFechaEnvioTransito.TabIndex = 15;
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
            this.lblEncabezadoDatos.Text = "Datos — Diprove y Tránsito";
            this.lblEncabezadoDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmTransito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1060, 760);
            this.Controls.Add(this.pnlPasos);
            this.Controls.Add(this.tsAcciones);
            this.Controls.Add(this.pnlCuerpo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "FrmTransito";
            this.Text = "FrmTransito";
            this.tsAcciones.ResumeLayout(false);
            this.tsAcciones.PerformLayout();
            this.pnlPasos.ResumeLayout(false);
            this.pnlPasos.PerformLayout();
            this.pnlCuerpo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlacas)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlAviso.ResumeLayout(false);
            this.tlpCampos.ResumeLayout(false);
            this.tlpCampos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsAcciones;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStripButton tsbLimpiar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Panel pnlPasos;
        private System.Windows.Forms.Label lblPaso1;
        private System.Windows.Forms.Label lblPaso2;
        private System.Windows.Forms.Label lblPaso3;
        private System.Windows.Forms.Label lblPaso4;
        private System.Windows.Forms.Label lblPaso5;
        private System.Windows.Forms.Panel pnlBordePasos;
        private System.Windows.Forms.ToolStripButton tsbCerrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.ToolStripTextBox txtBuscar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel pnlCuerpo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlLista;
        private System.Windows.Forms.DataGridView dgvPlacas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChasis;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInforme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRetorno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnvioTransito;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.Label lblEncabezadoLista;
        private System.Windows.Forms.Panel pnlSeparador;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Panel pnlAviso;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Panel pnlBordeAviso;
        private System.Windows.Forms.TableLayoutPanel tlpCampos;
        private System.Windows.Forms.Label lblChasis;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblModalidad;
        private System.Windows.Forms.Label lblComprobante;
        private System.Windows.Forms.DateTimePicker dtpFechaRetorno;
        private System.Windows.Forms.Label lblFechaAsignacion;
        private System.Windows.Forms.Label lblFechaEnvio;
        private System.Windows.Forms.Label lblEncabezadoDatos;
        private System.Windows.Forms.TextBox txtContado;
        private System.Windows.Forms.TextBox txtNroInforme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComprobantePago;
        private System.Windows.Forms.TextBox txtChasis;
        private System.Windows.Forms.TextBox txtFechaEnvioTransito;
        private System.Windows.Forms.Button btnEnviarTransito;
    }
}