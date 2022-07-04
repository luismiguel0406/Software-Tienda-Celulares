namespace CapaDeDatos
{
    public interface IDetalleIngresoDetails
    {
        int idArticulo { get; set; }
        string descripcion { get; set; }
        int cantidad { get; set; }
        float precio { get; set; }
        float subTotal { get; set; }
    }
}
