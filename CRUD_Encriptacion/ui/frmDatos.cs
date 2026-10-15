using CRUD_Encriptacion.dataBase;
using CRUD_Encriptacion.logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CRUD_Encriptacion.ui
{
    public partial class frmDatos : Form
    {
        private Empleado _empleadoEnEdicion;
        public frmDatos()
        {
            InitializeComponent();
        }
        public frmDatos(Empleado empleado)
        {
            InitializeComponent();

            _empleadoEnEdicion = empleado;

            AESCryptography aes = new AESCryptography();

            txtUsuario.Text = empleado.Username;
            cmbRol.Text = empleado.Rol;
            txtNombre.Text = empleado.Nombre;
            txtApellidos.Text = empleado.Apellidos;
            txtEmail.Text = empleado.Email;
            txtTelefono.Text = empleado.Telefono;
            txtDireccion.Text = empleado.Direccion;
            txtCiudad.Text = empleado.Ciudad;
            txtEstado.Text = empleado.Estado;
            txtFechaNacimiento.Text = empleado.FechaNacimiento.ToString("dd/MM/yyyy");
            txtPuesto.Text = empleado.Puesto;

            txtSalario.Text = aes.Desencriptar(empleado.Salario);
            txtNSS.Text = aes.Desencriptar(empleado.NumeroSeguroSocial);
            txtCuentaBancaria.Text = aes.Desencriptar(empleado.CuentaBancaria);

            btnRegistrar.Text = "Actualizar";
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Validaciones validador = new Validaciones();

            bool camposLlenos = validador.SonCamposValidos(
                txtUsuario, txtContrasena, cmbRol, txtNombre, txtApellidos, txtEmail,
                txtTelefono, txtDireccion, txtCiudad, txtEstado, txtFechaNacimiento,
                txtPuesto, txtSalario, txtNSS, txtCuentaBancaria);

            if (!camposLlenos || !validador.EsEmailValido(txtEmail.Text) || !validador.EsFechaValida(txtFechaNacimiento.Text))
            {
                return;
            }

            AESCryptography aes = new AESCryptography();

            Empleado nuevoEmpleado = new Empleado
            {
                Username = txtUsuario.Text,
                Password = txtContrasena.Text,
                Rol = cmbRol.Text,
                Nombre = txtNombre.Text,
                Apellidos = txtApellidos.Text,
                Email = txtEmail.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text,
                Ciudad = txtCiudad.Text,
                Estado = txtEstado.Text,
                FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text),
                Puesto = txtPuesto.Text,
                Salario = aes.Encriptar(txtSalario.Text),
                NumeroSeguroSocial = aes.Encriptar(txtNSS.Text),
                CuentaBancaria = aes.Encriptar(txtCuentaBancaria.Text)
            };

            EmpleadoDAO dao = new EmpleadoDAO();
            if (dao.Insertar(nuevoEmpleado))
            {
                MessageBox.Show("Usuario registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    
    }
}
