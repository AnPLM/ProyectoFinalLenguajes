using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
    public class Plato
    {
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public Double Precio { get; set; }
        public String Fotografia { get; set; }
        public Boolean Habilitado { get; set; }

        public Plato() { }

        public Plato(String nombre, String descripcion, Double precio, String fotografia, Boolean habilitado)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Fotografia = fotografia;
            this.Habilitado = habilitado;
        }

        public void agregarPlato() { }

        public void modificarPlato() { }

        public void eliminarPlato() { }

        public void buscarPlato() { }
    }
}
