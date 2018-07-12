using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using DAO;

namespace BL
{[Serializable]
    public class ClienteSerializable
    {
        public String Nombre { get; set; }
        public String Correo { get; set; }
        public String NombreUsuario { get; set; }
        public String Contrasenna { get; set; }
        public Boolean Habilitado { get; set; }
        public String Direccion { get; set; }
        public ClienteSerializable()
        {
        }

        public ClienteSerializable(String nombre, String correo, String nombreUsuario,
            String contrasenna, Boolean habilitado, String direccion)
        {
            this.Nombre = nombre;
            this.Correo = correo;
            this.NombreUsuario = nombreUsuario;
            this.Contrasenna = contrasenna;
            this.Habilitado = habilitado;
            this.Direccion = direccion;
        }

        public void habilitarCliente(String nombreUsuario)
        {
            this.NombreUsuario = nombreUsuario;
            DAOCliente daoCliente = new DAOCliente();
            TOCliente toCliente = new TOCliente();
            toCliente.NombreUsuario = this.NombreUsuario;
            daoCliente.habilitarCliente(toCliente);
        }
        public void deshabilitarCliente(String nombreUsuario)
        {
            this.NombreUsuario = nombreUsuario;
            DAOCliente daoCliente = new DAOCliente();
            TOCliente toCliente = new TOCliente();
            toCliente.NombreUsuario = this.NombreUsuario;
            daoCliente.deshabilitarCliente(toCliente);
        }


        public ClienteSerializable buscarCliente(String nombreUsuario)
        {
            TOCliente tocliente = new TOCliente();
            tocliente.NombreUsuario = nombreUsuario;
            DAOCliente dao = new DAOCliente();
            dao.buscarCliente(tocliente);
            this.Contrasenna = tocliente.Contrasenna;
            this.Correo = tocliente.Correo;
            this.Direccion = tocliente.Direccion;
            this.Habilitado = tocliente.Habilitado;
            this.Nombre = tocliente.Nombre;
            this.NombreUsuario = tocliente.NombreUsuario;
            return new ClienteSerializable(tocliente.Nombre, tocliente.Correo,
                tocliente.NombreUsuario, tocliente.Contrasenna,
                tocliente.Habilitado, tocliente.Direccion);
        }
    }
}
