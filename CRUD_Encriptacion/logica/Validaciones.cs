using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CRUD_Encriptacion.logica
{
    public class Validaciones
    {
        public bool SonCamposValidos(params Control[] controles)
        {
            foreach (Control control in controles)
            {
                if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("Todos los campos de texto son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (control is ComboBox comboBox && comboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar una opción.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        public bool EsEmailValido(string email)
        {
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, patron))
            {
                MessageBox.Show("El formato del correo electrónico no es válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public bool EsFechaValida(string fechaTexto)
        {
            if (!System.DateTime.TryParse(fechaTexto, out _))
            {
                MessageBox.Show("El formato de la fecha no es válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
