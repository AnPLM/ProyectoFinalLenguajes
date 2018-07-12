using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using TO;

namespace BL
{
    public class BLOrden
    {
        public string nombreUsuario { get; set; }
        public string Fecha { get; set; }
        public string Estado { get; set; }
        public int Identificador { get; set; }
        private DaoOrden dao;

        public BLOrden() {
            dao = new DaoOrden();
        }

        public BLOrden(string nombre, string fecha, string estado, int identificador) {
            this.nombreUsuario = nombre;
            this.Fecha = fecha;
            this.Estado = estado;
            this.Identificador = identificador;
            dao = new DaoOrden();
        }

        public void insertar() {
            TOOrden o = new TOOrden(this.nombreUsuario, this.Fecha, this.Estado, this.Identificador);
            dao.insertar(o);
        }

        public void eliminar(int identificador) {
            dao.eliminar(identificador);
        }

        public void actualizar() {
            TOOrden o = new TOOrden(this.nombreUsuario, this.Fecha, this.Estado, this.Identificador);
            dao.actualizar(o);
        }

        public void Buscar() {
            TOOrden o = dao.Buscar(this.Identificador);
            this.nombreUsuario = o.Nombre_Usuario;
            this.Fecha = o.Fecha;
            this.Estado = o.Estado;
        }
    }
}
