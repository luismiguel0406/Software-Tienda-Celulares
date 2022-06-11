using System;
using System.Data.SqlClient;
using System.Data;

namespace CapaDeDatos
{
    public  class login:conexion
    {
        public DataTable AutenticarUsuario(string usuario, string clave)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("usp_ValidarUsuario", AbrirConexion()))
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@usu", usuario);
                    command.Parameters.AddWithValue("@cla", clave);
                    var reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);                               
                    return dt;                 
                }

            }
            catch (Exception ex)
            {

                throw new Exception($"No se pudo autenticar el usuario, {ex.Message}");
            }
        }
    }
}
