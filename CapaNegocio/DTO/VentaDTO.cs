using CapaDeDatos.CRUDS;
using CapaDeDatos.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.DTO
{
    public class VentaDTO
    {
        public static DataTable MantenimientoVenta(Venta venta, int numQuery)
        {
            try
            {
                venta.numQuery = numQuery;
                ventaDAO _ventaInstancia = new ventaDAO();
                var dt = _ventaInstancia.Venta("USP_VENTA", venta);
                return dt;
            }
            catch (Exception)
            {
                throw new Exception("Ha ocurrido un error, contacte un administrador");
            }

        }
    }
}
