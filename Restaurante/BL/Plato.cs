using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
    public class Plato
    {
        public int Identificador { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public Double Precio { get; set; }
        public String Fotografia { get; set; }
        public int Habilitado { get; set; }

        public Plato() { }

        public Plato(int identificador, String nombre, String descripcion, Double precio, String fotografia, int habilitado)
        {
            this.Identificador = identificador;
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
