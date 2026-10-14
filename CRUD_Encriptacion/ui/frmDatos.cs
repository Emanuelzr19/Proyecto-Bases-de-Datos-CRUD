using CRUD_Encriptacion.dataBase;
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
        public frmDatos()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // 1. Instancias tu clase del backend
            EmpleadoCRUD crud = new EmpleadoCRUD();

            // 2. Llamas al método pasándole lo que el usuario escribió en las cajas de texto
            bool exito = crud.RegistrarEmpleado(
                txtUser.Text,
                txtPassword.Text,
                cmbRol.Text,
                txtNombre.Text,
                txtApellidos.Text,
                txtEmail.Text,
                txtTelefono.Text,
                txtDireccion.Text,
                txtCiudad.Text,
                txtEstado.Text,
                dtpFechaNac.Value,
                txtPuesto.Text,
                txtSalario.Text,
                txtNSS.Text,
                txtCuenta.Text
            );

            // 3. El frontend es quien muestra los mensajes al usuario
            if (exito)
            {
                MessageBox.Show("Empleado registrado y datos encriptados con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Aquí puedes limpiar las cajas de texto
            }
            else
            {
                MessageBox.Show("Ocurrió un error al guardar. Revisa la conexión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDatos_Load(object sender, EventArgs e)
        {

        }
    }
}
