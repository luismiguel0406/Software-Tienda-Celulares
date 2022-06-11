using CapaDeDatos.CRUDS;
using CapaDeDatos.Models;
using System;
using System.Data;

namespace CapaNegocio.DTO
{
    public class CategoriaDTO
    {
        public static DataTable MantenimientoCategoria(Categoria categoria, int numQuery)
        {
            try
            {
                categoria.numQuery = numQuery;
                categoriaDAO _categoriaInstancia = new categoriaDAO();
                var dt = _categoriaInstancia.Categorias("USP_CATEGORIA", categoria);
                return dt;
            }
            catch (Exception)
            {
                throw new Exception("Ha ocurrido un error, contacte un administrador");
            }

        }

    }
}
