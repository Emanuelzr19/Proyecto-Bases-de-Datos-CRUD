using CRUD_Encriptacion.dataBase;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace CRUD_Encriptacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 1. Generamos un hash con tu propia librería
            /*string hashPerfecto = BCrypt.Net.BCrypt.HashPassword("admin123");

            // 2. Lo copiamos automáticamente a tu portapapeles (Ctrl+C automático)
            Clipboard.SetText(hashPerfecto);

            // 3. Mostramos un aviso y detenemos el código
            MessageBox.Show("El Hash compatible ha sido copiado a tu portapapeles. Pégalo en tu base de datos.");
            return;*/


            //CODIGO NORMAL
            // 1. Capturar los datos eliminando espacios en blanco al inicio o final
            string usuario = txtUser.Text.Trim();
            string password = txtPassword.Text.Trim();

            // 2. Validación del llenado de los espacios requeridos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, llena todos los campos para ingresar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene el código aquí para no hacer consultas a la base de datos 
            }

            // 3. Llamar al backend (Clase Auth) 
            Auth authDB = new Auth();

            // Este método devuelve "Administrador", "Empleado" o null
            string rolUsuario = authDB.ValidarLogin(usuario, password);

            // 4. Evaluar la respuesta del backend
            if (rolUsuario != null)
            {
                MessageBox.Show($"¡Bienvenido! Has ingresado con el rol de: {rolUsuario}.", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 5. Abrir el menú principal y pasarle el rol. 
                frmOptions ventanaPrincipal = new frmOptions(rolUsuario);
                ventanaPrincipal.Show();

                // 6. Ocultar la ventana actual (Login)
                this.Hide();
            }
            else
            {
                // Si devuelve null, significa que falló el usuario o la contraseña
                MessageBox.Show("Usuario o contraseña incorrectos. Intenta de nuevo.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASEÑA")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.ForeColor = Color.DimGray;
                this.BeginInvoke((MethodInvoker)delegate
                {
                    txtPassword.UseSystemPasswordChar = false;
                });
            }
        }

        private async void btnCerrar_Click(object sender, EventArgs e)
        {
            while (this.Opacity > 0.0)
            {
                await Task.Delay(10);
                this.Opacity -= 0.25;
            }
            Application.Exit();
        }

        private async void btnMinimizar_Click(object sender, EventArgs e)
        {
            while (this.Opacity > 0.0)
            {
                await Task.Delay(10);
                this.Opacity -= 0.25;
            }
            this.WindowState = FormWindowState.Minimized;
            this.Opacity = 1.0;
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

