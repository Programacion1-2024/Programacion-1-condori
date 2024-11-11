using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class DetalleCompra
    {
        public int IdDetalleCompra { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public int IdCompra { get; set; }
        public Compra Compra { get; set; }

        public int IdProducto { get; set; }
        public Producto Producto { get; set; }

        
    }
}
