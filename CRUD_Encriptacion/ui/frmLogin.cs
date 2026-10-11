using System;
using System.Windows.Forms;
using CRUD_Encriptacion.dataBase;

namespace CRUD_Encriptacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 1. Capturar los datos eliminando espacios en blanco al inicio o final
            string usuario = txtUser.Text.Trim();
            string password = txtPassword.Text.Trim();

            // 2. Validación de llenado requerida por la rúbrica
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, llena todos los campos para ingresar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene el código aquí para no hacer consultas a la base de datos en vano
            }

            // 3. Llamar al backend (Clase Auth) sin mezclar lógica de base de datos en el frontend
            Auth authDB = new Auth();

            // Este método devuelve "Administrador", "Empleado" o null
            string rolUsuario = authDB.ValidarLogin(usuario, password);

            // 4. Evaluar la respuesta del backend
            if (rolUsuario != null)
            {
                MessageBox.Show($"¡Bienvenido! Has ingresado con el rol de: {rolUsuario}.", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 5. Abrir el menú principal y pasarle el rol. 
                // (Asumo que crearás un formulario llamado frmMenu)
                frmMenu ventanaPrincipal = new frmMenu(rolUsuario);
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
    }
}
