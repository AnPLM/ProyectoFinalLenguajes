using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class DAOAdminListaPedido
    {
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conn);

        public List<TOAtributosDetallePedido> seleccionarPorCliente(TOAdminListaPedido toAdmin)
        {
            try
            {

                String consulta = "select * from (select lo.Identificador as ID_Orden, lo.Nombre_Usuario, p.nombre, lo.cantidad, " +
                "lo.estado, lo.fecha from plato p, (select o.Identificador, l.cantidad, o.Nombre_Usuario,  " + 
                "o.estado, o.fecha, l.Codigo_Plato from lista_Pedido l, orden o where " + 
                "l.Identificador_Orden=o.Identificador) lo where p.Codigo = lo.codigo_plato) " + 
                "as d where nombre_usuario = @cl";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@cl", toAdmin.Cliente);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                SqlDataReader lector = comando.ExecuteReader();

                List<TOAtributosDetallePedido> listaPedidos = new List<TOAtributosDetallePedido>();
                TOAtributosDetallePedido atributo;
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        atributo = new TOAtributosDetallePedido();
                        atributo.IDORden = int.Parse(lector["ID_Orden"].ToString());
                        atributo.NombreUsuario = lector["Nombre_Usuario"].ToString();
                        atributo.NombrePlato = lector["Nombre"].ToString();
                        atributo.Cantidad = int.Parse(lector["Cantidad"].ToString());
                        atributo.Estado = lector["Estado"].ToString();
                        atributo.Fecha = lector["Fecha"].ToString();

                        listaPedidos.Add(atributo);
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

        public List<TOAtributosDetallePedido> seleccionarPorFecha(TOAdminListaPedido toAdmin) {
            try
            {

                String consulta = "select * from (select lo.Identificador as ID_Orden, lo.Nombre_Usuario, p.nombre, lo.cantidad, " + 
                    "lo.estado, lo.fecha from plato p, (select o.Identificador, l.cantidad, o.Nombre_Usuario,  " + 
                    "o.estado, o.fecha, l.Codigo_Plato from lista_Pedido l, orden o where " + 
                    "l.Identificador_Orden=o.Identificador) lo where p.Codigo = lo.codigo_plato) " +
                    "as d where d.fecha between CAST(@fi AS datetime) and CAST(@ff AS datetime);";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@fi", toAdmin.FechaInicio);
                comando.Parameters.AddWithValue("@ff", toAdmin.FechaFin);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                SqlDataReader lector = comando.ExecuteReader();

                List<TOAtributosDetallePedido> listaPedidos = new List<TOAtributosDetallePedido>();
                TOAtributosDetallePedido atributo;
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        atributo = new TOAtributosDetallePedido();
                        atributo.IDORden = int.Parse(lector["ID_Orden"].ToString());
                        atributo.NombreUsuario = lector["Nombre_Usuario"].ToString();
                        atributo.NombrePlato = lector["Nombre"].ToString();
                        atributo.Cantidad = int.Parse(lector["Cantidad"].ToString());
                        atributo.Estado = lector["Estado"].ToString();
                        atributo.Fecha = lector["Fecha"].ToString();

                        listaPedidos.Add(atributo);
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

        public List<TOAtributosDetallePedido> seleccionarPorEstado(TOAdminListaPedido toAdmin) {
            try
            {

                String consulta = "select * from (select lo.Identificador as ID_Orden, lo.Nombre_Usuario, p.nombre, lo.cantidad," + 
                    "lo.estado, lo.fecha from plato p, (select o.Identificador, l.cantidad, o.Nombre_Usuario,  " +
                    "o.estado, o.fecha, l.Codigo_Plato from lista_Pedido l, orden o " + 
                    "where l.Identificador_Orden=o.Identificador) lo where p.Codigo = lo.codigo_plato)" + 
                    " as d where estado = @est";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@est", toAdmin.Estado);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                SqlDataReader lector = comando.ExecuteReader();

                List<TOAtributosDetallePedido> listaPedidos = new List<TOAtributosDetallePedido>();
                TOAtributosDetallePedido atributo;
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        atributo = new TOAtributosDetallePedido();
                        atributo.IDORden = int.Parse(lector["ID_Orden"].ToString());
                        atributo.NombreUsuario = lector["Nombre_Usuario"].ToString();
                        atributo.NombrePlato = lector["Nombre"].ToString();
                        atributo.Cantidad = int.Parse(lector["Cantidad"].ToString());
                        atributo.Estado = lector["Estado"].ToString();
                        atributo.Fecha = lector["Fecha"].ToString();

                        listaPedidos.Add(atributo);
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

        public List<TOAtributosDetallePedido> seleccionarPorClienteFechaEstado(TOAdminListaPedido toAdmin) {
            try
            {

                String consulta = "select * from (select lo.Identificador as ID_Orden, lo.Nombre_Usuario, p.nombre, lo.cantidad," +
                    "lo.estado, lo.fecha from plato p, (select o.Identificador, l.cantidad, o.Nombre_Usuario,  " +
                    "o.estado, o.fecha, l.Codigo_Plato from lista_Pedido l, orden o " +
                    "where l.Identificador_Orden=o.Identificador) lo where p.Codigo = lo.codigo_plato)" +
                    " as d where (d.estado = @est) and (d.nombre_usuario = @cl) and " +
                    "d.fecha between CAST(@fi AS datetime) and CAST(@ff AS datetime)";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@cl", toAdmin.Cliente);
                comando.Parameters.AddWithValue("@fi", toAdmin.FechaInicio);
                comando.Parameters.AddWithValue("@ff", toAdmin.FechaFin);
                comando.Parameters.AddWithValue("@est", toAdmin.Estado);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                SqlDataReader lector = comando.ExecuteReader();

                List<TOAtributosDetallePedido> listaPedidos = new List<TOAtributosDetallePedido>();
                TOAtributosDetallePedido atributo;
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        atributo = new TOAtributosDetallePedido();
                        atributo.IDORden = int.Parse(lector["ID_Orden"].ToString());
                        atributo.NombreUsuario = lector["Nombre_Usuario"].ToString();
                        atributo.NombrePlato = lector["Nombre"].ToString();
                        atributo.Cantidad = int.Parse(lector["Cantidad"].ToString());
                        atributo.Estado = lector["Estado"].ToString();
                        atributo.Fecha = lector["Fecha"].ToString();

                        listaPedidos.Add(atributo);
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

        public List<TOAtributosDetallePedido> seleccionarPorClienteFecha(TOAdminListaPedido toAdmin)
        {
            try
            {

                String consulta = "select * from (select lo.Identificador as ID_Orden, lo.Nombre_Usuario, p.nombre, lo.cantidad," +
                    "lo.estado, lo.fecha from plato p, (select o.Identificador, l.cantidad, o.Nombre_Usuario,  " +
                    "o.estado, o.fecha, l.Codigo_Plato from lista_Pedido l, orden o " +
                    "where l.Identificador_Orden=o.Identificador) lo where p.Codigo = lo.codigo_plato)" +
                    " as d where (d.nombre_usuario = @cl) and " +
                    "d.fecha between CAST(@fi AS datetime) and CAST(@ff AS datetime)";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@cl", toAdmin.Cliente);
                comando.Parameters.AddWithValue("@fi", toAdmin.FechaInicio);
                comando.Parameters.AddWithValue("@ff", toAdmin.FechaFin);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                SqlDataReader lector = comando.ExecuteReader();

                List<TOAtributosDetallePedido> listaPedidos = new List<TOAtributosDetallePedido>();
                TOAtributosDetallePedido atributo;
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        atributo = new TOAtributosDetallePedido();
                        atributo.IDORden = int.Parse(lector["ID_Orden"].ToString());
                        atributo.NombreUsuario = lector["Nombre_Usuario"].ToString();
                        atributo.NombrePlato = lector["Nombre"].ToString();
                        atributo.Cantidad = int.Parse(lector["Cantidad"].ToString());
                        atributo.Estado = lector["Estado"].ToString();
                        atributo.Fecha = lector["Fecha"].ToString();

                        listaPedidos.Add(atributo);
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

        public List<TOAtributosDetallePedido> seleccionarPorClienteEstado(TOAdminListaPedido toAdmin) {
            try
            {

                String consulta = "select * from (select lo.Identificador as ID_Orden, lo.Nombre_Usuario, p.nombre, lo.cantidad," +
                    "lo.estado, lo.fecha from plato p, (select o.Identificador, l.cantidad, o.Nombre_Usuario,  " +
                    "o.estado, o.fecha, l.Codigo_Plato from lista_Pedido l, orden o " +
                    "where l.Identificador_Orden=o.Identificador) lo where p.Codigo = lo.codigo_plato)" +
                    " as d where (d.estado = @est) and (d.nombre_usuario = @cl)";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@cl", toAdmin.Cliente);
                comando.Parameters.AddWithValue("@est", toAdmin.Estado);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                SqlDataReader lector = comando.ExecuteReader();

                List<TOAtributosDetallePedido> listaPedidos = new List<TOAtributosDetallePedido>();
                TOAtributosDetallePedido atributo;
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        atributo = new TOAtributosDetallePedido();
                        atributo.IDORden = int.Parse(lector["ID_Orden"].ToString());
                        atributo.NombreUsuario = lector["Nombre_Usuario"].ToString();
                        atributo.NombrePlato = lector["Nombre"].ToString();
                        atributo.Cantidad = int.Parse(lector["Cantidad"].ToString());
                        atributo.Estado = lector["Estado"].ToString();
                        atributo.Fecha = lector["Fecha"].ToString();

                        listaPedidos.Add(atributo);
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

        public List<TOAtributosDetallePedido> seleccionarPorFechaEstado(TOAdminListaPedido toAdmin) {
            try
            {

                String consulta = "select * from (select lo.identificador as ID_Orden, lo.Nombre_Usuario, p.nombre, lo.cantidad," +
                    "lo.estado, lo.fecha from plato p, (select o.identificador, l.cantidad, o.Nombre_Usuario,  " +
                    "o.estado, o.fecha, l.Codigo_Plato from lista_Pedido l, orden o " +
                    "where l.Identificador_Orden=o.Identificador) lo where p.Codigo = lo.codigo_plato)" +
                    " as d where (d.estado = @est) and " +
                    "d.fecha between CAST(@fi AS datetime) and CAST(@ff AS datetime)";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@fi", toAdmin.FechaInicio);
                comando.Parameters.AddWithValue("@ff", toAdmin.FechaFin);
                comando.Parameters.AddWithValue("@est", toAdmin.Estado);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                SqlDataReader lector = comando.ExecuteReader();

                List<TOAtributosDetallePedido> listaPedidos = new List<TOAtributosDetallePedido>();
                TOAtributosDetallePedido atributo;
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        atributo = new TOAtributosDetallePedido();
                        atributo.IDORden = int.Parse(lector["ID_Orden"].ToString());
                        atributo.NombreUsuario = lector["Nombre_Usuario"].ToString();
                        atributo.NombrePlato = lector["Nombre"].ToString();
                        atributo.Cantidad = int.Parse(lector["Cantidad"].ToString());
                        atributo.Estado = lector["Estado"].ToString();
                        atributo.Fecha = lector["Fecha"].ToString();

                        listaPedidos.Add(atributo);
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
