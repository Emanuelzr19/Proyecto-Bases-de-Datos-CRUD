using BCrypt.Net;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace CRUD_Encriptacion.dataBase
{
    public class EmpleadoCRUD
    {
        private readonly Conexion _conexion = new Conexion();

        // Llave secreta de EXACTAMENTE 16 caracteres para que AES_ENCRYPT no lance advertencias
        private readonly string _llaveAES = "ClaveSecreta1234";

        // Método para registrar un nuevo empleado
        public bool RegistrarEmpleado(string user, string passPlana, string rol, string nombre, string apellidos, string email, string tel, string dir, string ciudad, string estado, DateTime fechaNac, string puesto, string salario, string nss, string cuenta)
        {
            // Encriptamos la contraseña con BCrypt antes de enviarla a la base de datos
            string hashPassword = BCrypt.Net.BCrypt.HashPassword(passPlana);

            using (MySqlConnection conn = _conexion.ObtenerConexion())
            {
                // Insertar en mysql
                string query = @"INSERT INTO Empleados 
                    (Username, Password, Rol, Nombre, Apellidos, Email, Telefono, Direccion, Ciudad, Estado, FechaNacimiento, Puesto, Salario, NumeroSeguroSocial, CuentaBancaria) 
                    VALUES 
                    (@User, @Pass, @Rol, @Nom, @Ape, @Email, @Tel, @Dir, @Ciu, @Est, @Fecha, @Puesto, 
                    AES_ENCRYPT(@Salario, @Llave), 
                    AES_ENCRYPT(@NSS, @Llave), 
                    AES_ENCRYPT(@Cuenta, @Llave))";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Datos generales
                    cmd.Parameters.AddWithValue("@User", user);
                    cmd.Parameters.AddWithValue("@Pass", hashPassword); // Pasamos el hash, no la contraseña plana
                    cmd.Parameters.AddWithValue("@Rol", rol);
                    cmd.Parameters.AddWithValue("@Nom", nombre);
                    cmd.Parameters.AddWithValue("@Ape", apellidos);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Tel", tel);
                    cmd.Parameters.AddWithValue("@Dir", dir);
                    cmd.Parameters.AddWithValue("@Ciu", ciudad);
                    cmd.Parameters.AddWithValue("@Est", estado);
                    cmd.Parameters.AddWithValue("@Fecha", fechaNac);
                    cmd.Parameters.AddWithValue("@Puesto", puesto);

                    // Datos sensibles y la llave de encriptación
                    cmd.Parameters.AddWithValue("@Salario", salario);
                    cmd.Parameters.AddWithValue("@NSS", nss);
                    cmd.Parameters.AddWithValue("@Cuenta", cuenta);
                    cmd.Parameters.AddWithValue("@Llave", _llaveAES);

                    try
                    {
                        conn.Open();
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        // Si filasAfectadas es mayor a 0, se insertó correctamente
                        return filasAfectadas > 0;
                    }
                    catch (Exception ex)
                    {
                        // Escribimos el error en consola 
                        System.Diagnostics.Debug.WriteLine("Error al insertar: " + ex.Message);
                        return false;
                    }
                }
            }
        }


        public DataTable ObtenerEmpleados()
        {
            DataTable tablaEmpleados = new DataTable();

            using (MySqlConnection conn = _conexion.ObtenerConexion())
            {
                // Usamos CAST(AES_DECRYPT(columna, llave) AS CHAR) para convertir el BLOB en texto legible
                string query = @"SELECT 
            Id, Username, Rol, Nombre, Apellidos, Puesto, Email, Telefono,
            CAST(AES_DECRYPT(Salario, @Llave) AS CHAR) AS Salario_Real,
            CAST(AES_DECRYPT(NumeroSeguroSocial, @Llave) AS CHAR) AS NSS_Real,
            CAST(AES_DECRYPT(CuentaBancaria, @Llave) AS CHAR) AS CuentaBancaria_Real
            FROM Empleados";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Usamos exactamente la misma llave secreta que declaraste arriba para insertar
                    cmd.Parameters.AddWithValue("@Llave", _llaveAES);

                    try
                    {
                        conn.Open();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            // Llenamos la tabla con los resultados desencriptados
                            adapter.Fill(tablaEmpleados);
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine("Error al leer empleados: " + ex.Message);
                    }
                }
            }

            return tablaEmpleados; // Devolvemos la tabla completa al frontend
        }

    }
}