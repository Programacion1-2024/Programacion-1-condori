using DATOS.Context;
using DATOS.Repositorios.Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS.Repositorios
{
    public class ProductoRepository : Repository<Producto>, IProductoRepository
    {
        public ProductoRepository(DataContext context) : base(context) 
        {
           
        }
        public void CreateProducto(Producto productoNuevo)
        {
            this._context.Productos.Attach(productoNuevo);
        }

        public List<Producto> ObtenerProductos()
        {
            return _context.Productos.ToList();
        }

        public void ActualizarCliente(Producto ProductoModificar)
        {
            Update(ProductoModificar); // Llama al método Update
            Save(); // Guarda los cambios
        }
        public Producto BuscarPorId(int IdProducto)
        {
            return _context.Productos.Find(IdProducto);
        }

       
    }
}
