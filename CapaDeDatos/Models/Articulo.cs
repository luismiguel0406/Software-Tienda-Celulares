namespace CapaDeDatos.Models
{
    public class Articulo
    {
        public int? numQuery { get; set; }
        public int idArticulo { get; set; }
        public int idCategoria { get; set; }
        public int codigo { get; set; }
        public string nombre { get; set; }
        public float precioVenta { get; set; }
        public int stock { get; set; }
        public string descripcion { get; set; }
        public int estado { get; set; }
        public int empresa { get; set; }

        public Articulo()
        {
            estado = 1;
        }
    }
    
}
