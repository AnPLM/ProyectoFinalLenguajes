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

        private DAOListaPedido daoListaPedidos;

        public ManejadorListaPedido() {
            daoListaPedidos = new DAOListaPedido();
        }

        public List<BLListaPedido> obtenerPedidosPorUsuario(String nombre_usuario)
        {
            List<TOListaPedidos> listaTO = daoListaPedidos.obtenerPedidosPorUsuario(nombre_usuario);
            List<BLListaPedido> listaBL = new List<BLListaPedido>();
            foreach (TOListaPedidos item in listaTO)
            {
                listaBL.Add(new BLListaPedido(item.Nombre_Usuario, item.Identificador_Plato));
            }
            return listaBL;
        }
    }
}
