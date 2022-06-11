using CapaDeDatos.CRUDS;
using CapaDeDatos.Models;
using System;
using System.Data;

namespace CapaNegocio.DTO
{
    public class IngresoDTO
    {

        public static DataTable MantenimientoIngreso(Ingreso ingreso, int numQuery)
        {
            try
            {
                ingreso.numQuery = numQuery;
                IngresoDAO _ingresoInstancia = new IngresoDAO();
                var dt = _ingresoInstancia.ingreso("USP_INGRESO", ingreso);
                return dt;
            }
            catch (Exception)
            {
                throw new Exception("Ha ocurrido un error, contacte un administrador");
            }
        }
    }
}
