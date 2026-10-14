using System;

namespace CRUD_Encriptacion.dataBase
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } 
        public string Rol { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Puesto { get; set; }
        public byte[] Salario { get; set; }
        public byte[] NumeroSeguroSocial { get; set; }
        public byte[] CuentaBancaria { get; set; }
    }
}