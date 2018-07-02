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
        public String Nombre_Usuario { get; set; }
        public int Identificador_Plato { get; set; }

        private SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conn);
        private String consulta;
        private SqlCommand comando = new SqlCommand();
        
        public DAOListaPedido(String nombre_usuario, int identificador_plato)
        {
            Nombre_Usuario = nombre_usuario;
            Identificador_Plato = identificador_plato;
        }

        public DAOListaPedido()
        {}

        public void insertarListaProducto(String nombre_usuario, int identificador_plato)
        {
            try
            {
            consulta = "INSERT INTO LISTA_PEDIDO VALUES(@nombre, @plato)";
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@nombre", nombre_usuario);
            comando.Parameters.AddWithValue("@plato", identificador_plato);
            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }
            comando.Connection = conexion;
            comando.ExecuteNonQuery();
               
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

        public void eliminarPlato(String nombre_usuario, int identificador_plato)
        {
            try
            {
                consulta = "DELETE FROM LISTA_PEDIDO WHERE Nombre_Usuario=@nombre and Identificador_Plato=@plato";
                comando.CommandText = consulta;

                comando.Parameters.AddWithValue("@nombre", nombre_usuario);
                comando.Parameters.AddWithValue("@plato", identificador_plato);
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

        public void eliminarPedidoUsuario(String nombre_usuario)
        {
            try
            {
                consulta = "DELETE FROM LISTA_PEDIDO WHERE Nombre_Usuario=@nombre";
                comando.CommandText = consulta;
                comando.Parameters.AddWithValue("@nombre", nombre_usuario);
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
                        listaPedidos.Add(new TOListaPedidos(lector["Nombre_Usuario"].ToString(), int.Parse(lector["Identificador_Plato"].ToString())));
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


        public List<TOListaPedidos> obtenerPedidosPorUsuario(String nombre_usuario)
        {
            try
            {
                comando.Connection = conexion;
                consulta = "SELECT * FROM LISTA_PEDIDO WHERE Nombre_Usuario=@nombre";
                comando.CommandText = consulta;
                comando.Parameters.AddWithValue("@nombre", nombre_usuario);

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
                        listaPedidos.Add(new TOListaPedidos(lector["Nombre_Usuario"].ToString(), int.Parse(lector["Identificador_Plato"].ToString())));
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


             public List<TOListaPedidos> obtenerPedidosPorPlato(int identificador_plato)
        {
            try
            {
                comando.Connection = conexion;
                consulta = "SELECT * FROM LISTA_PEDIDO WHERE Identificador_Plato=@plato";
                comando.CommandText = consulta;
                comando.Parameters.AddWithValue("@plato", identificador_plato);

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
                        listaPedidos.Add(new TOListaPedidos(lector["Nombre_Usuario"].ToString(), int.Parse(lector["Identificador_Plato"].ToString())));
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
