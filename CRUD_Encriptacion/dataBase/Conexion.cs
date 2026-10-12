using System;
using MySql.Data.MySqlClient; // servidor de azure

namespace CRUD_Encriptacion.dataBase
{
    public class Conexion
    {
        // Reemplaza con los datos de tu Azure MySQL Flexible Server.
        // SslMode=Required es obligatorio en Azure para que viaje encriptado.
        private readonly string _cadenaConexion = "Server=\"itsur-azure.mysql.database.azure.com\"; port=\"3306\"; UserID=\"Aplicacion\"; Password=\"admin123#\"; Database=\"Empresa\"; SslMode=Required;";
        // Devolvemos un MySqlConnection en lugar de SqlConnection
        public MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(_cadenaConexion);
        }
    }
}
