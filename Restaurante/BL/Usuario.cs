using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using TO;

namespace BL
{
    public class Usuario
    {
        public String NombreUsuario;
        public String Contrasenna;
        public String TipoUsuario;
        public Boolean Habilitado;

        public Usuario() {  }

        public Usuario(String nombreUsuario, String contrasenna, String tipo, Boolean habilitado)
        {
            this.NombreUsuario = nombreUsuario;
            this.Contrasenna = contrasenna;
            this.TipoUsuario = tipo;
            this.Habilitado = habilitado;
        }

        private DAOUsuario dao = new DAOUsuario();

        public void agregarUsuario(TOUsuario usuario) {
            dao.agregarUsuario(usuario);
        }
        public void eliminarUsuario(TOUsuario usuario) {
            dao.eliminarUsuario(usuario);
        }
        public void modificarUsuario(TOUsuario usuario) {
            dao.modificarUsuario(usuario);
        }
        public Boolean autenticarUsuario(TOUsuario usuario) {
            return dao.autenticacionUsuario(usuario);
        }

    }
}
