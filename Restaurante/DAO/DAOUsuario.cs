﻿using System;
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
                SqlCommand sentencia = new SqlCommand("insert into usuario values(@nomUsuar, @contr, @tipo, @hab)", conexion);
                sentencia.Parameters.AddWithValue("@nomUsuar", usuario.NombreUsuario);
                sentencia.Parameters.AddWithValue("@contr", usuario.Contrasenna);
                sentencia.Parameters.AddWithValue("@tipo", usuario.Tipo);

                String nombre = usuario.NombreUsuario;
                String cotra = usuario.Contrasenna;
                String tipo = usuario.Tipo;
               
                if(usuario.Habilitado == true)
                sentencia.Parameters.AddWithValue("@hab", 1);
                if (usuario.Habilitado == false)
                    sentencia.Parameters.AddWithValue("@hab", 0);

                Boolean habilitado = usuario.Habilitado;

                if (conexion.State!= ConnectionState.Open)
                {
                    conexion.Open();
                }
                sentencia.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un error al insertar un usuario");
            }
            finally
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
                SqlCommand sentencia = new SqlCommand("Delete usuario WHERE Nombre_Usuario=@nomUsuar", conexion);
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

        public void buscarUsuario(TOUsuario usuario)
        {
            try
            {
                DataTable tabla = new DataTable();
                String conuslta = "Select * From Usuario Where Nombre_Usuario = @nom";
                SqlCommand sentencia = new SqlCommand(conuslta, conexion);
                sentencia.Parameters.AddWithValue("@nom", usuario.NombreUsuario);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = sentencia;
                adapter.Fill(tabla);
                foreach (DataRow row in tabla.Rows)
                {
                    usuario.Tipo = row["Tipo"].ToString();
                    int i = int.Parse(row["Habilitado"].ToString());
                    usuario.Contrasenna = row["Contrasenna"].ToString();
                    if (i == 0)
                    {
                        usuario.Habilitado = false;
                    } else
                    {
                        usuario.Habilitado = true;
                    }     
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
        }

        public List<TOUsuario> listarUsuarios()
        {
            try
            {
                List<TOUsuario> list = new List<TOUsuario>();
                DataTable tabla = new DataTable();
                String conuslta = "Select * From Usuario";
                SqlCommand sentencia = new SqlCommand(conuslta, conexion);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = sentencia;
                adapter.Fill(tabla);
                Boolean hablitado;
                foreach (DataRow row in tabla.Rows)
                {
                    int i = int.Parse(row["Habilitado"].ToString());
                    if (i == 0)
                    {
                        hablitado = false;
                    }
                    else
                    {
                        hablitado = true;
                    }

                        list.Add(new TOUsuario(row["Nombre_Usuario"].ToString(), row["Contrasenna"].ToString(), row["Tipo"].ToString(), hablitado));
                }
                    return list;
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

        public void modificarNomobre(String nombreActual, String nombreNuevo)
        {
            try
            {
                SqlCommand sentencia = new SqlCommand("update usuario set nombre_usuario= @nomNuev where nombre_usuario=@nomUsuar",
                    conexion);
                sentencia.Parameters.AddWithValue("@nomUsuar", nombreActual);
                sentencia.Parameters.AddWithValue("@nomNuev", nombreNuevo);

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

        public void modificarContrasenna(String nombreActual, String contrasennaNueva)
        {
            try
            {
                SqlCommand sentencia = new SqlCommand("update usuario set Contrasenna= @conNuev where nombre_usuario=@nomUsuar",
                    conexion);
                sentencia.Parameters.AddWithValue("@nomUsuar", nombreActual);
                sentencia.Parameters.AddWithValue("@conNuev", contrasennaNueva);

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
    }
}
