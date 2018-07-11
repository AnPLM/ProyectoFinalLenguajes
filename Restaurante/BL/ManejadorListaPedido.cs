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

        public void insertarListaPedido(String codigoPlato, String identificadorOrden, int cantidad)
        {
            try
            {
                listaPedido.insertarListaPedido(codigoPlato, identificadorOrden, cantidad);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void eliminarPlatoListaPedidos(String codigoPlato, String identificadorOrden)
        {
            try
            {
                listaPedido.eliminarPlatoListaPedidos(codigoPlato, identificadorOrden);
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
                listaBL.Add(new BLListaPedido(item.Codigo_Plato, 
                    item.Identificador_Orden, item.Cantidad_Plato));
            }
            return listaBL;
        }

        public List<BLListaPedido> obtenerListaPedidosPorPlato(String identificador_plato)
        {
            List<TOListaPedidos> listaTO = listaPedido.obtenerListaPedidosPorPlato(identificador_plato);
            List<BLListaPedido> listaBL = new List<BLListaPedido>();
            foreach (TOListaPedidos item in listaTO)
            {
                listaBL.Add(new BLListaPedido(item.Codigo_Plato, item.Identificador_Orden, 
                    item.Cantidad_Plato));
            }
            return listaBL;
        }

    }
}
