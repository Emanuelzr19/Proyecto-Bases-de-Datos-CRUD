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

        private string _rolUsuario;
        public frmOptions(string rol)
        {
            InitializeComponent();
            _rolUsuario = rol;
        }

        private void btnSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
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

        private void btnVer_Click(object sender, EventArgs e)
        {
            frmUsuarios ventanaUsuarios = new frmUsuarios(_rolUsuario, "Ver");
            ventanaUsuarios.Show();
            this.Hide();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmDatos ventanaDatos = new frmDatos();
            ventanaDatos.Show();
            this.Hide();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            frmUsuarios ventanaUsuarios = new frmUsuarios(_rolUsuario, "Actualizar");
            ventanaUsuarios.Show();
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmUsuarios ventanaUsuarios = new frmUsuarios(_rolUsuario, "Eliminar");
            ventanaUsuarios.Show();
            this.Hide();
        }
    }
}
