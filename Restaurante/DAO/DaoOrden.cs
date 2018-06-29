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
        private DateTime Fecha { set; get; }
        private string Estado { set; get; }
        private int Identificador { set; get; }


        public DaoOrden() { }

        public DaoOrden(String nombre, DateTime fecha, string estado, int identificador) {
            this.Nombre_Usuario = nombre;
            this.Fecha = fecha;
            this.Estado = estado;
            this.Identificador = identificador;
        }

        public void insertar(Orden o) {
            String query = "insert into Orden values(@nom, @fec, @est, @ide);";
            string conn = Properties.Settings.Default.Conn;
            SqlCommand command = new SqlCommand(query, new SqlConnection(conn));
            command.Parameters.AddWithValue("@nom",o.Nombre_Usuario);
            command.Parameters.AddWithValue("@fec",o.Fecha);
            command.Parameters.AddWithValue("@est",o.Estado);
            command.Parameters.AddWithValue("@ide",o.Identificador);
            if (command.Connection.State == ConnectionState.Closed) {command.Connection.Open(); }
            command.ExecuteNonQuery();
            if (command.Connection.State == ConnectionState.Open) { command.Connection.Close(); }

        }

        public void eliminar(int id) {
            string query = "delete * from Orden where Identificador = @id";
            string conn = Properties.Settings.Default.Conn;
            SqlCommand command = new SqlCommand(query, new SqlConnection(conn));
            command.Parameters.AddWithValue("@id",id);
            if (command.Connection.State == ConnectionState.Closed) {command.Connection.Open();}
            command.ExecuteNonQuery();
            if (command.Connection.State == ConnectionState.Open) { command.Connection.Close();}
        }

        public void actualizar() { }

        public Orden Buscar() { return new Orden(); }

        public void /*LinkedList<Orden>*/ listaOrdenes() { /*return new LinkedList<Orden> list;*/ }
    }
}
