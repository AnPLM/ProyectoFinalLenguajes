using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TO;
using DAO;
using System.Data.SqlClient;

namespace BL
{
    public class BLListaPedido
    {

        DAOListaPedido daoLista = new DAOListaPedido();

        public String CodigoPlato { get; set; }
        public int IdentificadorOrden { get; set; }
        public int Cantidad { get; set; }

        public BLListaPedido(String codigoPlato, int identificadorOrden, int cantidad)
        {
            CodigoPlato = codigoPlato;
            IdentificadorOrden = identificadorOrden;
            Cantidad = cantidad;
        }

        public BLListaPedido()
        { }

        public void insertarListaPedido(String codigoPlato, int identificadorOrden, int cantidad)
        {
            try
            {
                TOListaPedidos toListaPedidos = new TOListaPedidos(codigoPlato, identificadorOrden, cantidad);
                daoLista.insertarListaProducto(toListaPedidos);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void eliminarPlatoListaPedidos(String codigoPlato, int identificadorOrden)
        {
            try
            {
                TOListaPedidos toListaPedido = new TOListaPedidos();
                toListaPedido.Codigo_Plato = codigoPlato;
                toListaPedido.Identificador_Orden = identificadorOrden;
                daoLista.eliminarPlato(toListaPedido);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<TOListaPedidos> obtenerListaPedidos()
        {
            try
            {
                return daoLista.obtenerPedidos();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<TOListaPedidos> obtenerListaPedidosPorPlato(String identificador_plato)
        {
            try
            {
                TOListaPedidos toListaPedidos = new TOListaPedidos();
                toListaPedidos.Codigo_Plato = identificador_plato;
                return daoLista.obtenerPedidosPorPlato(toListaPedidos);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
