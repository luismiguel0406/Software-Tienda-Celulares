using System.Data;
using CapaDeDatos;

namespace CapaNegocio
{
    public  class menuDinamicoDTO
    {
       
        public DataTable menuDinamico(int numQuery, int tipoMenu, int? idMenu)
        {
            menuDinamico datos = new menuDinamico();
             return datos.tablaMenuDimanico(numQuery, tipoMenu, idMenu);

        }
    }
}
