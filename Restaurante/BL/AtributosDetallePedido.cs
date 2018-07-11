using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    [Serializable]
    public class AtributosDetallePedido
    {
        public int IDOrden { get; set; }
        public String NombreUsuario { get; set; }
        public String NombrePlato { get; set; }
        public int Cantidad { get; set; }
        public String Estado { get; set; }
        public String Fecha { get; set; }


        public AtributosDetallePedido(int idOrden, String nombreUsuario,
            String nombrePlato, String estado, String fecha, int cantidad)
        {
            this.IDOrden = idOrden;
            this.NombrePlato = nombrePlato;
            this.NombreUsuario = nombreUsuario;
            this.Cantidad = cantidad;
            this.Estado = estado;
            this.Fecha = fecha;
        }

        public AtributosDetallePedido() { }


    }
}
