using CRUD_Encriptacion.ui;
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
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmDatos ventanaAgregar = new frmDatos();

            this.Hide(); // Oculta el menú actual
            ventanaAgregar.ShowDialog(); // Muestra la ventana de datos
            this.Show(); // Vuelve a mostrar el menú 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            frmUsuarios ventana = new frmUsuarios();

            this.Hide(); // Oculta el menú actual
            ventana.ShowDialog(); // Muestra la ventana de datos
            this.Show(); // Vuelve a mostrar el menú 
        }
    }
}
