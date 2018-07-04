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
            cerrarConexion();
        }

        public TOPlato buscarPlato(TOPlato plato)
        {
            String consulta = "Select * From Plato Where Nombre = @nombre" ;//NO LO CAMBIEN
            SqlCommand sentencia = new SqlCommand(consulta, conexion);
            sentencia.Parameters.AddWithValue("@nombre", plato.Nombre);//NO LO CAMBIEN

            //String codigo = "";
            //String nombre = "" ;
            //String descripcion = "";
            //Double precio = 0;
            //String fotografia = "";
            //int habilitado = 0;

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

                    //codigo = lector.GetValue(0).ToString();
                    //nombre = lector.GetValue(1).ToString();
                    //descripcion = lector.GetValue(2).ToString();
                    //precio = Double.Parse(lector.GetValue(3).ToString());
                    //fotografia = lector.GetValue(4).ToString();
                    //habilitado = Int32.Parse(lector.GetValue(5).ToString());
                }
            }
            cerrarConexion();
            return platoEncontrado;
            //return new TOPlato(codigo ,nombre, descripcion, precio, fotografia, habilitado);
        }

        public void eleminarPlato(TOPlato plato)
        {
            String consulta = "DELETE FROM PLATO WHERE Codigo = @cod";
            SqlCommand sentencia = new SqlCommand(consulta, conexion);
            sentencia.Parameters.AddWithValue("@cod", plato.Codigo);
            abrirConexion();
            sentencia.ExecuteNonQuery();
            cerrarConexion();
        }

        public void modificarPlato(TOPlato plato)
        {
            String consulta;
            SqlCommand sentencia = new SqlCommand();
            if (plato.Nombre != null)
            {
                consulta = "UPDATE Plato set Nombre = @nom WHERE Codigo = @cod";
                sentencia = new SqlCommand(consulta, conexion);
                sentencia.Parameters.AddWithValue("@nom", plato.Nombre);
                sentencia.Parameters.AddWithValue("@cod", plato.Codigo);
                abrirConexion();
                sentencia.ExecuteNonQuery();
                cerrarConexion();
            }
            if (plato.Descripcion != null)
            {
                consulta = "UPDATE Plato set Descripcion = @des WHERE Codigo = @cod";
                sentencia = new SqlCommand(consulta, conexion);
                sentencia.Parameters.AddWithValue("@des", plato.Descripcion);
                sentencia.Parameters.AddWithValue("@cod", plato.Codigo);
                abrirConexion();
                sentencia.ExecuteNonQuery();
                cerrarConexion();
            }
            if (plato.Precio != 0)
            {
                consulta = "UPDATE Plato set Precio = @pre WHERE Codigo = @cod";
                sentencia = new SqlCommand(consulta, conexion);
                sentencia.Parameters.AddWithValue("@cod", plato.Codigo);
                sentencia.Parameters.AddWithValue("@pre", plato.Precio);
                abrirConexion();
                sentencia.ExecuteNonQuery();
                cerrarConexion();
            }
            if (plato.Fotografia != null)
            {
                consulta = "UPDATE Plato set Fotografia = @fot WHERE Codigo = @cod";
                sentencia = new SqlCommand(consulta, conexion);
                sentencia.Parameters.AddWithValue("@fot", plato.Fotografia);
                sentencia.Parameters.AddWithValue("@cod", plato.Codigo);
                abrirConexion();
                sentencia.ExecuteNonQuery();
                cerrarConexion();
            }
            consulta = "UPDATE Plato set Habilitado = @hab WHERE Codigo = @cod";
            sentencia = new SqlCommand(consulta, conexion);
            sentencia.Parameters.AddWithValue("@hab", plato.Habilitado);
            sentencia.Parameters.AddWithValue("@cod", plato.Codigo);
            abrirConexion();
            sentencia.ExecuteNonQuery();
            cerrarConexion();
        }

        public ArrayList listarPlatos()
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

        public ArrayList listarPlatosCliente()
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
