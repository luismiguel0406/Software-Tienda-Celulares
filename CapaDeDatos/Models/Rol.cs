namespace CapaDeDatos.Models
{
    public class Rol
    {
        public int? numQuery { get; set; }
        public int idRol { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int estado { get; set; }
        public Rol()
        {
            estado = 1;
        }
    }
}
