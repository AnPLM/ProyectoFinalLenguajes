using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using DAO;

namespace BL
{
    public class AdminListaPedido
    {
        public String Cliente { get; set; }
        public String FechaInicio { get; set; }
        public String FechaFin { get; set; }
        public String Estado { get; set; }

        public AdminListaPedido(String cliente, String fechaInicio, String fechaFin, String estado)
        {
            this.Cliente = cliente;
            this.FechaInicio = fechaInicio;
            this.FechaFin = fechaFin;
            this.Estado = estado;
        }
        public AdminListaPedido() { }

        private DAOAdminListaPedido dao = new DAOAdminListaPedido();
        public List<AtributosDetallePedido> seleccionarPorCliente(String nombreUsuario) {
            TOAdminListaPedido toAdmin = new TOAdminListaPedido();
            toAdmin.Cliente = nombreUsuario;
            List<TOAtributosDetallePedido> listaTO = dao.seleccionarPorCliente(toAdmin);
            List<AtributosDetallePedido> listaBL = new List<AtributosDetallePedido>();
            foreach (TOAtributosDetallePedido item in listaTO)
            {
                listaBL.Add(new AtributosDetallePedido(item.IDORden, item.NombreUsuario, item.NombrePlato,
                    item.Estado, item.Fecha, item.Cantidad));
            }
            return listaBL;
        }

        public List<AtributosDetallePedido> seleccionarPorFecha(String fechaInicio, String fechaFin) {
            TOAdminListaPedido toAdmin = new TOAdminListaPedido();
            toAdmin.FechaInicio = fechaInicio;
            toAdmin.FechaFin = fechaFin;
            List<TOAtributosDetallePedido> listaTO = dao.seleccionarPorFecha(toAdmin);
            List<AtributosDetallePedido> listaBL = new List<AtributosDetallePedido>();
            foreach (TOAtributosDetallePedido item in listaTO)
            {
                listaBL.Add(new AtributosDetallePedido(item.IDORden, item.NombreUsuario, item.NombrePlato,
                    item.Estado, item.Fecha, item.Cantidad));
            }
            return listaBL;
        }

        public List<AtributosDetallePedido> seleccionarPorEstado(String estado) {
            TOAdminListaPedido toAdmin = new TOAdminListaPedido();
            toAdmin.Estado= estado;
            List<TOAtributosDetallePedido> listaTO = dao.seleccionarPorEstado(toAdmin);
            List<AtributosDetallePedido> listaBL = new List<AtributosDetallePedido>();
            foreach (TOAtributosDetallePedido item in listaTO)
            {
                listaBL.Add(new AtributosDetallePedido(item.IDORden, item.NombreUsuario, item.NombrePlato,
                    item.Estado, item.Fecha, item.Cantidad));
            }
            return listaBL;
        }

        public List<AtributosDetallePedido> seleccionarPorClienteFechaEstado(String fechaInicio, String fechaFin, String nombreUsuario, String estado) {
            TOAdminListaPedido toAdmin = new TOAdminListaPedido();
            toAdmin.Cliente = nombreUsuario;
            toAdmin.FechaFin = fechaFin;
            toAdmin.FechaInicio = fechaInicio;
            toAdmin.Estado = estado;
            List<TOAtributosDetallePedido> listaTO = dao.seleccionarPorClienteFechaEstado(toAdmin);
            List<AtributosDetallePedido> listaBL = new List<AtributosDetallePedido>();
            foreach (TOAtributosDetallePedido item in listaTO)
            {
                listaBL.Add(new AtributosDetallePedido(item.IDORden, item.NombreUsuario, item.NombrePlato,
                     item.Estado, item.Fecha, item.Cantidad));
            }
            return listaBL;
        }

        public List<AtributosDetallePedido> seleccionarPorClienteFecha(String nombreUsuario, String fechaInicio, String fechaFin) {
            TOAdminListaPedido toAdmin = new TOAdminListaPedido();
            toAdmin.Cliente = nombreUsuario;
            toAdmin.FechaFin = fechaFin;
            toAdmin.FechaInicio = fechaInicio;
            List<TOAtributosDetallePedido> listaTO = dao.seleccionarPorClienteFecha(toAdmin);
            List<AtributosDetallePedido> listaBL = new List<AtributosDetallePedido>();
            foreach (TOAtributosDetallePedido item in listaTO)
            {
                listaBL.Add(new AtributosDetallePedido(item.IDORden, item.NombreUsuario, item.NombrePlato,
                    item.Estado, item.Fecha, item.Cantidad));
            }
            return listaBL;
        }

        public List<AtributosDetallePedido> seleccionarPorClienteEstado(String nombreUsuario, String estado) {
            TOAdminListaPedido toAdmin = new TOAdminListaPedido();
            toAdmin.Cliente = nombreUsuario;
            toAdmin.Estado = estado;
            List<TOAtributosDetallePedido> listaTO = dao.seleccionarPorClienteEstado(toAdmin);
            List<AtributosDetallePedido> listaBL = new List<AtributosDetallePedido>();
            foreach (TOAtributosDetallePedido item in listaTO)
            {
                listaBL.Add(new AtributosDetallePedido(item.IDORden, item.NombreUsuario, item.NombrePlato,
                    item.Estado, item.Fecha, item.Cantidad));
            }
            return listaBL;
        }

        public List<AtributosDetallePedido> seleccionarPorFechaEstado(String estado, String fechaIncio, String fechaFin) {
            TOAdminListaPedido toAdmin = new TOAdminListaPedido();
            toAdmin.Estado = estado;
            toAdmin.FechaInicio = fechaIncio;
            toAdmin.FechaFin = fechaFin;
            List<TOAtributosDetallePedido> listaTO = dao.seleccionarPorFechaEstado(toAdmin);
            List<AtributosDetallePedido> listaBL = new List<AtributosDetallePedido>();
            foreach (TOAtributosDetallePedido item in listaTO)
            {
                listaBL.Add(new AtributosDetallePedido(item.IDORden, item.NombreUsuario, item.NombrePlato,
                    item.Estado, item.Fecha, item.Cantidad));
            }
            return listaBL;
        }

        public Boolean verificarEnLista(List<AtributosDetallePedido> lista, int orden)
        {
            Boolean estaEn = false;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].IDOrden == orden)
                {
                    estaEn = true;
                    break;
                }
            }
            return estaEn;
        }

        public void cambiarEstado(int orden, String nuevoEstado)
        {
            TOOrden toOrden = new TOOrden();
            toOrden.Estado = nuevoEstado;
            toOrden.Identificador = orden;

            DaoOrden dao = new DaoOrden();
            dao.actualizar(toOrden);
        }
    }
}
