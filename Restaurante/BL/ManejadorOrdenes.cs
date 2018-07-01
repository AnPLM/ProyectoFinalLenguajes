using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using TO;
using System.Collections;

namespace BL
{
    public class ManejadorOrdenes
    {
        private DaoOrden dao;
        public ManejadorOrdenes() { dao = new DaoOrden(); }

        public ArrayList listaOrdenes() {
            ArrayList list = new ArrayList();
            LinkedList<TOOrden> l = dao.listaOrdenes();
            foreach (TOOrden item in l) {
                list.Add(new BLOrden(item.Nombre_Usuario,item.Fecha,item.Estado,item.Identificador));
            }
            return list;
        }
    }
}
