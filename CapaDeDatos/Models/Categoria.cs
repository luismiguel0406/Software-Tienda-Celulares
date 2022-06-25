namespace CapaDeDatos.Models
{
    public class Categoria
    {
        public int? numQuery { get; set; }
        public int idCategoria { get; set; }
        public string nombre { get; set; }
        public int estado { get; set; }

        public Categoria()
        { 
            estado = 1;
        }
    }
}
