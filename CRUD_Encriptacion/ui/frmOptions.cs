using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CRUD_Encriptacion
{
    public partial class frmOptions : Form
    {
        //Variable global para guardar el rol
        private string rolActual;
        public frmOptions(string rol)
        {
            InitializeComponent();
            rolActual = rol;
        }

        private void btnSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin frm=new frmLogin();
            frm.Show();
            this.Hide();
        }
    }
}
