using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Compra
    {
        public int IdCompra {  get; set; }
        public int CantidadProductoTotales { get; set; }
        public float MontoTotal { get; set; }
        public DateTime FechaHora { get; set; }

        public ICollection<DetalleCompra> DetalleCompras { get; set; }
    }
}
