using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos.Models
{
    public class DetalleIngreso:IDetalleIngresoHeader,IDetalleIngresoDetails
    {
        public int idDetalle { get; set; }
        public int idIngreso  { get; set; }
        public int idArticulo { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public float precio { get; set; }
        public float subTotal { get; set; }
        public int estado { get; set; }

        public DetalleIngreso()
        {
            estado = 1;
        }
    }
}
