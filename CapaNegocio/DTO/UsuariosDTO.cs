using CapaDeDatos.CRUDS;
using CapaDeDatos.Models;
using System;
using System.Data;

namespace CapaNegocio.DTO
{
    public class UsuariosDTO
    {
        public static DataTable MantenimientoUsuario(Usuario usuario, int numQuery)
        {
            try
            {
                usuario.numQuery = numQuery;
                usuarioDAO _usuarioInstancia = new usuarioDAO();
                var dt = _usuarioInstancia.Usuarios("USP_USUARIO", usuario);
                return dt;
            }
            catch (Exception)
            {
                throw new Exception("Ha ocurrido un error, contacte un administrador");
            }
        }
    }
}
