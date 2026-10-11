using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CRUD_Encriptacion
{
    public partial class frmMenu : Form
    {
        // Creamos una variable global en este formulario para guardar el rol
        private string rolActual;
        public frmMenu(string rol)
        {
            InitializeComponent();
            rolActual = rol;
        }
    }
}
