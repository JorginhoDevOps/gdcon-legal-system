namespace CapaPresentacion
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pnlMarca = new System.Windows.Forms.Panel();
            this.lblSubtituloMarca = new System.Windows.Forms.Label();
            this.lblSistema = new System.Windows.Forms.Label();
            this.lblGdcon = new System.Windows.Forms.Label();
            this.lblSgtl = new System.Windows.Forms.Label();
            this.pnlLineaMarca = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTituloLogin = new System.Windows.Forms.Label();
            this.lblSubtituloLogin = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lblCaptcha = new System.Windows.Forms.Label();
            this.picCaptcha = new System.Windows.Forms.PictureBox();
            this.txtCaptcha = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnSalirLogin = new System.Windows.Forms.Button();
            this.btnRefrescarCaptcha = new System.Windows.Forms.Button();
            this.pnlMarca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCaptcha)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMarca
            // 
            this.pnlMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.pnlMarca.Controls.Add(this.lblSubtituloMarca);
            this.pnlMarca.Controls.Add(this.lblSistema);
            this.pnlMarca.Controls.Add(this.lblGdcon);
            this.pnlMarca.Controls.Add(this.lblSgtl);
            this.pnlMarca.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMarca.Location = new System.Drawing.Point(0, 0);
            this.pnlMarca.Name = "pnlMarca";
            this.pnlMarca.Size = new System.Drawing.Size(370, 500);
            this.pnlMarca.TabIndex = 0;
            // 
            // lblSubtituloMarca
            // 
            this.lblSubtituloMarca.AutoSize = true;
            this.lblSubtituloMarca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtituloMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(193)))), ((int)(((byte)(227)))));
            this.lblSubtituloMarca.Location = new System.Drawing.Point(54, 307);
            this.lblSubtituloMarca.Name = "lblSubtituloMarca";
            this.lblSubtituloMarca.Size = new System.Drawing.Size(182, 15);
            this.lblSubtituloMarca.TabIndex = 3;
            this.lblSubtituloMarca.Text = "Gestión de trámites para IMCRUZ";
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistema.ForeColor = System.Drawing.Color.White;
            this.lblSistema.Location = new System.Drawing.Point(54, 256);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(249, 19);
            this.lblSistema.TabIndex = 2;
            this.lblSistema.Text = "Sistema de Gestión de Trámites Legales";
            // 
            // lblGdcon
            // 
            this.lblGdcon.AutoSize = true;
            this.lblGdcon.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGdcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(193)))), ((int)(((byte)(227)))));
            this.lblGdcon.Location = new System.Drawing.Point(54, 178);
            this.lblGdcon.Name = "lblGdcon";
            this.lblGdcon.Size = new System.Drawing.Size(155, 51);
            this.lblGdcon.TabIndex = 1;
            this.lblGdcon.Text = "GDCON";
            // 
            // lblSgtl
            // 
            this.lblSgtl.AutoSize = true;
            this.lblSgtl.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSgtl.ForeColor = System.Drawing.Color.White;
            this.lblSgtl.Location = new System.Drawing.Point(54, 100);
            this.lblSgtl.Name = "lblSgtl";
            this.lblSgtl.Size = new System.Drawing.Size(110, 51);
            this.lblSgtl.TabIndex = 0;
            this.lblSgtl.Text = "SGTL";
            // 
            // pnlLineaMarca
            // 
            this.pnlLineaMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(193)))), ((int)(((byte)(227)))));
            this.pnlLineaMarca.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLineaMarca.Location = new System.Drawing.Point(370, 0);
            this.pnlLineaMarca.Name = "pnlLineaMarca";
            this.pnlLineaMarca.Size = new System.Drawing.Size(4, 500);
            this.pnlLineaMarca.TabIndex = 1;
            // 
            // lblTituloLogin
            // 
            this.lblTituloLogin.AutoSize = true;
            this.lblTituloLogin.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblTituloLogin.Location = new System.Drawing.Point(442, 34);
            this.lblTituloLogin.Name = "lblTituloLogin";
            this.lblTituloLogin.Size = new System.Drawing.Size(171, 30);
            this.lblTituloLogin.TabIndex = 2;
            this.lblTituloLogin.Text = "Inicio de sesión";
            // 
            // lblSubtituloLogin
            // 
            this.lblSubtituloLogin.AutoSize = true;
            this.lblSubtituloLogin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtituloLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblSubtituloLogin.Location = new System.Drawing.Point(442, 70);
            this.lblSubtituloLogin.Name = "lblSubtituloLogin";
            this.lblSubtituloLogin.Size = new System.Drawing.Size(239, 17);
            this.lblSubtituloLogin.TabIndex = 3;
            this.lblSubtituloLogin.Text = "Ingrese sus credenciales para continuar";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(442, 106);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(105, 15);
            this.lblCorreo.TabIndex = 4;
            this.lblCorreo.Text = "Correo electrónico";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.txtCorreo.Location = new System.Drawing.Point(442, 126);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(420, 29);
            this.txtCorreo.TabIndex = 5;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(442, 167);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(67, 15);
            this.lblClave.TabIndex = 6;
            this.lblClave.Text = "Contraseña";
            // 
            // txtClave
            // 
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(442, 187);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(420, 29);
            this.txtClave.TabIndex = 7;
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(442, 228);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(24, 15);
            this.lblRol.TabIndex = 8;
            this.lblRol.Text = "Rol";
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Administrador",
            "Operador"});
            this.cmbRol.Location = new System.Drawing.Point(442, 248);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(420, 29);
            this.cmbRol.TabIndex = 9;
            // 
            // lblCaptcha
            // 
            this.lblCaptcha.AutoSize = true;
            this.lblCaptcha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptcha.Location = new System.Drawing.Point(442, 289);
            this.lblCaptcha.Name = "lblCaptcha";
            this.lblCaptcha.Size = new System.Drawing.Size(51, 15);
            this.lblCaptcha.TabIndex = 10;
            this.lblCaptcha.Text = "Captcha";
            // 
            // picCaptcha
            // 
            this.picCaptcha.BackColor = System.Drawing.Color.Gainsboro;
            this.picCaptcha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCaptcha.Location = new System.Drawing.Point(442, 309);
            this.picCaptcha.Name = "picCaptcha";
            this.picCaptcha.Size = new System.Drawing.Size(150, 29);
            this.picCaptcha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCaptcha.TabIndex = 11;
            this.picCaptcha.TabStop = false;
            // 
            // txtCaptcha
            // 
            this.txtCaptcha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCaptcha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCaptcha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaptcha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.txtCaptcha.Location = new System.Drawing.Point(648, 309);
            this.txtCaptcha.MaxLength = 5;
            this.txtCaptcha.Name = "txtCaptcha";
            this.txtCaptcha.Size = new System.Drawing.Size(214, 29);
            this.txtCaptcha.TabIndex = 13;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(193)))), ((int)(((byte)(227)))));
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(442, 356);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(420, 42);
            this.btnIngresar.TabIndex = 14;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnSalirLogin
            // 
            this.btnSalirLogin.BackColor = System.Drawing.Color.White;
            this.btnSalirLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(193)))), ((int)(((byte)(227)))));
            this.btnSalirLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.btnSalirLogin.Location = new System.Drawing.Point(442, 408);
            this.btnSalirLogin.Name = "btnSalirLogin";
            this.btnSalirLogin.Size = new System.Drawing.Size(420, 42);
            this.btnSalirLogin.TabIndex = 15;
            this.btnSalirLogin.Text = "SALIR";
            this.btnSalirLogin.UseVisualStyleBackColor = false;
            this.btnSalirLogin.Click += new System.EventHandler(this.btnSalirLogin_Click);
            // 
            // btnRefrescarCaptcha
            // 
            this.btnRefrescarCaptcha.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRefrescarCaptcha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescarCaptcha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescarCaptcha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(193)))), ((int)(((byte)(227)))));
            this.btnRefrescarCaptcha.Location = new System.Drawing.Point(602, 309);
            this.btnRefrescarCaptcha.Name = "btnRefrescarCaptcha";
            this.btnRefrescarCaptcha.Size = new System.Drawing.Size(36, 29);
            this.btnRefrescarCaptcha.TabIndex = 12;
            this.btnRefrescarCaptcha.Text = "↻";
            this.btnRefrescarCaptcha.UseVisualStyleBackColor = true;
            this.btnRefrescarCaptcha.Click += new System.EventHandler(this.btnRefrescarCaptcha_Click);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(930, 500);
            this.Controls.Add(this.btnRefrescarCaptcha);
            this.Controls.Add(this.btnSalirLogin);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtCaptcha);
            this.Controls.Add(this.picCaptcha);
            this.Controls.Add(this.lblCaptcha);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblSubtituloLogin);
            this.Controls.Add(this.lblTituloLogin);
            this.Controls.Add(this.pnlLineaMarca);
            this.Controls.Add(this.pnlMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGTL · GDCON";
            this.pnlMarca.ResumeLayout(false);
            this.pnlMarca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCaptcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMarca;
        private System.Windows.Forms.FlowLayoutPanel pnlLineaMarca;
        private System.Windows.Forms.Label lblSgtl;
        private System.Windows.Forms.Label lblGdcon;
        private System.Windows.Forms.Label lblSubtituloMarca;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.Label lblTituloLogin;
        private System.Windows.Forms.Label lblSubtituloLogin;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblCaptcha;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.PictureBox picCaptcha;
        private System.Windows.Forms.TextBox txtCaptcha;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnSalirLogin;
        private System.Windows.Forms.Button btnRefrescarCaptcha;
        private System.Windows.Forms.Label lblRol;
    }
}