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
        public Cliente(String nombre, String correo, String nombreUsuario, String contrasenna, int habilitado, String direccion)
        {
            this.Nombre = nombre;
            this.Correo = correo;
            this.NombreUsuario = nombreUsuario;
            this.Contrasenna = contrasenna;
            this.Habilitado = habilitado;
            this.Direccion = direccion;
        }

        public String Nombre { get; set; }
        public String Correo { get; set; }
        public String NombreUsuario { get; set; }
        public String Contrasenna { get; set; }
        public int Habilitado { get; set; }
        public String Direccion { get; set; }

    }
}
