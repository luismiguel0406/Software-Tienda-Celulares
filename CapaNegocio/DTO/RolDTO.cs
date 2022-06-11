using CapaDeDatos.CRUDS;
using CapaDeDatos.Models;
using System;
using System.Data;

namespace CapaNegocio.DTO
{
    public class RolDTO
    {
        public static DataTable MantenimeintoRol(Rol rol, int numQuery)
        {
            try
            {
                rol.numQuery = numQuery;
                rolDAO _rolInstancia = new rolDAO();
                var dt = _rolInstancia.Roles("USP_ROL", rol);
                return dt;
            }
            catch (Exception)
            {
                throw new Exception("Ha ocurrido un error, contacte un administrador");
            }
        }
    }
}
