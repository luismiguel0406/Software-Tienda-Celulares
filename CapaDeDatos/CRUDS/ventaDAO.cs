using CapaDeDatos.Models;
using System.Data;

namespace CapaDeDatos.CRUDS
{
    public  class ventaDAO:Cruds
    {
        public DataTable Venta(string procedimiento, Venta venta)
        {
            var data = DataQuery(procedimiento, venta);
            return data;

        }
    }
}
