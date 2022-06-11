using CapaDeDatos.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


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
