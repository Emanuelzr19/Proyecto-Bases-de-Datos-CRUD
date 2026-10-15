using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CRUD_Encriptacion.dataBase;
using CRUD_Encriptacion.logica;

namespace CRUD_Encriptacion.ui
{
    public partial class frmUsuarios : Form
    {
        private string _rolUsuario;
        private string _accionContexto;
        private List<Empleado> _listaEmpleadosActual;

        public frmUsuarios(string rolUsuario, string accion)
        {
            InitializeComponent();
            _rolUsuario = rolUsuario;
            _accionContexto = accion;
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            ConfigurarInterfaz();
            CargarDatosGrilla();
        }

        private void ConfigurarInterfaz()
        {
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
            dgvUsuarios.ReadOnly = true;

            if (_rolUsuario == "Empleado" || _accionContexto == "Ver")
            {
                lblSeleccionaUsuario.Visible = false;
            }
            else if (_accionContexto == "Eliminar" || _accionContexto == "Actualizar")
            {
                lblSeleccionaUsuario.Visible = true;
            }
        }

        private void CargarDatosGrilla()
        {
            EmpleadoDAO dao = new EmpleadoDAO();
            _listaEmpleadosActual = dao.ObtenerTodos();

            var datosMostrados = _listaEmpleadosActual.Select(emp => new
            {
                emp.Id,
                emp.Username,
                emp.Rol,
                emp.Nombre,
                emp.Apellidos,
                emp.Email,
                emp.Telefono,
                emp.Direccion,
                emp.Ciudad,
                emp.Estado,
                emp.FechaNacimiento,
                emp.Puesto,
                Salario = _rolUsuario == "Administrador" ? ObtenerDatoDesencriptado(emp.Salario) : "********",
                NSS = _rolUsuario == "Administrador" ? ObtenerDatoDesencriptado(emp.NumeroSeguroSocial) : "********",
                CuentaBancaria = _rolUsuario == "Administrador" ? ObtenerDatoDesencriptado(emp.CuentaBancaria) : "********"
            }).ToList();

            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = datosMostrados;
        }

        private string ObtenerDatoDesencriptado(byte[] datoCifrado)
        {
            AESCryptography aes = new AESCryptography();
            return aes.Desencriptar(datoCifrado);
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                int idSeleccionado = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["Id"].Value);

                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    EmpleadoDAO dao = new EmpleadoDAO();
                    if (dao.Eliminar(idSeleccionado))
                    {
                        MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatosGrilla();
                        btnEliminar.Visible = false;
                    }
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                int idSeleccionado = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["Id"].Value);

                Empleado empleadoAEditar = _listaEmpleadosActual.FirstOrDefault(emp => emp.Id == idSeleccionado);

                if (empleadoAEditar != null)
                {
                    frmDatos ventanaEdicion = new frmDatos(empleadoAEditar);
                    ventanaEdicion.ShowDialog();

                    CargarDatosGrilla();
                    btnEditar.Visible = false;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (_rolUsuario == "Administrador")
            {
                frmOptions ventanaAdmin = new frmOptions(_rolUsuario);
                ventanaAdmin.Show();
            }
            else
            {
                frmOptionsUser ventanaEmpleado = new frmOptionsUser(_rolUsuario, "Empleado");
                ventanaEmpleado.Show();
            }
            this.Close();
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                if (_rolUsuario == "Administrador" && _accionContexto == "Eliminar")
                {
                    btnEliminar.Visible = true;
                }
                else if (_rolUsuario == "Administrador" && _accionContexto == "Actualizar")
                {
                    btnEditar.Visible = true;
                }
            }
            else
            {
                btnEliminar.Visible = false;
                btnEditar.Visible = false;
            }
        }
    }
}