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

        public void insertar(String nombre_usuario, String identificador_plato)
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

        public void eliminarPlato(String nombre_usuario, String identificador_plato)
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

        public void eliminarPedidoUsuario(String nombre_usuario, String identificador_plato)
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

        public List<TOListaPedidos> obtenerPedidos()
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

        public List<TOListaPedidos> obtenerPedidosPorUsuario(String nombre_usuario)
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

        public List<TOListaPedidos> obtenerPedidosPorPlato(String identificador_plato)
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
