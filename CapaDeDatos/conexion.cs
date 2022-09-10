using System.Data.SqlClient;

namespace CapaDeDatos
{
    public abstract class conexion
    {
        public SqlConnection Con { get; set; }
        private readonly string _conexion = "Data Source=SQL5109.site4now.net;Initial Catalog=db_a38950_dorbe;User Id=db_a38950_dorbe_admin;Password=321Abcd...";
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
