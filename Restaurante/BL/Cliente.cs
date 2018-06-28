using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TO;

namespace BL
{
    public class Cliente
    {
        public Cliente()
        {
        }
        public Cliente(String nombre, String apellidos, int edad, String direccion, String nombreUsuario, String contrasenna, Boolean estadoCuenta)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Edad = edad;
            this.Direccion = direccion;
            this.NombreUsuario = nombreUsuario;
            this.Contrasenna = contrasenna;
            this.EstadoCuenta = estadoCuenta;
        }

        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public int Edad { get; set; }
        public String Direccion { get; set; }
        public String NombreUsuario { get; set; }
        public String Contrasenna { get; set; }
        public Boolean EstadoCuenta { get; set; }

    }
}
