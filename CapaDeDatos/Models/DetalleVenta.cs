using CapaDeDatos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos.Models
{
    public class DetalleVenta:IDetalleVentaDetails
    {
        public int? numQuery { get; set; }
        public int idDetalleVenta { get; set; }
        public int idVenta { get; set; }
        public int cantidad { get; set; }
        public int idArticulo { get; set; }
        public string descripcion { get; set; }
        public float precio { get; set; }
        public float subTotal { get; set; }
        public float descuento { get; set; }
        public float itbis { get; set; }
        public float total { get; set; }
        public int estado { get; set; }
        public DetalleVenta()
        {
            estado = 1;
        }
    }
}
