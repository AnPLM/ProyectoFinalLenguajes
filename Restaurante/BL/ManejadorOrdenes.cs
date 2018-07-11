using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using TO;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace BL
{
    public class ManejadorOrdenes
    {
        private DaoOrden dao;

        //public string nombreUsuario { get; set; }
        //public DateTime Fecha { get; set; }
        //public string Estado { get; set; }
       // public int Identificador { get; set; }
        //private DaoOrden dao;
        public ManejadorOrdenes() { dao = new DaoOrden(); }

        public ArrayList listaOrdenes() {
            ArrayList list = new ArrayList();
            string cd = "";
            LinkedList<TOOrden> l = dao.listaOrdenes();
            foreach (TOOrden item in l) {
                list.Add(new BLOrden(item.Nombre_Usuario,item.Fecha,item.Estado,item.Identificador));
                cd += item.ToString();
            }
            return list;
        }

        public SqlDataReader lista()
        {
            return dao.lista();
        }

        public int insertar(string nombreUsuario, DateTime Fecha, string Estado, int Identificador)
        {
            TOOrden o = new TOOrden(nombreUsuario, Fecha, Estado, Identificador);
            return dao.insertar(o);
        }

        public void eliminar(int identificador)
        {
            dao.eliminar(identificador);
        }

        public void actualizar( string Estado, int Identificador)
        {
            TOOrden o = new TOOrden(Estado, Identificador);
            dao.actualizar(o);
        }

        public List<BLOrden> listaActiva() {
            LinkedList<TOOrden> array = dao.listaOrdenes();
            List<BLOrden> list = new List<BLOrden>();
            for (int i = 0; i < dao.listaOrdenes().Count; i++)
            {
                if (array.ElementAt<TOOrden>(i).Estado.Equals("activo")) {

                list.Add(new BLOrden(array.ElementAt<TOOrden>(i).Nombre_Usuario,
                    array.ElementAt<TOOrden>(i).Fecha,
                    array.ElementAt<TOOrden>(i).Estado,
                    array.ElementAt<TOOrden>(i).Identificador));
                }

            }
            return list;
        }

        public BLOrden Buscar(int identificador)
        {
            TOOrden o = dao.Buscar(identificador);
            //this.nombreUsuario = o.Nombre_Usuario;
            //this.Fecha = o.Fecha;
            //this.Estado = o.Estado;
            return new BLOrden(o.Nombre_Usuario,o.Fecha,o.Estado,identificador);
        }
    }
}
