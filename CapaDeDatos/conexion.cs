using System.Data.SqlClient;

namespace CapaDeDatos
{
    public abstract class conexion
    {
        public SqlConnection Con { get; set; }
        private readonly string _conexion = "";
        private readonly string _conexionLOCAL = "Data Source=.; Initial Catalog=PHONE_STORE; Integrated Security=True";
        public conexion()
        {

           Con = new SqlConnection(_conexion);

        }

       protected SqlConnection AbrirConexion()
        {
            Con.Open();
            return Con;
        }

        protected SqlConnection CerraConexion()
        {
            Con.Close();
            return Con;
        }
    }
}
