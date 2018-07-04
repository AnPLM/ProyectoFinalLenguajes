using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TO;
using System.Data;

namespace DAO
{
    public class DAOUsuario
    {
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conn);
        public void agregarUsuario(TOUsuario usuario)
        {
            try
            {
                SqlCommand sentencia = new SqlCommand("insert into usuario values(@nomUsuar, @contr, @tipo, @hab", conexion);
                sentencia.Parameters.AddWithValue("@nomUsuar", usuario.NombreUsuario);
                sentencia.Parameters.AddWithValue("@contr", usuario.Contrasenna);
                sentencia.Parameters.AddWithValue("@tipo", usuario.Tipo);
                sentencia.Parameters.AddWithValue("@hab", usuario.Habilitado);

                if (conexion.State!= ConnectionState.Open)
                {
                    conexion.Open();
                }
                sentencia.ExecuteNonQuery();
            } catch (Exception)
            {
                throw new Exception("Ocurrio un error al insertar un usuario");
            } finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }

        }

        public void eliminarUsuario(TOUsuario usuario)
        {
            try
            {
                SqlCommand sentencia = new SqlCommand("update usuario set habilitado = 0 where nombre_usuario=@nomUsuar", conexion);
                sentencia.Parameters.AddWithValue("@nomUsuar", usuario.NombreUsuario);


                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                sentencia.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un error al eliminar un usuario");
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
        }


        public void modificarUsuario(TOUsuario usuario)
        {
            try
            {
                SqlCommand sentencia = new SqlCommand("update usuario set nombre_usuario= @nomUsuar,"
                    + "contrasenna=@contr, tipo=@tipo, habilitado=@hab where nombre_usuario=@nomUsuar", 
                    conexion);
                sentencia.Parameters.AddWithValue("@nomUsuar", usuario.NombreUsuario);
                sentencia.Parameters.AddWithValue("@contr", usuario.Contrasenna);
                sentencia.Parameters.AddWithValue("@tipo", usuario.Tipo);
                sentencia.Parameters.AddWithValue("@hab", usuario.Habilitado);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                sentencia.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un error al modificar un usuario");
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
        }

        public Boolean autenticacionUsuario(TOUsuario usuario) //tiene que ser boolean
        {
            SqlCommand sentencia = new SqlCommand("select * from usuario where nombre_usuario=@nomUsuar and contrasenna=@contr", conexion);
            sentencia.Parameters.AddWithValue("@nomUsuar", usuario.NombreUsuario);
            sentencia.Parameters.AddWithValue("@contr", usuario.Contrasenna);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sentencia;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            if (tabla != null)
            {
                if (tabla.Rows.Count ==1)
                {
                    foreach (DataRow item in tabla.Rows)
                    {
                        usuario.NombreUsuario = item["Nombre_Usuario"].ToString();
                        usuario.Contrasenna = item["Contrasenna"].ToString();
                        usuario.Tipo = item["Tipo"].ToString();
                        if (int.Parse(item["Habilitado"].ToString()) == 1)
                        {
                            usuario.Habilitado = true;
                        }
                        else
                        {
                            usuario.Habilitado = false;
                        }
                    }
                    
                    
                    return true;
                }
            }
            return false;
        }

    }
}
