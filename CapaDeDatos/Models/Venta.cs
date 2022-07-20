using System;
using System.Collections.Generic;
using Utilidades;

namespace CapaDeDatos.Models
{
    public class Venta
    {
        public int numQuery { get; set; }
        public int idVenta { get; set; }
        public int idUsuario { get; set; }
        public string numeroFactura { get; set; }
        public string comentario { get; set; }
        public float subtotal { get; set; }
        public float? itbis { get; set; }
        public float? descuento { get; set; }
        public double total { get; set; }
        public int estado { get; set; }
        public string terminal { get; set; }
        public int empresa { get; set; }
        public DateTime? fecha { get; set; }
        public DateTime?  fechaDesde { get; set; }
        public DateTime? fechaHasta { get; set; }
        public List<DetalleVenta> detalleVenta { get; set; }
        public Venta()
        {
            estado = 1;
            terminal = Environment.MachineName;
            empresa = GlobalClass.empresa;
           
        }
    }
}
