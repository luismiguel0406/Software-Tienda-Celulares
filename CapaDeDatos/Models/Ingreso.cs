﻿
using System;
using System.Collections.Generic;
using Utilidades;

namespace CapaDeDatos.Models
{
    public class Ingreso
    {
        public int numQuery { get; set; }
        public int idIngreso { get; set; }
        public int? idProveedor { get; set; }
        public int? idUsuario { get; set; }
        public string tipoComprobante { get; set; }
        public string serieComprobante { get; set; }
        public string  numeroComprobante { get; set; }
        public DateTime fecha { get; set; }
        public DateTime? fechaDesde { get; set; }
        public DateTime? fechaHasta { get; set; }
        public double impuesto { get; set; }
        public string comentario { get; set; }
        public double total { get; set; }
        public int estado { get; set; }
        public int empresa { get; set; }
        public List<DetalleIngreso> detalleIngreso  { get; set; }

        public Ingreso()
        {
           estado = 1;
           empresa = GlobalClass.empresa;
        }
    }
}
