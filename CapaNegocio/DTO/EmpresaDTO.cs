using CapaDeDatos.CRUDS;
using CapaDeDatos.Models;
using System;
using System.Data;


namespace CapaNegocio.DTO
{
    public class EmpresaDTO
    {
        public static DataTable MantenimientoEmpresa(Empresa empresa, int numQuery)
        {
            try
            {
                empresa.numQuery = numQuery;
                empresaDAO _empresaInstancia = new empresaDAO();
                var dt = _empresaInstancia.Empresas("USP_EMPRESA", empresa);
                return dt;
            }
            catch (Exception)
            {
                throw new Exception("Ha ocurrido un error, contacte un administrador");
            }

        }
    }
}
