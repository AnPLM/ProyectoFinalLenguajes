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
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conn);

        public void insertarCliente(TOCliente toCliente) {
            try
            {
                SqlCommand sentencia = new SqlCommand("insert into Cliente values (@nombre," +
                "@correo, @nombreUsuario, @contr, @habilitado, @dir)", conexion);
                sentencia.Parameters.AddWithValue("@nombre", toCliente.Nombre);
                sentencia.Parameters.AddWithValue("@correo", toCliente.Correo);
                sentencia.Parameters.AddWithValue("@nombreUsuario", toCliente.NombreUsuario);
                sentencia.Parameters.AddWithValue("@contr", toCliente.Contrasenna);
                if (toCliente.Habilitado)
                {
                    sentencia.Parameters.AddWithValue("@habilitado", "1");
                }
                else
                {
                    sentencia.Parameters.AddWithValue("@habilitado", "0");
                }
                
                sentencia.Parameters.AddWithValue("@dir", toCliente.Direccion);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                sentencia.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception("Ocurrió un error al insertar");
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }          
        }

        public void actualizarDatosCliente(TOCliente clienteTO)
        {
            try {
                SqlCommand sentencia = new SqlCommand("update Cliente set Nombre=@nom, " +
                    "Contrasenna=@contr, Direccion=@dir where Nombre_Usuario=@usuar", conexion);
                sentencia.Parameters.AddWithValue("@nom", clienteTO.Nombre);
                sentencia.Parameters.AddWithValue("@contr", clienteTO.Contrasenna);
                sentencia.Parameters.AddWithValue("@dir", clienteTO.Direccion);
                sentencia.Parameters.AddWithValue("@usuar", clienteTO.NombreUsuario);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                sentencia.ExecuteNonQuery();
            }
            catch(Exception)
            {
                throw new Exception("Ocurrió un error al actualizar los datos");
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }

        }

        public void habilitarCliente(TOCliente toCliente) {
            try
            {
                SqlCommand sentencia = new SqlCommand("update Cliente set Habilitado='1' where Nombre_Usuario=@nomUsuar", conexion);
                sentencia.Parameters.AddWithValue("@nomUsuar", toCliente.NombreUsuario);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                sentencia.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error al habilitar el cliente");
            } finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
        }
        public void deshabilitarCliente(TOCliente toCliente) {
            try
            {
                SqlCommand sentencia = new SqlCommand("update Cliente set Habilitado='0' where Nombre_Usuario=@nomUsuar", conexion);
                sentencia.Parameters.AddWithValue("@nomUsuar", toCliente.NombreUsuario);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                sentencia.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error al deshabilitar el cliente");
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
        }
        public TOCliente autenticacionCliente(TOCliente cliente) //tiene que ser boolean
        {
            SqlCommand sentencia = new SqlCommand("select * from Cliente where Correo=@corr and Contrasenna=@contr", conexion);
            sentencia.Parameters.AddWithValue("@contr", cliente.Contrasenna);
            sentencia.Parameters.AddWithValue("@corr", cliente.Correo);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sentencia;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            
            if (tabla != null)
            {
                if (tabla.Rows.Count == 1)
                {
                    foreach (DataRow item in tabla.Rows)
                    {
                        cliente.NombreUsuario = cliente.NombreUsuario = item["Nombre_Usuario"].ToString();
                        cliente.Direccion = cliente.Direccion = item["Direccion"].ToString();
                        cliente.Nombre = cliente.Nombre = item["Nombre"].ToString();
                        if (item["Habilitado"].ToString() == "1")
                        {
                            cliente.Habilitado = true;
                        } else
                        {
                            cliente.Habilitado = false;
                        }
                    }

                    return cliente;
                }
            }
            return cliente;
        }
    }
}
