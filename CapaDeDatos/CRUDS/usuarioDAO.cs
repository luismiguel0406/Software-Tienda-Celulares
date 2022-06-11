using CapaDeDatos.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos.CRUDS
{
    public class usuarioDAO:Cruds
    {
        public DataTable Usuarios(string procedimiento, Usuario usuario)
        {
            var data = DataQuery(procedimiento, usuario);
            return data;

        }
    }
}
