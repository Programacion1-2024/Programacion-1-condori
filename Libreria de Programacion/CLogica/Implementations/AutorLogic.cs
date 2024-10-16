using CDatos.Repositories;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CLogica.Implementations
{
    public class AutorLogic : IAutorLogic
    {
        private IAutorRepository _autorRepository;

        private IPersonaLogic _personaLogic;
        public AutorLogic(IAutorRepository AutorRepository, IPersonaLogic personaLogic)
        {
            _autorRepository = AutorRepository;
            _personaLogic = personaLogic;
        }

        public List<Autor> ObtenerAutores()
        {
            return _autorRepository.FindAll().ToList();
        }

        public List<dynamic> ObtenerAutoresParaListado()
        {
            return _autorRepository.ObtenerAutores().Select(a => new { IdAutor = a.IdAutor, Nombre = a.Persona.Nombre, Apellido = a.Persona.Apellido, Telefono = a.Persona.Telefono, Nacionalidad = a.Persona.Nacionalidad, Email = a.Persona.Email, Biografia = a.Biografia }).ToList<dynamic>();
        }

        public void AltaAutor(string nombre, string apellido, string nacionalidad, string email, string telefono, string biografia)
        {
            try
            {
                Persona personaNueva = new Persona()
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Telefono = telefono,
                    Email = email,
                    Nacionalidad = nacionalidad
                };

                Persona persona = _personaLogic.AltaPersona(personaNueva);

                Autor autorNuevo = new Autor()
                {
                    Persona = persona,
                    Biografia = biografia
                };

                List<string> camposErroneos = new List<string>();

                if (string.IsNullOrEmpty(autorNuevo.Biografia))
                    camposErroneos.Add("Biografia");

                if (camposErroneos.Count > 0)
                {
                    throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", camposErroneos));
                }

                _autorRepository.CreateAutor(autorNuevo);
                _autorRepository.Save();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ActualizacionAutor(string idAutor, string nombre, string apellido, string nacionalidad, string email, string telefono, string biografia)
        {
            try
            {
                Int32.TryParse(idAutor, out int id);
                Autor? autor = _autorRepository.GetById(id);

                if (autor == null)
                {
                    throw new ArgumentNullException("No se encontro un autor con el ID ingresado.");
                }

                Persona personaActualizar = new Persona()
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Telefono = telefono,
                    Email = email,
                    Nacionalidad = nacionalidad,
                    Autor = autor
                };

                _personaLogic.ActualizarPersona(personaActualizar);

                List<string> camposErroneos = new List<string>();

                if (string.IsNullOrEmpty(autor.Biografia))
                {
                    camposErroneos.Add("Biografia");
                }

                if (camposErroneos.Count > 0)
                {
                    throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", camposErroneos));
                }

                autor.Biografia = biografia;

                _autorRepository.CreateAutor(autor);
                _autorRepository.Save();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void EliminarAutor(string idAutor)
        {
            Int32.TryParse(idAutor, out int id);
            Autor? autor = _autorRepository.GetById(id);

            if (autor == null)
            {
                throw new ArgumentNullException("No se encontro un autor con el ID ingresado.");
            }
            _autorRepository.Delete(autor);
            _autorRepository.Save();
        }

        public Autor? BuscarAutor(int idAutor) => _autorRepository.GetById(idAutor);


        #region validaciones
        private bool ContainsInvalidCharacter(string text)
        {
            char[] caracteres = { '!', '"', '#', '$', '%', '/', '(', ')', '=', '.', ',' };
            return caracteres.Any(c => text.Contains(c));
        }
        private bool IsValidName(string nombre)
        {
            return nombre.Length < 15 && !ContainsInvalidCharacter(nombre);
        }
        private bool IsValidDocumento(string documento)
        {
            return documento.Length == 8 && documento.All(c => Char.IsNumber(c));
        }
        public bool IsValidTelefono(string telefono)
        {
            return telefono.Length == 10 && telefono.All(c => Char.IsNumber(c));
        }
        public bool IsValidEmail(string email)
        {
            return email.Contains('@') && !ContainsInvalidCharacter(email);
        }
        private bool IsValidBiografia(string biografia)
        {
            return biografia.Length < 32 && !ContainsInvalidCharacter(biografia);
        }

        #endregion validaciones 

    }
}