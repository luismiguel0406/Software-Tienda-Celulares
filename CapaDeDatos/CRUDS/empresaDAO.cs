﻿using CapaDeDatos.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos.CRUDS
{
    public class empresaDAO:Cruds
    {
        public DataTable Empresas(string procedimiento, Empresa empresa)
        {
            var data = DataQuery(procedimiento, empresa);
            return data;

        }
    }
}
