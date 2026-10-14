using MySql.Data.MySqlClient; 
using Org.BouncyCastle.Crypto.Generators;
using BCrypt.Net;

namespace CRUD_Encriptacion.dataBase
{
    public class Auth
    {
        private readonly Conexion _conexion = new Conexion();

        public string ValidarLogin(string nombreUsuario, string passwordPlano)
        {
            string hashAlmacenado = null;
            string rolUsuario = null;

            using (MySqlConnection conn = _conexion.ObtenerConexion())
            {
                string query = "SELECT Password, Rol FROM Empleados WHERE Username = @Username";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", nombreUsuario);

                    try
                    {
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                hashAlmacenado = reader["Password"].ToString();
                                rolUsuario = reader["Rol"].ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error SQL: " + ex.Message);
                        return null;
                    }
                }
            }

            if (hashAlmacenado == null) return null;

            bool esValido = BCrypt.Net.BCrypt.Verify(passwordPlano, hashAlmacenado);

            if (esValido) return rolUsuario;

            return null;
        }
    }
}