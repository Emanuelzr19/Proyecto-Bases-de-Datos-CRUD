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
        private string _rolUsuario;
        private string _accionContexto;

        public frmUsuarios(string rolUsuario, string accion)
        {
            InitializeComponent();
            _rolUsuario = rolUsuario;
            _accionContexto = accion;
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            // Aquí puedes usar if/switch para cambiar el diseño según de dónde vengan
            if (_accionContexto == "Ver")
            {
                // Lógica para solo mostrar datos
                // Ejemplo: Si _rolUsuario == "Empleado", ocultar campos sensibles
            }
            else if (_accionContexto == "Actualizar")
            {
                // Lógica para habilitar edición
            }
            else if (_accionContexto == "Eliminar")
            {
                // Lógica para habilitar botones de borrado
            }
        }
    }
}
