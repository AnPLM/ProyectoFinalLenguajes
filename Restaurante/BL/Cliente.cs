using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TO;
namespace BL
{
    public class Cliente
    {
        public String Nombre { get; set; }
        public String Correo { get; set; }
        public String NombreUsuario { get; set; }
        public String Contrasenna { get; set; }
        public Boolean Habilitado { get; set; }
        public String Direccion { get; set; }
        public Cliente()
        {
        }
        public Cliente(String nombre, String correo, String nombreUsuario, String contrasenna, Boolean habilitado, String direccion)
        {
            this.Nombre = nombre;
            this.Correo = correo;
            this.NombreUsuario = nombreUsuario;
            this.Contrasenna = contrasenna;
            this.Habilitado = habilitado;
            this.Direccion = direccion;
        }

        

        public void agregarCliente() {
            
        }
        public void modificarCliente() { }
        public void seleccionarCliente() { }
        public void habilitarCliente() { }
        public void deshabilitarCliente() { }

    }
}
