using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using TO;

namespace BL
{
    public class ManejadorListaPedido
    {

        private BLListaPedido listaPedido;

        public ManejadorListaPedido() {
            listaPedido = new BLListaPedido();
        }

        public void insertarListaPedido(String nombre_usuario, String identificador_plato)
        {
            try
            {
                listaPedido.insertarListaPedido(nombre_usuario, identificador_plato);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void eliminarPlatoListaPedidos(String nombre_usuario, String identificador_plato)
        {
            try
            {
                listaPedido.eliminarPlatoListaPedidos(nombre_usuario, identificador_plato);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void eliminarListaPedidoUsuario(String nombre_usuario, String identificador_plato)
        {
            try
            {
                listaPedido.eliminarListaPedidoUsuario(nombre_usuario);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<BLListaPedido> obtenerListaPedidos()
        {
            List<TOListaPedidos> listaTO = listaPedido.obtenerListaPedidos();
            List<BLListaPedido> listaBL = new List<BLListaPedido>();
            foreach (TOListaPedidos item in listaTO)
            {
                listaBL.Add(new BLListaPedido(item.Nombre_Usuario, item.Identificador_Plato));
            }
            return listaBL;
        }

        public List<BLListaPedido> obtenerListaPedidosPorUsuario(String nombre_usuario)
        {
            List<TOListaPedidos> listaTO = listaPedido.obtenerListaPedidosPorUsuario(nombre_usuario);
            List<BLListaPedido> listaBL = new List<BLListaPedido>();
            foreach (TOListaPedidos item in listaTO)
            {
                listaBL.Add(new BLListaPedido(item.Nombre_Usuario, item.Identificador_Plato));
            }
            return listaBL;
        }

        public List<BLListaPedido> obtenerListaPedidosPorPlato(String identificador_plato)
        {
            List<TOListaPedidos> listaTO = listaPedido.obtenerListaPedidosPorPlato(identificador_plato);
            List<BLListaPedido> listaBL = new List<BLListaPedido>();
            foreach (TOListaPedidos item in listaTO)
            {
                listaBL.Add(new BLListaPedido(item.Nombre_Usuario, item.Identificador_Plato));
            }
            return listaBL;
        }

    }
}
