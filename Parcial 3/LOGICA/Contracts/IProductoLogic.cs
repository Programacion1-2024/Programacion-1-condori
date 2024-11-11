using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA.Contracts
{
    public interface IProductoLogic
    {
        List<Producto> ObtenerProductos();
        List<dynamic> ObtenerProductosParaListado();
        void AltaProducto(string Nombre, string Descripcion, float PrecioActual, int Stock);
    }
}
