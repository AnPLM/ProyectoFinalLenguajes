using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using TO;

namespace DAO
{
    public class DaoPlato
    {
        public DaoPlato() { }

        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conn);

        public void insertarPlato(TOPlato plato)
        {
            try
            {
                String consulta = "INSERT INTO PLATO(Codigo, Nombre, Descripcion, Precio, Fotografia, Habilitado) VALUES (@cod, @nom, @des, @pre, @fot, @hab)";
                SqlCommand sentencia = new SqlCommand(consulta, conexion);
                sentencia.Parameters.AddWithValue("@cod", plato.Codigo);
                sentencia.Parameters.AddWithValue("@nom", plato.Nombre);
                sentencia.Parameters.AddWithValue("@des", plato.Descripcion);
                sentencia.Parameters.AddWithValue("@pre", plato.Precio);
                sentencia.Parameters.AddWithValue("@fot", plato.Fotografia);
                sentencia.Parameters.AddWithValue("@hab", plato.Habilitado);

                abrirConexion();
                sentencia.ExecuteNonQuery();
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
                cerrarConexion();
            }

        }

        public TOPlato buscarPlato(TOPlato plato)
        {
            try
            {
            String consulta = "Select * From Plato Where Nombre = @nombre" ;//NO LO CAMBIEN
            SqlCommand sentencia = new SqlCommand(consulta, conexion);
            sentencia.Parameters.AddWithValue("@nombre", plato.Nombre);//NO LO CAMBIEN

            SqlDataReader lector;
            TOPlato platoEncontrado = new TOPlato();
            abrirConexion();
            lector = sentencia.ExecuteReader();

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    platoEncontrado = new TOPlato(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), 
                        lector.GetValue(2).ToString(), Double.Parse(lector.GetValue(3).ToString()),
                        lector.GetValue(4).ToString(), Int32.Parse(lector.GetValue(5).ToString()));
                }
            }
                return platoEncontrado;
            }
            catch (SqlException)
            {
                throw new Exception("¡Error en la base de datos!");
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cerrarConexion();
            }
        }

        public void eleminarPlato(TOPlato plato)
        {
            try
            {
                String consulta = "DELETE FROM PLATO WHERE Codigo = @cod";
            SqlCommand sentencia = new SqlCommand(consulta, conexion);
            sentencia.Parameters.AddWithValue("@cod", plato.Codigo);
            abrirConexion();
            sentencia.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw new Exception("¡Error en la base de datos!");
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cerrarConexion();
            }
        }

        public void modificarPlato(TOPlato plato)
        {
            try
            {
            String consulta;
            SqlCommand sentencia = new SqlCommand();
            abrirConexion();
            if (plato.Nombre != "")
            {
                consulta = "UPDATE Plato set Nombre = @nom WHERE Codigo = @cod";
                sentencia = new SqlCommand(consulta, conexion);
                sentencia.Parameters.AddWithValue("@nom", plato.Nombre);
                sentencia.Parameters.AddWithValue("@cod", plato.Codigo);
                //abrirConexion();
                sentencia.ExecuteNonQuery();
                //cerrarConexion();
            }
            if (plato.Descripcion != "")
            {
                consulta = "UPDATE Plato set Descripcion = @des WHERE Codigo = @cod";
                sentencia = new SqlCommand(consulta, conexion);
                sentencia.Parameters.AddWithValue("@des", plato.Descripcion);
                sentencia.Parameters.AddWithValue("@cod", plato.Codigo);
                //abrirConexion();
                sentencia.ExecuteNonQuery();
                //cerrarConexion();
            }
            if (plato.Precio != 0)
            {
                consulta = "UPDATE Plato set Precio = @pre WHERE Codigo = @cod";
                sentencia = new SqlCommand(consulta, conexion);
                sentencia.Parameters.AddWithValue("@cod", plato.Codigo);
                sentencia.Parameters.AddWithValue("@pre", plato.Precio);
                //abrirConexion();
                sentencia.ExecuteNonQuery();
                //cerrarConexion();
            }
            if (plato.Fotografia != "")
            {
                consulta = "UPDATE Plato set Fotografia = @fot WHERE Codigo = @cod";
                sentencia = new SqlCommand(consulta, conexion);
                sentencia.Parameters.AddWithValue("@fot", plato.Fotografia);
                sentencia.Parameters.AddWithValue("@cod", plato.Codigo);
                //abrirConexion();
                sentencia.ExecuteNonQuery();
                //cerrarConexion();
            }
                if (plato.Habilitado != 5)
                {
                    consulta = "UPDATE Plato set Habilitado = @hab WHERE Codigo = @cod";
                    sentencia = new SqlCommand(consulta, conexion);
                    sentencia.Parameters.AddWithValue("@hab", plato.Habilitado);
                    sentencia.Parameters.AddWithValue("@cod", plato.Codigo);
                    //abrirConexion();
                    sentencia.ExecuteNonQuery();
                    //cerrarConexion();
                }
                
            }
            catch (SqlException)
            {
                throw new Exception("¡Error en la base de datos!");
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cerrarConexion();
            }
        }

        public ArrayList listarPlatos()
        {
            try
            {
                ArrayList lista = new ArrayList();
            DataTable tabla = new DataTable();
            String conuslta = "Select * From Plato";
            SqlCommand sentencia = new SqlCommand(conuslta, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sentencia;
            adapter.Fill(tabla);
            int contador = 1;
            foreach (DataRow row in tabla.Rows)
            {
                lista.Add(new TOPlato(row["Codigo"].ToString(), row["Nombre"].ToString(), row["Descripcion"].ToString(),
                    double.Parse(row["Precio"].ToString()), row["Fotografia"].ToString(), Int32.Parse(row["Habilitado"].ToString())));
                contador++;
            }
            return lista;
            }
            catch (SqlException)
            {
                throw new Exception("¡Error en la base de datos!");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public ArrayList listarPlatosCliente()
        {
            try
            {
                ArrayList lista = new ArrayList();
                DataTable tabla = new DataTable();
                String conuslta = "SELECT * FROM Plato WHERE HABILITADO = 1";
                SqlCommand sentencia = new SqlCommand(conuslta, conexion);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = sentencia;
                adapter.Fill(tabla);
                int contador = 1;
                foreach (DataRow row in tabla.Rows)
                {
                    lista.Add(new TOPlato(row["Codigo"].ToString(), row["Nombre"].ToString(), row["Descripcion"].ToString(),
                        double.Parse(row["Precio"].ToString()), row["Fotografia"].ToString(), Int32.Parse(row["Habilitado"].ToString())));
                    contador++;
                }
                return lista;
            }
            catch (SqlException)
            {
                throw new Exception("¡Error en la base de datos!");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<TOPlato> buscarPlatoAdmin(TOPlato plato)
        {
            try
            {
                List<TOPlato> lista = new List<TOPlato>();
            DataTable tabla = new DataTable();
            String conuslta = "Select * From Plato Where Nombre = @nom";
            SqlCommand sentencia = new SqlCommand(conuslta, conexion);
            sentencia.Parameters.AddWithValue("@nom", plato.Nombre);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sentencia;
            adapter.Fill(tabla);
            foreach (DataRow row in tabla.Rows)
            {
                lista.Add(new TOPlato(row["Codigo"].ToString(), row["Nombre"].ToString(), row["Descripcion"].ToString(),
                    double.Parse(row["Precio"].ToString()), row["Fotografia"].ToString(), Int32.Parse(row["Habilitado"].ToString())));
            }
            return lista;
            }
            catch (SqlException)
            {
                throw new Exception("¡Error en la base de datos!");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void abrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
           
        }
        public void cerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }


    }
}
