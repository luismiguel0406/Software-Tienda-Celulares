using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos.Interfaces
{
    public interface IDetalleVentaDetails
    {
        int idArticulo { get; set; }
        string descripcion { get; set; }
        int cantidad { get; set; }
        float precio { get; set; }
        float subTotal { get; set; }
    }
}
