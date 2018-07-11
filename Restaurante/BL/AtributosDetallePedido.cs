using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class AtributosDetallePedido
    {
        public String NombreUsuario { get; set; }
        public String NombrePlato { get; set; }
        public int Cantidad { get; set; }
        public String Estado { get; set; }
        public String Fecha { get; set; }


        public AtributosDetallePedido(String nombreUsuario,
            String nombrePlato, String estado, String fecha, int cantidad)
        {
            this.NombrePlato = nombrePlato;
            this.NombreUsuario = nombreUsuario;
            this.Cantidad = cantidad;
            this.Estado = estado;
            this.Fecha = fecha;
        }

        public AtributosDetallePedido() { }


    }
}
