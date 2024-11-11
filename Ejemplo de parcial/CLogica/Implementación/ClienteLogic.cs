 using CDatos.Repositorios.Contracts;
using CEntidades.Entitis;
using CLogica.Contract;
using CDatos.Repositorios;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace CLogica.Implementación
{
    public class ClienteLogic : IClienteLogic
    {
        private IClienteRepository _clienteRepository;

        public ClienteLogic(IClienteRepository ClienteRepository)
        {
            _clienteRepository = ClienteRepository;
        }

        public List<Cliente> ObtenerClientes()
        {
            return _clienteRepository.FindAll().ToList();
        }

        public List<dynamic> ObtenerClientesParaListado()
        {
            return _clienteRepository.ObtenerClientes().Select(a => new {IdCliente = a.IdCliente, Nombre = a.Nombre, Apellido = a.Apellido, Dni = a.Dni}).ToList<dynamic>();
        }

        public void AltaCliente(string Nombre, string Apellido, string Dni)
        {

            List<string> CamposErroneos = new List<string>();

            if (string.IsNullOrEmpty(Nombre) || !IsValidName(Nombre))
                CamposErroneos.Add("Nombre");

            if (string.IsNullOrEmpty(Apellido) || !IsValidName(Apellido))
                CamposErroneos.Add("Apellido");

            if (string.IsNullOrEmpty(Dni) || !IsValidDni(Dni))
                CamposErroneos.Add("Dni");

            try
            {
                if (CamposErroneos.Count > 0)
                {
                    throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", CamposErroneos));
                }

                Cliente clienteNuevo = new Cliente()
                { 
                    Nombre = Nombre,
                    Apellido = Apellido,
                    Dni = Dni,
                };               

                _clienteRepository.Create(clienteNuevo);
                _clienteRepository.Save();

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ActualizarCliente(string IdCliente, string Nombre, string Apellido, string Dni)
        {
            List<string> CamposErroneos = new List<string>();
            if (string.IsNullOrEmpty(Nombre) || !IsValidName(Nombre))
                CamposErroneos.Add("Nombre");

            if (string.IsNullOrEmpty(Apellido) || !IsValidName(Apellido))
                CamposErroneos.Add("Apellido");

            if (string.IsNullOrEmpty(Dni) || !IsValidDni(Dni))
                CamposErroneos.Add("Dni");
            try
            {
                if(!Int32.TryParse(IdCliente, out int Id))
                {
                    throw new ArgumentException("No se encontro el Cliente");
                }

                if (CamposErroneos.Count > 0)
                {
                    throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", CamposErroneos));
                }

                Cliente clienteModificar = BuscarPorId(Id);
                {
                    clienteModificar.Nombre = Nombre;
                    clienteModificar.Apellido = Apellido;
                    clienteModificar.Dni = Dni;
                }

                _clienteRepository.Update(clienteModificar);
                _clienteRepository.Save();

            }
            catch (Exception
            ex)
            {
                throw new Exception("No se pudo modificar el Cliente");
            }
        }

        public void EliminarCliente(string IdCliente)
        {

            try
            {
                if (!Int32.TryParse(IdCliente, out int Id))
                {
                    throw new ArgumentException("No se encontro el Cliente");
                }

                Cliente clienteEliminar = BuscarPorId(Id);

                if(clienteEliminar == null)
                {
                    throw new ArgumentNullException("No se ha encontrado un cliente con el id ingresado");
                }

                _clienteRepository.Delete(clienteEliminar);
                _clienteRepository.Save();

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo eliminar el Cliente");
            }


        }


        public Cliente BuscarPorId(int IdCliente)
        {
            Cliente cliente = _clienteRepository.GetById(IdCliente);
            if (cliente == null)
            {
                throw new ArgumentException("No se encontro el cliente");
            }
            return cliente;
        }

        #region Validaciones

        private bool ContainsInvalidCharacters(string text)
        {
            char[] caracteres = { '!', '"', '#', '$', '%', '/', '(', ')', '=', '.', ',' };
            return caracteres.Any(c => text.Contains(c));
        }

        private bool IsValidName(string Nombre)
        {
            return Nombre.Length < 16 && !ContainsInvalidCharacters(Nombre);    
        }

        private bool IsValidDni(string Dni)
        {
            return Dni.Length == 8 && !ContainsInvalidCharacters(Dni);
        }

        #endregion Validaciones

    }
}
