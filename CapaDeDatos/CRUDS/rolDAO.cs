using CapaDeDatos.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos.CRUDS
{
    public class rolDAO:Cruds
    {
        public DataTable Roles(string procedimiento, Rol rol)
        {       
            var data = DataQuery(procedimiento, rol);
            return data;

        }
    }
}
