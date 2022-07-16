using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos.Models
{
    public class Empresa
    {
        public int numQuery { get; set; }
        public int id { get; set; }
        public string nombre { get; set; }
        public int estado { get; set; }

        public Empresa()
        {
            estado = 1;
        }
    }
}
