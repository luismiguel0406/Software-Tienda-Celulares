using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeDatos.Models;

namespace CapaDeDatos.CRUDS
{
    public class personaDAO:Cruds
    {
        public DataTable Personas(string procedimiento, Persona persona) 
        {              
          var data = DataQuery(procedimiento, persona);
          return data;
        
        }

    }
}
