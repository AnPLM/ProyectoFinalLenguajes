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
            String consulta = "INSERT INTO PLATO(Nombre, Descripcion, Precio, Fotografia, Habilitado) VALUES (@nom, @des, @pre, @fot, @hab)";
            SqlCommand sentencia = new SqlCommand(consulta, conexion);
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
            String consulta = "Select * From Plato Where Nombre = @nom" ;
            SqlCommand sentencia = new SqlCommand(consulta, conexion);
            sentencia.Parameters.AddWithValue("@nom", plato.Nombre);

            int identificador = 0;
            String nombre = "" ;
            String descripcion = "";
            Double precio = 0;
            String fotografia = "";
            int habilitado = 0;

            SqlDataReader lector;
           
            abrirConexion();
            lector = sentencia.ExecuteReader();

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    identificador = Int32.Parse(lector.GetValue(0).ToString());
                    nombre = lector.GetValue(1).ToString();
                    descripcion = lector.GetValue(2).ToString();
                    precio = Double.Parse(lector.GetValue(3).ToString());
                    fotografia = lector.GetValue(4).ToString();
                    habilitado = Int32.Parse(lector.GetValue(5).ToString());
                }
            }
            cerrarConexion();
            return new TOPlato(identificador ,nombre, descripcion, precio, fotografia, habilitado);
        }

        public void eleminarPlato(TOPlato plato)
        {
            String consulta = "DELETE FROM PLATO WHERE Nombre = @nom";
            SqlCommand sentencia = new SqlCommand(consulta, conexion);
            sentencia.Parameters.AddWithValue("@nom", plato.Nombre);
            abrirConexion();
            sentencia.ExecuteNonQuery();
            cerrarConexion();
        }

        public void modificarPlato(TOPlato plato)
        {
            String consulta = "UPDATE Plato set Nombre = @nom, Descripcion = @des, Precio = @pre, Fotografia = @fot, Habilitado = @hab ";
            SqlCommand sentencia = new SqlCommand(consulta, conexion);
            sentencia.Parameters.AddWithValue("@nom", plato.Nombre);
            sentencia.Parameters.AddWithValue("@des", plato.Descripcion);
            sentencia.Parameters.AddWithValue("@pre", plato.Precio);
            sentencia.Parameters.AddWithValue("@fot", plato.Fotografia);
            sentencia.Parameters.AddWithValue("@hab", plato.Habilitado);
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
                lista.Add(new TOPlato(contador, row["Nombre"].ToString(), row["Descripcion"].ToString(),
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
