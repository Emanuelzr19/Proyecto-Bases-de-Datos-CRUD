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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            // 1. Instanciamos tu clase del backend
            EmpleadoCRUD crud = new EmpleadoCRUD();

            // 2. Obtenemos los datos desencriptados y los pegamos en la tabla visual
            dgvUsuarios.DataSource = crud.ObtenerEmpleados();
        }
    }
}
