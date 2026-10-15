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

        public bool EsTelefonoValido(string telefono)
        {
            if (!Regex.IsMatch(telefono, @"^\d{10,}$"))
            {
                MessageBox.Show("El teléfono debe contener al menos 10 dígitos numéricos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public bool EsNSSValido(string nss)
        {
            if (!Regex.IsMatch(nss, @"^\d{11}$"))
            {
                MessageBox.Show("El NSS debe contener exactamente 11 dígitos numéricos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public bool EsCuentaBancariaValida(string cuenta)
        {
            if (!Regex.IsMatch(cuenta, @"^\d{10,18}$"))
            {
                MessageBox.Show("La cuenta bancaria debe tener entre 10 y 18 dígitos numéricos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public bool EsSalarioValido(string salario)
        {
            if (!Regex.IsMatch(salario, @"^\d{1,8}(\.\d{1,2})?$"))
            {
                MessageBox.Show("El salario debe ser un número válido, máximo 8 enteros y 2 decimales (separado por punto).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}