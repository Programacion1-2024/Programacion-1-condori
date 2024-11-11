namespace Entities
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public float PrecioActual { get; set; }

        public ICollection<DetalleCompra> DetalleCompras { get; set; }
    }
}
