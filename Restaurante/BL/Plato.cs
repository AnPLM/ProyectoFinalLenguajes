using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using TO;
using System.Collections;

namespace BL
{
    public class Plato
    {
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public Double Precio { get; set; }
        public String Fotografia { get; set; }
        public int Habilitado { get; set; }

        private DaoPlato daoPlato = new DaoPlato();

        public Plato() { }

        public Plato(String codigo, String nombre, String descripcion, Double precio, String fotografia, int habilitado)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Fotografia = fotografia;
            this.Habilitado = habilitado;
        }

        public void agregarPlatos(TOPlato plato)
        {
            daoPlato.insertarPlato(plato);
        }
        public void eliminarPlatos(TOPlato plato)
        {
        try { 
            daoPlato.eleminarPlato(plato);
        }
            catch (Exception e)
        {
             //throw new Exception(e.Message);
        }
        }
        public void modificarPlatos(TOPlato plato)
        {
            daoPlato.modificarPlato(plato);
        }
        public ArrayList listarPlatosA()
        {
            return daoPlato.listarPlatos();
        }
        public List<TOPlato> buscarPlatoAdmin(TOPlato plato)
        {
            return daoPlato.buscarPlatoAdmin(plato);
        }

        public void buscarPlato() {
            TOPlato plato = new TOPlato(this.Nombre);//NO LO CAMBIEN
            DaoPlato daoPlato = new DaoPlato();
            plato = daoPlato.buscarPlato(plato);
            this.Codigo = plato.Codigo;
            this.Descripcion = plato.Descripcion;
            this.Precio = plato.Precio;
            this.Fotografia = plato.Fotografia;
            this.Habilitado = plato.Habilitado;
        }

        public List<Plato> listarPlatosCliente()
        {
            DaoPlato daoPlato = new DaoPlato();
            List<Plato> lista = new List<Plato>();

            foreach (TOPlato item in daoPlato.listarPlatosCliente())
            {
                lista.Add(new Plato(item.Codigo, item.Nombre, item.Descripcion, item.Precio, item.Fotografia, item.Habilitado));
            }
            return lista;
        }
    }
}
