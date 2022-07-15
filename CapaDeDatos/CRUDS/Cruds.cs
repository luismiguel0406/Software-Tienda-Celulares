using Newtonsoft.Json;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeDatos.CRUDS
{
    public class Cruds:conexion
    {
        public DataTable DataQuery(string procedimiento, object modelo)
        {

            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(procedimiento, AbrirConexion()))
            using (SqlTransaction transaction = cmd.Connection.BeginTransaction("trans"))        
            {
                try
                {
                    cmd.Transaction = transaction;
                    string parametroJson = JsonConvert.SerializeObject(modelo);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@JSON", parametroJson);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                        transaction.Commit();
                        return dt;
                    }
                    transaction.Commit();
                    return dt;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return dt;
                }   
                   
                }                       
        }

    }
}
