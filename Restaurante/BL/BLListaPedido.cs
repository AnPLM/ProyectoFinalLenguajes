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

        public String Nombre_Usuario { get; set; }
        public int Identificador_Plato { get; set; }

        public BLListaPedido(String nombre_usuario, int identificador_plato)
        {
            Nombre_Usuario = nombre_usuario;
            Identificador_Plato = identificador_plato;
        }

        public BLListaPedido()
        { }

        public void insertarListaPedido(String nombre_usuario, String identificador_plato)
        {
            try
            {
                daoLista.insertarListaProducto(nombre_usuario, int.Parse(identificador_plato));
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
                daoLista.eliminarPlato(nombre_usuario, int.Parse(identificador_plato));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void eliminarListaPedidoUsuario(String nombre_usuario)
        {
            try
            {
                daoLista.eliminarPedidoUsuario(nombre_usuario);
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

        public List<TOListaPedidos> obtenerListaPedidosPorUsuario(String nombre_usuario)
        {
            try
            {
                return daoLista.obtenerPedidosPorUsuario(nombre_usuario);
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
                return daoLista.obtenerPedidosPorPlato(int.Parse(identificador_plato));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
