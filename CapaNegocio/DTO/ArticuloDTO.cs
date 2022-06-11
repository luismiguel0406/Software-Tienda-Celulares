
using CapaDeDatos.CRUDS;
using CapaDeDatos.Models;
using System;
using System.Data;

namespace CapaNegocio.DTO
{
    public class ArticuloDTO
    {
        
        public static DataTable MantenimientoArticulo(Articulo articulo, int numQuery)
        {
            try
            {
                articulo.numQuery = numQuery;
                articulosDAO _articuloInstancia = new articulosDAO();
                var dt = _articuloInstancia.Articulos("USP_ARTICULO", articulo);
                return dt;
            }
            catch (Exception)
            {
                throw  new Exception ("Ha ocurrido un error, contacte un administrador");
            }
          
        }
    
    }
}
