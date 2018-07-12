using Microsoft.VisualBasic;
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
    public class DaoOrden
    {

        private string Nombre_Usuario { set; get; }
        private String Fecha { set; get; }
        private string Estado { set; get; }
        private int Identificador { set; get; }


        public DaoOrden() { }

        public DaoOrden(String nombre, string fecha, string estado, int identificador)
        {
            this.Nombre_Usuario = nombre;
            this.Fecha = fecha;
            this.Estado = estado;
            this.Identificador = identificador;
        }

        public int insertar(TOOrden o)
        {
            String query = "Insert INTO Orden(Nombre_Usuario, Estado) values(@nom, @est);";
            string conn = Properties.Settings.Default.Conn;
            SqlCommand command = new SqlCommand(query, new SqlConnection(conn));
            try
            {
                command.Parameters.AddWithValue("@nom", o.Nombre_Usuario);
               // command.Parameters.AddWithValue("@fec", o.Fecha);
                command.Parameters.AddWithValue("@est", o.Estado);
                //command.Parameters.AddWithValue("@ide", o.Identificador);
                if (command.Connection.State == ConnectionState.Closed) { command.Connection.Open(); }
                command.ExecuteNonQuery();

                query = "SELECT IDENT_CURRENT('Orden')";
                conn = Properties.Settings.Default.Conn;
                command = new SqlCommand(query, new SqlConnection(conn));

                    if (command.Connection.State != ConnectionState.Open) { command.Connection.Open(); }
                    Object a = command.ExecuteScalar();
                    String b = a.ToString();
                    int secuencial = int.Parse(b);
                if (command.Connection.State == ConnectionState.Open) { command.Connection.Close(); }
                return secuencial;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { if (command.Connection.State == ConnectionState.Open) { command.Connection.Close(); } }
        }

        public void eliminar(int id)
        {
            string query = "delete from Orden where Identificador = @id";
            string conn = Properties.Settings.Default.Conn;
            SqlCommand command = new SqlCommand(query, new SqlConnection(conn));
            try
            {
                command.Parameters.AddWithValue("@id", id);
                if (command.Connection.State == ConnectionState.Closed) { command.Connection.Open(); }
                command.ExecuteNonQuery();
                if (command.Connection.State == ConnectionState.Open) { command.Connection.Close(); }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { if (command.Connection.State == ConnectionState.Open) { command.Connection.Close(); } }
        }

        public void actualizar(TOOrden o)
        {
            string query = "update Orden set Estado = @est where Identificador = @ide";
            //string query = "update Orden set Nombre_Usuario = @nom, Fecha = @fec, Estado = @est where Identificacion = @ide";
            string conn = Properties.Settings.Default.Conn;
            SqlCommand command = new SqlCommand(query, new SqlConnection(conn));
            try
            {
                //command.Parameters.AddWithValue("@nom", o.Nombre_Usuario);
               // command.Parameters.AddWithValue("@fec", o.Fecha);
                command.Parameters.AddWithValue("@est", o.Estado);
                command.Parameters.AddWithValue("@ide", o.Identificador);
                if (command.Connection.State == ConnectionState.Closed) { command.Connection.Open(); }
                command.ExecuteNonQuery();
                if (command.Connection.State == ConnectionState.Open) { command.Connection.Close(); }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { if (command.Connection.State == ConnectionState.Open) { command.Connection.Close(); } }
        }

        public TOOrden Buscar(int identificador)
        {
            string query = "select * from Orden where Identificador = @ide";
            string conn = Properties.Settings.Default.Conn;
            SqlCommand command = new SqlCommand(query, new SqlConnection(conn));
            TOOrden o;
            try
            {
                command.Parameters.AddWithValue("@ide", identificador);
                if (command.Connection.State == ConnectionState.Closed) { command.Connection.Open(); }
                SqlDataReader data = command.ExecuteReader();
                string nombre = data.GetValue(0).ToString();
                String fecha = data.GetValue(1).ToString();
                //DateTimeOffset f = new DateTimeOffset(fecha);
                string estado = data.GetValue(2).ToString();
                int ident = Int32.Parse(data.GetValue(3).ToString());
                o = new TOOrden(nombre, fecha, estado, ident);
                if (command.Connection.State == ConnectionState.Open) { command.Connection.Close(); }
            }
            catch (Exception e)
            {

                throw e;
            }
            finally { if (command.Connection.State == ConnectionState.Open) { command.Connection.Close(); } }
            return o;
        }

        public LinkedList<TOOrden> listaOrdenes()
        {
            string query = "select * from Orden";
            string conn = Properties.Settings.Default.Conn;
            SqlCommand command = new SqlCommand(query, new SqlConnection(conn));
            LinkedList<TOOrden> list = new LinkedList<TOOrden>();
            TOOrden o;
            SqlDataReader data;
            try
            {
                if (command.Connection.State == ConnectionState.Closed) { command.Connection.Open(); }
                data = command.ExecuteReader();
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        string nombre = data["Nombre_Usuario"].ToString();
                        String fecha = data["Fecha"].ToString();
                        string stado = data["Estado"].ToString();
                        int identificador = Int32.Parse(data["Identificador"].ToString());
                        DateTime fecha1 = DateTime.Now;
                        DateTime fecha2 = DateTime.Parse(fecha.ToString());
                        //DateTime fecha2 = new DateTime(fecha);
                        //DateInterval res 
                       // long res = DateAndTime.DateDiff(DateInterval.Minute,fecha2,fecha1);
                        o = new TOOrden(nombre, fecha, stado, identificador);
                        //o = new TOOrden(nombre, fecha, stado, identificador);

                        list.AddLast(o);
                    }
                }
                if (command.Connection.State == ConnectionState.Open) { command.Connection.Close(); }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (command.Connection.State == ConnectionState.Open) { command.Connection.Close(); }
            }
            return list;
        }

        public SqlDataReader lista()
        {
            string query = "select * from Orden";
            string conn = Properties.Settings.Default.Conn;
            SqlCommand command = new SqlCommand(query, new SqlConnection(conn));
            LinkedList<TOOrden> list = new LinkedList<TOOrden>();
            TOOrden o;
            SqlDataReader data;
            try
            {
                if (command.Connection.State == ConnectionState.Closed) { command.Connection.Open(); }
                data = command.ExecuteReader();

                if (command.Connection.State == ConnectionState.Open) { command.Connection.Close(); }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (command.Connection.State == ConnectionState.Open) { command.Connection.Close(); }
            }
            return data;
        }
    }
}
    