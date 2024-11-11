using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS.Repositorios.Contracts
{
    public interface IProductoRepository : IRepository<Producto>
    {
        void CreateProducto(Producto productoNuevo);
        List<Producto> ObtenerProductos();
        void ActualizarCliente(Producto ProductoModificar);
        Producto BuscarPorId(int IdProducto);
    }
}
