namespace CapaDeDatos.Models
{
    public  class Usuario
    {
        public int? numQuery { get; set; }
        public int idUsuario { get; set; }
        public int? idRol { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
        public string  direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public int estado { get; set; }
        public Usuario()
        {
            estado = 1;
        }
    }
}
