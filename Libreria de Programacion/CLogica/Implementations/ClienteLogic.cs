using CDatos.Repositories;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Implementations
{
    public class ClienteLogic : IClienteLogic
    { 
            private IClienteRepository _clienteRepository;
            private IPersonaLogic _personaLogic;

        public ClienteLogic(IClienteRepository clienteRepository, IPersonaLogic personaLogic)
        {
            _clienteRepository = clienteRepository;
            _personaLogic = personaLogic;
        }
        public List<Cliente> ObtenerClientes()
        {
            return _clienteRepository.FindAll().ToList();
        }

        public List<dynamic> ObtenerClientesParaListado()
        {
            return _clienteRepository.ObtenerClientes().Select(a => new { IdCliente = a.IdCliente, Nombre = a.Persona.Nombre, Apellido = a.Persona.Apellido, Documneto = a.Persona.Documento, Telefono = a.Persona.Telefono, Nacionalidad = a.Persona.Nacionalidad, Email = a.Persona.Email, EsSocio = a.EsSocio, PagaIVA = a.PagaIVA }).ToList<dynamic>();
        }

        public void AltaCliente(string nombre, string apellido, string nacionalidad, string documento, string email, string telefono, string esSocio, string pagaIva)
        {
            try
            {
                Persona personaNueva = new Persona()
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Telefono = telefono,
                    Email = email,
                    Documento = documento,
                    Nacionalidad = nacionalidad
                };

                Persona persona = _personaLogic.AltaPersona(personaNueva);

                Cliente clienteNuevo = new Cliente()
                {
                    Persona = persona,
                    EsSocio = esSocio,
                    PagaIVA = pagaIva,

                };
                List<string> camposErroneos = new List<string>();

                if (camposErroneos.Count > 0)
                {
                    throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", camposErroneos));
                }

                _clienteRepository.Create(clienteNuevo);
                _clienteRepository.Save();
            }
            catch (Exception)
            {
                throw;
            }
        }

            public void ActualizarCliente(string idCliente, string nombre, string apellido, string nacionalidad, string documento, string email, string telefono, string esSocio, string pagaIva)
            {
                try
                {
                    Int32.TryParse(idCliente, out int id);
                    Cliente? cliente = _clienteRepository.GetById(id);

                    if (cliente == null)
                    {
                        throw new ArgumentNullException("No se encontro un cliente con el ID ingresado.");
                    }

                    Persona personaActualizar = new Persona()
                    {
                        Nombre = nombre,
                        Apellido = apellido,
                        Telefono = telefono,
                        Email = email,
                        Documento = documento,
                        Nacionalidad = nacionalidad,
                        Cliente = cliente,
                    };

                    _personaLogic.ActualizarPersona(personaActualizar);

                    List<string> camposErroneos = new List<string>();

                    if (string.IsNullOrEmpty(cliente.EsSocio))
                    {
                        camposErroneos.Add("EsSocio");
                    }
                    if (string.IsNullOrEmpty(cliente.PagaIVA))
                    {
                        camposErroneos.Add("PagaIVA");
                    }

                    if (camposErroneos.Count > 0)
                    {
                        throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", camposErroneos));
                    }

                    cliente.EsSocio = esSocio;
                    cliente.PagaIVA = pagaIva;


                    _clienteRepository.CreateCliente(cliente);
                    _clienteRepository.Save();
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public void EliminarCliente(string idCliente)
            {

            Int32.TryParse(idCliente, out int id);
            Cliente? cliente = _clienteRepository.GetById(id);

                if (cliente == null)
                {
                    throw new ArgumentNullException("No se ha encontrado un cliente con el id ingresado");
                }
                _clienteRepository.Delete(cliente);
                _clienteRepository.Save();
            }
        public Cliente? BuscarCliente(int idCLiente) => _clienteRepository.GetById(idCLiente);

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
            public bool IsValidEsSocio(string EsSocio)
            {
                return EsSocio.Equals("si", StringComparison.OrdinalIgnoreCase) && EsSocio.Equals("no", StringComparison.OrdinalIgnoreCase);
            }

            public bool IsValidPagaIVA(string PagaIVA)
            {
                return PagaIVA.Equals("si", StringComparison.OrdinalIgnoreCase) && PagaIVA.Equals("no", StringComparison.OrdinalIgnoreCase);
            }

        #endregion validaciones 
    }
}

