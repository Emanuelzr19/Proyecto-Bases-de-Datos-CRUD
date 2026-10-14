using System;
using MySql.Data.MySqlClient; 

namespace CRUD_Encriptacion.dataBase
{
    public class Conexion
    {

        private readonly string _cadenaConexion = "Server=\"itsur-azure.mysql.database.azure.com\"; port=\"3306\"; UserID=\"Aplicacion\"; Password=\"admin123#\"; Database=\"Empresa\"; SslMode=Required;";

        public MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(_cadenaConexion);
        }
    }
}
