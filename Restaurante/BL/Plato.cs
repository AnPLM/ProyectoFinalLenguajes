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

        public void agregarPlato() {
            DaoPlato daoPlato = new DaoPlato();
            TOPlato toPlato = new TOPlato(this.Codigo, this.Nombre, this.Descripcion, this.Precio, this.Fotografia, this.Habilitado);
            daoPlato.insertarPlato(toPlato);
        }
        public void eliminar()
        {
            TOPlato plato = new TOPlato(this.Nombre);
            DaoPlato daoPlato = new DaoPlato();
            daoPlato.eleminarPlato(plato);
        }

        public void modificarPlato() {
            TOPlato toPlato = new TOPlato(this.Nombre, this.Descripcion, this.Precio, this.Fotografia, this.Habilitado);
            DaoPlato daoPlato = new DaoPlato();
            daoPlato.modificarPlato(toPlato);
        }

        public void eliminarPlato() {
            TOPlato plato = new TOPlato(this.Nombre);
            DaoPlato daoPlato = new DaoPlato();
            daoPlato.eleminarPlato(plato);
        }

        public ArrayList listarPlatos() {
            DaoPlato daoPlato = new DaoPlato();
            ArrayList listaPlatos = new ArrayList();
            foreach (TOPlato plato in daoPlato.listarPlatos())
            {
                listaPlatos.Add(new Plato(plato.Codigo, plato.Nombre, plato.Descripcion, plato.Precio, plato.Fotografia, plato.Habilitado));
            }
            return listaPlatos;
        }

        public void buscarPlato() {
            TOPlato plato = new TOPlato(this.Nombre);
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
