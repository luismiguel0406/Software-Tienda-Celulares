using System.Data;
using CapaDeDatos;

namespace CapaNegocio
{
    public  class loginDTO
    {

        public DataTable login(string usuario, string contraseña)
        {
            login loginUsuario = new login();
             var usuarioValido = loginUsuario.AutenticarUsuario(usuario, contraseña);

            return usuarioValido;
          
        }

    }
}
