namespace CapaDeDatos.Models
{
    public class Persona
    {
        public int? numQuery { get; set; }
        public int idPersona { get; set; }
        public string tipoPersona { get; set; }
        public string nombre { get; set; }
        public string tipoDocumento { get; set; }
        public string numeroDocumento { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public int estado { get; set; }
        public int empresa { get; set; }
        public Persona()
        {
            estado = 1;
        }
    }
}
