using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CRUD_Encriptacion.ui
{
    public partial class frmOptionsUser : Form
    {
        private string _rolUsuario;
        private string _nombreUsuario;
        public frmOptionsUser(string rolUsuario, string nombreUsuario)
        {
            InitializeComponent();
            _rolUsuario = rolUsuario;
            _nombreUsuario = nombreUsuario;
            lblSaludo.Text = "Hola, " + _nombreUsuario;
        }

        private void btnSalir_Click(object sender, EventArgs e)
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
    }
}
