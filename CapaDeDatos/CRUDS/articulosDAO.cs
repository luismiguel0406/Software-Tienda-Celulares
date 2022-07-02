using CapaDeDatos.Models;
using System.Data;


namespace CapaDeDatos.CRUDS
{
    public  class articulosDAO:Cruds
    {
       
        public  DataTable Articulos(string procedimiento, Articulo articulo)
        {       
            var data = DataQuery(procedimiento, articulo);
            return data;

        }


    }
}
