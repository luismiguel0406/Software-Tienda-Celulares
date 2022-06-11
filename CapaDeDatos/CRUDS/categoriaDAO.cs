using CapaDeDatos.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos.CRUDS
{
    public class categoriaDAO:Cruds
    {

        public DataTable Categorias(string procedimiento, Categoria categoria)
        {
           
            var data = DataQuery(procedimiento, categoria);
            return data;

        }
    }
}
