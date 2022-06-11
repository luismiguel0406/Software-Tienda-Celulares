using System.Data;
using System.Data.SqlClient;

namespace CapaDeDatos
{
    public  class menuDinamico:conexion
    {

        public DataTable tablaMenuDimanico(int numQuery,int tipoMenu,int? idMenu)
        {
            DataTable tabla = new DataTable();

            using (SqlCommand command = new SqlCommand("USP_MENU_DINAMICO",AbrirConexion()))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@NUMQUERY", numQuery);
                command.Parameters.AddWithValue("@TIPO_MENU", tipoMenu);
                command.Parameters.AddWithValue("@ID_MENU", idMenu);

                SqlDataReader reader = command.ExecuteReader();
                tabla.Load(reader);
                return tabla;

            }

        }
        
    }
}
