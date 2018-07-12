using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using TO;

namespace DAO
{
    public class DAOListaPedido
    {
        private SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conn);
        private String consulta;
        private SqlCommand comando = new SqlCommand();

        public DAOListaPedido()
        {}

        public void insertarListaProducto(TOListaPedidos toListaPedidos)
        {
            try
            {
            consulta = "INSERT INTO LISTA_PEDIDO VALUES(@plato, @identificador, @cant)";

            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@plato", toListaPedidos.Codigo_Plato);
            comando.Parameters.AddWithValue("@identificador", toListaPedidos.Identificador_Orden);
            comando.Parameters.AddWithValue("@cant", toListaPedidos.Cantidad_Plato);
                if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }
            comando.Connection = conexion;
            comando.ExecuteNonQuery();

            comando.Parameters.RemoveAt("@plato");
            comando.Parameters.RemoveAt("@identificador");
            comando.Parameters.RemoveAt("@cant");

            }
            catch (SqlException)
            {
                throw new Exception("¡Error en la base de datos!");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
            if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
        }

        public void eliminarPlato(TOListaPedidos toListaPedidos)
        {
            try
            {
                consulta = "DELETE FROM LISTA_PEDIDO WHERE Nombre_Usuario=@nombre and Identificador_=@plato";
                comando.CommandText = consulta;

                comando.Parameters.AddWithValue("@nombre", toListaPedidos.Identificador_Orden);
                comando.Parameters.AddWithValue("@plato", toListaPedidos.Codigo_Plato);
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                comando.Connection = conexion;
                comando.ExecuteNonQuery();
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
            catch (SqlException)
            {
                throw new Exception("¡Error en la base de datos!");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
        }

        public List<TOListaPedidos> obtenerPedidos()
        {
            try
            {
                comando.Connection = conexion;
                consulta = "SELECT * FROM LISTA_PEDIDO";
                comando.CommandText = consulta;

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                SqlDataReader lector = comando.ExecuteReader();

                List<TOListaPedidos> listaPedidos = new List<TOListaPedidos>();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        listaPedidos.Add(
                            new TOListaPedidos(lector["Nombre_Usuario"].ToString(),
                            lector["Identificador_Plato"].ToString(),
                            int.Parse(lector["Cantidad"].ToString())));
                    }
                }

                return listaPedidos;
            }
            catch (SqlException)
            {
                throw new Exception("¡Error en la base de datos!");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
        }

        public List<TOListaPedidos> obtenerPedidosPorPlato(TOListaPedidos toListaPedidos)
        {
            try
            {
                comando.Connection = conexion;
                consulta = "SELECT * FROM LISTA_PEDIDO WHERE Codigo_Plato=@plato";
                comando.CommandText = consulta;
                comando.Parameters.AddWithValue("@plato", toListaPedidos.Codigo_Plato);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                SqlDataReader lector = comando.ExecuteReader();

                List<TOListaPedidos> listaPedidos = new List<TOListaPedidos>();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        listaPedidos.Add(
                            new TOListaPedidos(lector["Nombre_Usuario"].ToString(), 
                            lector["Identificador_Plato"].ToString(),
                            int.Parse(lector["Cantidad"].ToString())));
                    }
                }

                return listaPedidos;
            }
            catch (SqlException)
            {
                throw new Exception("¡Error en la base de datos!");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
        }

    }
}
