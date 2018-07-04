using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TO;
using DAO;

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
        public Cliente(String nombre, String correo, String nombreUsuario, 
            String contrasenna, Boolean habilitado, String direccion)
        {
            this.Nombre = nombre;
            this.Correo = correo;
            this.NombreUsuario = nombreUsuario;
            this.Contrasenna = contrasenna;
            this.Habilitado = habilitado;
            this.Direccion = direccion;
        }
        public Cliente(String nombre, String nombreUsuario)
        {
            this.Nombre = nombre;
            this.NombreUsuario = nombreUsuario;
        }
        public void agregarCliente() {
            DAOCliente daoCliente = new DAOCliente();
            daoCliente.insertarCliente(new TOCliente(this.Nombre, this.Correo,
                this.NombreUsuario, this.Contrasenna, this.Habilitado, this.Direccion));
        }
        public void habilitarCliente(String nombreUsuario) {
            this.NombreUsuario = nombreUsuario;
            DAOCliente daoCliente = new DAOCliente();
            TOCliente toCliente = new TOCliente();
            toCliente.NombreUsuario = this.NombreUsuario;
            daoCliente.habilitarCliente(toCliente);
        }
        public void deshabilitarCliente(String nombreUsuario) {
            this.NombreUsuario = nombreUsuario;
            DAOCliente daoCliente = new DAOCliente();
            TOCliente toCliente = new TOCliente();
            toCliente.NombreUsuario = this.NombreUsuario;
            daoCliente.deshabilitarCliente(toCliente);
        }

        public void actualizarDatosCliente(String nombreUsuario, String direccion, String nombre, 
            String contrasenna)
        {
            this.NombreUsuario = nombreUsuario;
            this.Nombre = nombre;
            this.Contrasenna = contrasenna;
            this.Direccion = direccion;

            TOCliente clienteTo = new TOCliente();
            clienteTo.Nombre = this.Nombre;
            clienteTo.NombreUsuario = this.NombreUsuario;
            clienteTo.Direccion = this.Direccion;
            clienteTo.Contrasenna = this.Contrasenna;

            DAOCliente daoCliente = new DAOCliente();
            daoCliente.actualizarDatosCliente(clienteTo);
        }

        public void autenticarCliente()
        {
            TOCliente cliente = new TOCliente(this.Correo, this.Contrasenna);
            DAOCliente daoCliente = new DAOCliente();
            daoCliente.autenticacionCliente(cliente);
            this.NombreUsuario = cliente.NombreUsuario;
            this.Direccion = cliente.Direccion;
            this.Nombre = cliente.Nombre;
            this.Habilitado = cliente.Habilitado;
        }

    }
}
