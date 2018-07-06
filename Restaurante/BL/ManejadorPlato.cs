using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace BL
{
    public class ManejadorPlato
    {
        private Plato plato = new Plato();

        public void agregarPlato(String codigo, String nombre, String descripcion, double precio, String fotografia, int habilitado)
        {
            TOPlato toPlato = new TOPlato(codigo, nombre, descripcion, precio, fotografia, habilitado);
            plato.agregarPlatos(toPlato);
        }

        public void eliminarPlato(String codigo)
        {
            TOPlato newPlato = new TOPlato(codigo, 1);
            plato.eliminarPlatos(newPlato);
           
        }

        public void modificarPlato(String codigo, String nombre, String descripcion, double precio, String fotografia, int habilitado)
        {
            TOPlato toPlato = new TOPlato(codigo,nombre, descripcion, precio, fotografia, habilitado);
            plato.modificarPlatos(toPlato);
        }


        public ArrayList listarPlatos()
        {
            ArrayList listaPlatos = new ArrayList();
            foreach (TOPlato plato in plato.listarPlatosA())
            {
                listaPlatos.Add(new Plato(plato.Codigo, plato.Nombre, plato.Descripcion, plato.Precio, plato.Fotografia, plato.Habilitado));
            }
            return listaPlatos;
        }

        public List<Plato> buscarPlatoAdmin(String nombre)
        {
            TOPlato platoT = new TOPlato(nombre);
            List<Plato> lista = new List<Plato>();
            foreach (TOPlato platos in plato.buscarPlatoAdmin(platoT))
            {
                lista.Add(new Plato(platos.Codigo, platos.Nombre, platos.Descripcion, platos.Precio, platos.Fotografia, platos.Habilitado));
            }
            return lista;
        }
    }
}
