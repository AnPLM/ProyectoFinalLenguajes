using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;


namespace BL
{
    public class ManejadorUsuario
    {

        private Usuario usua = new Usuario();
        public void agregarUsuario(String nombreUsuario, String contrasenna, String tipo, Boolean habilitado)
        {
            usua.agregarUsuario(new TOUsuario(nombreUsuario, contrasenna, tipo, habilitado));
        }

        public void eliminarUsuario(String nombreUsuario)
        {
            TOUsuario toUsuario = new TOUsuario();
            toUsuario.NombreUsuario = nombreUsuario;
            toUsuario.Habilitado = false;
            usua.eliminarUsuario(toUsuario);
        }

        public void actualizarUsuario(String nombreUsuario, String contrasenna, String tipo, Boolean habilitado)
        {
            TOUsuario usarioTO = new TOUsuario(nombreUsuario, contrasenna, tipo, habilitado);
            usua.modificarUsuario(usarioTO);
        }

        public Usuario buscarUsuario(String nombre)
        {
            TOUsuario usuario = new TOUsuario();
            usuario.NombreUsuario = nombre;
            return usua.buscarUsuario(usuario);
        }

        public Usuario autenticar(String nombreUsuario, String contrasenna)
        {
            TOUsuario usuarioTO = new TOUsuario();
            usuarioTO.NombreUsuario = nombreUsuario;
            usuarioTO.Contrasenna = contrasenna;
            if (usua.autenticarUsuario(usuarioTO))
            {
                Usuario usuarioAutenticado = new Usuario(usuarioTO.NombreUsuario, usuarioTO.Contrasenna,
                    usuarioTO.Tipo, usuarioTO.Habilitado);
                return usuarioAutenticado;
            }
                return null;
        }
    }
}
