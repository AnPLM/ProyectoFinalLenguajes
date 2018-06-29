using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using TO;

namespace DAO
{
    public class DAOCliente
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.Conn);

        public void insertarCliente(TOCliente toCliente) {
            try
            {
                SqlCommand command = new SqlCommand("insert into Cliente values (@nombre," +
                "@correo, @nombreUsuario, @contr, @habilitado, @dir)", connection);
                command.Parameters.AddWithValue("@nombre", toCliente.Nombre);
                command.Parameters.AddWithValue("@correo", toCliente.Correo);
                command.Parameters.AddWithValue("@nombreUsuario", toCliente.NombreUsuario);
                command.Parameters.AddWithValue("@contr", toCliente.Contrasenna);
                command.Parameters.AddWithValue("@habilitado", toCliente.Habilitado);
                command.Parameters.AddWithValue("@dir", toCliente.Direccion);

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception("Ocurrió un error al insertar");
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }          
        }
        public void buscarCliente() { }
        public void habilitarCliente() { }
        public void deshabilitarCliente() { }
    }
}
