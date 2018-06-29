using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TO;
namespace DAO
{
    public class Orden
    {

        private string Nombre_Usuario { set; get; }
        private DateTime Fecha { set; get; }
        private string Estado { set; get; }
        private int Identificador { set; get; }


        public Orden() { }

        public Orden(String nombre, DateTime fecha, string estado, int identificador) {
            this.Nombre_Usuario = nombre;
            this.Fecha = fecha;
            this.Estado = estado;
            this.Identificador = identificador;
        }

        public void insertar() { }

        public void eliminar() { }

        public void actualizar() { }

        public Orden Buscar() { return new Orden(); }

        public LinkedList<Orden> listaOrdenes() { return new LinkedList<Orden> IList; }
    }
}
