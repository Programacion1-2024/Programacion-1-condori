using DATOS.Repositorios;
using DATOS.Repositorios.Contracts;
using Entities;
using LOGICA.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA.Implementions
{
    public class ProductoLogic : IProductoLogic
    {
        private IProductoRepository _ProductoRepository;

        public ProductoLogic(IProductoRepository productoRepository)
        {
            _ProductoRepository = productoRepository;
        }

        public List<Producto> ObtenerProductos()
        {
            return _ProductoRepository.GetAll().ToList();
        }
        public List<dynamic> ObtenerProductosParaListado()
        {
            return _ProductoRepository.ObtenerProductos().Select(a => new { IdProducto = a.IdProducto, Nombre = a.Nombre, Descripcion = a.Descripcion, Stock = a.Stock, PrecioActual = a.PrecioActual }).ToList<dynamic>();
        }
        public void AltaProducto(string Nombre, string Descripcion, float PrecioActual, int Stock)
        {

            List<string> CamposErroneos = new List<string>();

            if (string.IsNullOrEmpty(Nombre) || !IsValidName(Nombre))
                CamposErroneos.Add("Nombre");

            if (string.IsNullOrEmpty(Descripcion) || !IsValidDescripcion(Descripcion))
                CamposErroneos.Add("Descripcion");

            if (Stock < 0)
                CamposErroneos.Add("Stock");

            if (PrecioActual < 0)
                CamposErroneos.Add("PrecioActual");

            try
            {
                if (CamposErroneos.Count > 0)
                {
                    throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", CamposErroneos));
                }

                Producto productoNuevo = new Producto()
                {
                    Nombre = Nombre,
                    Descripcion = Descripcion,
                    PrecioActual = PrecioActual,
                    Stock = Stock
                };

                _ProductoRepository.Create(productoNuevo);
                _ProductoRepository.Save();

            }
            catch (Exception)
            {
                throw;
            }


        }
        public void ModificarCliente(int IdProducto, string Nombre, string Descripcion, float PrecioActual, int Stock)
        {

            List<string> CamposErroneos = new List<string>();

            if (string.IsNullOrEmpty(Nombre) || !IsValidName(Nombre))
                CamposErroneos.Add("Nombre");

            if (string.IsNullOrEmpty(Descripcion) || !IsValidDescripcion(Descripcion))
                CamposErroneos.Add("Descripcion");

            if (Stock < 0)
                CamposErroneos.Add("Stock");

            if (PrecioActual < 0)
                CamposErroneos.Add("PrecioActual");
            try
            {

                if (!Int32.TryParse(IdProducto, out int Id))
                {
                    throw new ArgumentException("No se encontro el producto");
                }

                if (CamposErroneos.Count > 0)
                {
                    throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", CamposErroneos));
                }

                Producto ProductoModificar = BuscarPorId(Id);
                {
                    ProductoModificar.Nombre = Nombre;
                    ProductoModificar.Descripcion = Descripcion;
                    ProductoModificar.Stock = Stock;
                    ProductoModificar.PrecioActual = PrecioActual;
                }

                _ProductoRepository.Update( ProductoModificar);
                _ProductoRepository.Save();

            }
            catch (Exception
            ex)
            {
                throw new Exception("No se pudo modificar el producto");
            }
        }

        public Producto BuscarPorId(int IdProducto)
        {
            Producto producto = _ProductoRepository.GetById(IdProducto);
            if (producto == null)
            {
                throw new ArgumentException("No se encontro el producto");
            }
            return producto;
        }


        private bool ContainsInvalidCharacters(string text)
        {
            char[] caracteres = { '!', '"', '#', '$', '%', '/', '(', ')', '=', '.', ',' };
            return caracteres.Any(c => text.Contains(c));
        }

        private bool IsValidName(string Nombre)
        {
            return Nombre.Length < 16 && !ContainsInvalidCharacters(Nombre);
        }
        private bool IsValidDescripcion (string Descripcion)
        {
            return Descripcion.Length < 300 && !ContainsInvalidCharacters(Descripcion);
        }

    }
}
