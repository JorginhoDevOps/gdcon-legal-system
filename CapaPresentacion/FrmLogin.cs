using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, string lParam);
        private const int EM_SETCUEBANNER = 0x1501;

        private readonly Usuarios usuarios = new Usuarios();   // CapaNegocio
        private readonly Random azar = new Random();
        private string codigoCaptcha = "";

        public FrmLogin()
        {
            InitializeComponent();
            BarraTitulo.Aplicar(this, Color.FromArgb(244, 247, 250), Color.FromArgb(9, 26, 58));
            this.Load += FrmLogin_Load;
            this.VisibleChanged += FrmLogin_VisibleChanged;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            usuarios.Archivo_VectorUsuarios();   // carga el archivo de texto al vector
            SendMessage(txtCorreo.Handle, EM_SETCUEBANNER, (IntPtr)1, "usuario@empresa.com");
            SendMessage(txtCaptcha.Handle, EM_SETCUEBANNER, (IntPtr)1, "Escriba el código");
            GenerarCaptcha();
        }

        private void FrmLogin_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible && this.IsHandleCreated)
            {
                usuarios.Archivo_VectorUsuarios();
                txtCorreo.Clear();
                txtClave.Clear();
                txtCaptcha.Clear();
                cmbRol.SelectedIndex = -1;
                GenerarCaptcha();
                txtCorreo.Focus();
            }
        }

        // ---------- Captcha ----------
        private void GenerarCaptcha()
        {
            const string letras = "ABCDEFGHJKLMNPQRSTUVWXYZ23456789";  
            char[] c = new char[5];
            for (int i = 0; i < c.Length; i++) c[i] = letras[azar.Next(letras.Length)];
            codigoCaptcha = new string(c);

            Bitmap bmp = new Bitmap(150, 29);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.FromArgb(240, 244, 248));
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = TextRenderingHint.AntiAlias;

                for (int i = 0; i < 6; i++)
                    using (var pen = new Pen(Color.FromArgb(azar.Next(120, 200), azar.Next(100, 200), azar.Next(100, 200)), 1))
                        g.DrawLine(pen, azar.Next(150), azar.Next(29), azar.Next(150), azar.Next(29));
                for (int i = 0; i < 40; i++)
                    bmp.SetPixel(azar.Next(150), azar.Next(29), Color.FromArgb(azar.Next(80, 200), azar.Next(80, 200), azar.Next(80, 200)));

                using (var fuente = new Font("Consolas", 14F, FontStyle.Bold | FontStyle.Italic))
                using (var pincel = new SolidBrush(Color.FromArgb(9, 26, 58)))
                    for (int i = 0; i < c.Length; i++)
                        g.DrawString(c[i].ToString(), fuente, pincel, 10 + i * 26, azar.Next(1, 5));
            }
            if (picCaptcha.Image != null) picCaptcha.Image.Dispose();
            picCaptcha.Image = bmp;
        }

        private void btnRefrescarCaptcha_Click(object sender, EventArgs e)
        {
            GenerarCaptcha();
            txtCaptcha.Clear();
            txtCaptcha.Focus();
        }

        // ---------- Ingreso ----------
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text.Trim();

            if (correo == "" || txtClave.Text == "" || cmbRol.SelectedIndex < 0 || txtCaptcha.Text.Trim() == "")
            {
                Aviso("Complete el correo, la contraseña, el rol y el captcha.");
                return;
            }

            if (!string.Equals(txtCaptcha.Text.Trim(), codigoCaptcha, StringComparison.OrdinalIgnoreCase))
            {
                Aviso("El código del captcha es incorrecto.");
                GenerarCaptcha();
                txtCaptcha.Clear();
                txtCaptcha.Focus();
                return;
            }

            // validación de credenciales
            Usuario u = usuarios.Validar(correo, txtClave.Text, cmbRol.SelectedItem.ToString());
            if (u == null)
            {
                Aviso("Correo, contraseña o rol incorrectos.");
                GenerarCaptcha();
                txtCaptcha.Clear();
                txtClave.Clear();
                txtClave.Focus();
                return;
            }

            FrmMenuPrincipal menu = new FrmMenuPrincipal(u);
            menu.Show();
            this.Hide();
        }

        private void Aviso(string mensaje)
        {
            MessageBox.Show(mensaje, "SGTL · GDCON", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSalirLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
