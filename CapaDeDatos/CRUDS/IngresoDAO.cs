using CapaDeDatos.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos.CRUDS
{
    public  class IngresoDAO:Cruds
    {
        public DataTable ingreso(string procedimiento, Ingreso ingreso)
        {
            var data = DataQuery(procedimiento, ingreso);
            return data;
        
        }

    }
}
