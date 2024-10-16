using CDatos.Repositories;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Implementations
{
    public class EditorialLogic : IEditorialLogic
    {
        private readonly IRepository<Editorial> _editorialRepository;

        public EditorialLogic(IRepository<Editorial> editorialRepository)
        {
            _editorialRepository = editorialRepository;
        }

        public List<Editorial> ObtenerEditoriales()
        {
            return _editorialRepository.FindAll().ToList();
        }

        public List<dynamic> ObtenerEditorialesParaListado()
        {
            return _editorialRepository.FindAll()
                .Select(a => new { IdEditorial = a.IdEditorial, Nombre = a.Nombre, Direccion = a.Direccion, Contacto = a.Contacto })
                .ToList<dynamic>();
        }

        public void AltaEditorial(string nombre, string direccion, string contacto)
        {
            try
            {
                Editorial editorialNueva = new Editorial()
                {
                    Nombre = nombre,
                    Direccion = direccion,
                    Contacto = contacto,
                };

                List<string> camposErroneos = ValidarEditorial(editorialNueva);

                if (camposErroneos.Count > 0)
                {
                    throw new ArgumentException("Los siguientes campos son inválidos: " + string.Join(", ", camposErroneos));
                }

                _editorialRepository.Create(editorialNueva);
                _editorialRepository.Save();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ActualizarEditorial(string idEditorial, string nombre, string direccion, string contacto)
        {
            try
            {
                if (!Int32.TryParse(idEditorial, out int id))
                {
                    throw new ArgumentException("ID no válido.");
                }

                Editorial? editorial = _editorialRepository.GetById(id);

                if (editorial == null)
                {
                    throw new ArgumentNullException("No se encontró una editorial con el ID ingresado.");
                }

                editorial.Nombre = nombre;
                editorial.Direccion = direccion;
                editorial.Contacto = contacto;

                List<string> camposErroneos = ValidarEditorial(editorial);

                if (camposErroneos.Count > 0)
                {
                    throw new ArgumentException("Los siguientes campos son inválidos: " + string.Join(", ", camposErroneos));
                }

                _editorialRepository.Update(editorial);
                _editorialRepository.Save();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void EliminarEditorial(string idEditorial)
        {
            if (!Int32.TryParse(idEditorial, out int id))
            {
                throw new ArgumentException("ID no válido.");
            }

            Editorial? editorial = _editorialRepository.GetById(id);

            if (editorial == null)
            {
                throw new ArgumentNullException("No se encontró una editorial con el ID ingresado.");
            }

            _editorialRepository.Delete(editorial);
            _editorialRepository.Save();
        }

        public Editorial? BuscarEditorial(int idEditorial)
        {
            return _editorialRepository.GetById(idEditorial);
        }

        #region validaciones
        private List<string> ValidarEditorial(Editorial editorial)
        {
            List<string> camposErroneos = new List<string>();

            if (string.IsNullOrEmpty(editorial.Nombre) || !IsValidNombre(editorial.Nombre))
                camposErroneos.Add("Nombre");
            if (string.IsNullOrEmpty(editorial.Direccion) || !IsValidDireccion(editorial.Direccion))
                camposErroneos.Add("Direccion");
            if (string.IsNullOrEmpty(editorial.Contacto) || !IsValidContacto(editorial.Contacto))
                camposErroneos.Add("Contacto");

            return camposErroneos;
        }

        private bool ContainsInvalidCharacter(string text)
        {
            char[] caracteres = { '!', '"', '#', '$', '%', '/', '(', ')', '=', '.', ',' };
            return caracteres.Any(c => text.Contains(c));
        }

        public bool IsValidNombre(string nombre)
        {
            return nombre.Length < 50 && !ContainsInvalidCharacter(nombre);
        }

        public bool IsValidDireccion(string direccion)
        {
            return direccion.Length <= 100 && !ContainsInvalidCharacter(direccion);
        }

        public bool IsValidContacto(string contacto)
        {
            return contacto.Length >= 10 && contacto.All(c => Char.IsNumber(c) || c == '-');
        }
        #endregion validaciones
    }
}
