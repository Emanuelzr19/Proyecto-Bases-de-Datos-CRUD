using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace CRUD_Encriptacion.dataBase
{
    public class EmpleadoDAO
    {
        private readonly Conexion _conexion = new Conexion();

        public bool Insertar(Empleado empleado)
        {
            using (MySqlConnection conn = _conexion.ObtenerConexion())
            {
                string query = @"INSERT INTO Empleados 
                                (Username, Password, Rol, Nombre, Apellidos, Email, Telefono, 
                                 Direccion, Ciudad, Estado, FechaNacimiento, Puesto, 
                                 Salario, NumeroSeguroSocial, CuentaBancaria) 
                                VALUES 
                                (@Username, @Password, @Rol, @Nombre, @Apellidos, @Email, @Telefono, 
                                 @Direccion, @Ciudad, @Estado, @FechaNacimiento, @Puesto, 
                                 @Salario, @NumeroSeguroSocial, @CuentaBancaria)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    string passwordHash = BCrypt.Net.BCrypt.HashPassword(empleado.Password);

                    cmd.Parameters.AddWithValue("@Username", empleado.Username);
                    cmd.Parameters.AddWithValue("@Password", passwordHash);
                    cmd.Parameters.AddWithValue("@Rol", empleado.Rol);
                    cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                    cmd.Parameters.AddWithValue("@Apellidos", empleado.Apellidos);
                    cmd.Parameters.AddWithValue("@Email", empleado.Email);
                    cmd.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                    cmd.Parameters.AddWithValue("@Direccion", empleado.Direccion);
                    cmd.Parameters.AddWithValue("@Ciudad", empleado.Ciudad);
                    cmd.Parameters.AddWithValue("@Estado", empleado.Estado);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", empleado.FechaNacimiento.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Puesto", empleado.Puesto);
                    cmd.Parameters.AddWithValue("@Salario", empleado.Salario);
                    cmd.Parameters.AddWithValue("@NumeroSeguroSocial", empleado.NumeroSeguroSocial);
                    cmd.Parameters.AddWithValue("@CuentaBancaria", empleado.CuentaBancaria);

                    try
                    {
                        conn.Open();
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error al insertar: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public List<Empleado> ObtenerTodos()
        {
            List<Empleado> lista = new List<Empleado>();

            using (MySqlConnection conn = _conexion.ObtenerConexion())
            {
                string query = "SELECT * FROM Empleados";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Empleado emp = new Empleado
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Username = reader["Username"].ToString(),
                                    Rol = reader["Rol"].ToString(),
                                    Nombre = reader["Nombre"].ToString(),
                                    Apellidos = reader["Apellidos"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    Telefono = reader["Telefono"].ToString(),
                                    Direccion = reader["Direccion"].ToString(),
                                    Ciudad = reader["Ciudad"].ToString(),
                                    Estado = reader["Estado"].ToString(),
                                    FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]),
                                    Puesto = reader["Puesto"].ToString(),
                                    Salario = (byte[])reader["Salario"],
                                    NumeroSeguroSocial = (byte[])reader["NumeroSeguroSocial"],
                                    CuentaBancaria = (byte[])reader["CuentaBancaria"]
                                };
                                lista.Add(emp);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error al leer: " + ex.Message);
                    }
                }
            }
            return lista;
        }

        public bool Actualizar(Empleado empleado)
        {
            using (MySqlConnection conn = _conexion.ObtenerConexion())
            {
                string query = @"UPDATE Empleados SET 
                                Username=@Username, Rol=@Rol, Nombre=@Nombre, Apellidos=@Apellidos, 
                                Email=@Email, Telefono=@Telefono, Direccion=@Direccion, Ciudad=@Ciudad, 
                                Estado=@Estado, FechaNacimiento=@FechaNacimiento, Puesto=@Puesto, 
                                Salario=@Salario, NumeroSeguroSocial=@NumeroSeguroSocial, CuentaBancaria=@CuentaBancaria 
                                WHERE Id=@Id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", empleado.Id);
                    cmd.Parameters.AddWithValue("@Username", empleado.Username);
                    cmd.Parameters.AddWithValue("@Rol", empleado.Rol);
                    cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                    cmd.Parameters.AddWithValue("@Apellidos", empleado.Apellidos);
                    cmd.Parameters.AddWithValue("@Email", empleado.Email);
                    cmd.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                    cmd.Parameters.AddWithValue("@Direccion", empleado.Direccion);
                    cmd.Parameters.AddWithValue("@Ciudad", empleado.Ciudad);
                    cmd.Parameters.AddWithValue("@Estado", empleado.Estado);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", empleado.FechaNacimiento.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Puesto", empleado.Puesto);
                    cmd.Parameters.AddWithValue("@Salario", empleado.Salario);
                    cmd.Parameters.AddWithValue("@NumeroSeguroSocial", empleado.NumeroSeguroSocial);
                    cmd.Parameters.AddWithValue("@CuentaBancaria", empleado.CuentaBancaria);

                    try
                    {
                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error al actualizar: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public bool Eliminar(int id)
        {
            using (MySqlConnection conn = _conexion.ObtenerConexion())
            {
                string query = "DELETE FROM Empleados WHERE Id = @Id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    try
                    {
                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error al eliminar: " + ex.Message);
                        return false;
                    }
                }
            }
        }
    }
}