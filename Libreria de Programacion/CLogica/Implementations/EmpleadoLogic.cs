using CDatos.Repositories;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CLogica.Implementations
{
    public class EmpleadoLogic : IEmpleadoLogic
    { 
        private IEmpleadoRepository _empleadoRepository;
        private IPersonaLogic _personaLogic;
        public EmpleadoLogic(IEmpleadoRepository EmpleadoRepository, IPersonaLogic personaLogic)
        {
            _empleadoRepository = EmpleadoRepository;
            _personaLogic = personaLogic;
        }
        public List<Empleado> ObtenerEmpleados()
        {
            return _empleadoRepository.FindAll().ToList();
        }

        public List<dynamic> ObtenerEmpleadosParaListado()
        {
            return _empleadoRepository.ObtenerEmpleados().Select(a => new { IdEmpleado = a.IdEmpleado, Nombre = a.Persona.Nombre, Apellido = a.Persona.Apellido, Documento = a.Persona.Documento, Telefono = a.Persona.Telefono, Email = a.Persona.Email, Cargo = a.Cargo, Sueldo = a.Sueldo }).ToList<dynamic>();
        }

        public void AltaEmpleado(string nombre, string apellido, string documento, string telefono, string email, string cargo, string sueldo)
        {
            try
            {
                Persona personaNueva = new Persona()
                {
                    Nombre = nombre,
                    Apellido = apellido,                    
                    Documento = documento,
                    Telefono = telefono,
                    Email = email,

                };

                Persona persona = _personaLogic.AltaPersona(personaNueva);

                Empleado empleadoNuevo = new Empleado()
                {
                    Persona = persona,
                    Cargo = cargo,
                    Sueldo = sueldo,
                };

                List<string> camposErroneos = new List<string>();

                if (string.IsNullOrEmpty(empleadoNuevo.Cargo))
                    camposErroneos.Add("Cargo");
                if (string.IsNullOrEmpty(empleadoNuevo.Sueldo.ToString()))
                    camposErroneos.Add("Sueldo");

                if (camposErroneos.Count > 0)
                {
                    throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", camposErroneos));
                }

                _empleadoRepository.CreateEmpleado(empleadoNuevo);
                _empleadoRepository.Save();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ActualizarEmpleado(string idEmpleado, string nombre, string apellido, string documento, string telefono, string email, string cargo, string sueldo)
        {
            try
            {
                Int32.TryParse(idEmpleado, out int id);
                Empleado? empleado = _empleadoRepository.GetById(id);

                if (empleado == null)
                {
                    throw new ArgumentNullException("No se encontro un autor con el ID ingresado.");
                }

                Persona personaActualizar = new Persona()
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Documento = documento,
                    Telefono = telefono,
                    Email = email,
                    Empleado = empleado,
                };

                _personaLogic.ActualizarPersona(personaActualizar);

                List<string> camposErroneos = new List<string>();

                if (string.IsNullOrEmpty(empleado.Cargo))
                {
                    camposErroneos.Add("Cargo");
                }
                if (string.IsNullOrEmpty(empleado.Sueldo.ToString()))
                {
                    camposErroneos.Add("Sueldo");
                }

                if (camposErroneos.Count > 0)
                {
                    throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", camposErroneos));
                }

                empleado.Cargo = cargo;
                empleado.Sueldo = sueldo;

                _empleadoRepository.CreateEmpleado(empleado);
                _empleadoRepository.Save();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void EliminarEmpleado(string idEmpleado)
        {
            Int32.TryParse(idEmpleado, out int id);
            Empleado? empleado = _empleadoRepository.GetById(id);

            if (empleado == null)
            {
                throw new ArgumentNullException("No se encontro un empleado con el ID ingresado.");
            }
            _empleadoRepository.Delete(empleado);
            _empleadoRepository.Save();
        }

        public Empleado? BuscarEmpleado(int idEmpleado) => _empleadoRepository.GetById(idEmpleado);

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
        public bool IsValidCargo(string cargo)
        {
            var cargosValidos = new List<string> { "Gerente", "Supervisor", "Asistente", "Operario" };

            return cargosValidos.Contains(cargo, StringComparer.OrdinalIgnoreCase);
        }

        public bool IsValidSueldo(string cargo, float sueldo)
        {
            if (string.Equals(cargo, "Gerente", StringComparison.OrdinalIgnoreCase))
            {
                return sueldo >= 3000 && sueldo <= 7000;
            }
            else if (string.Equals(cargo, "Supervisor", StringComparison.OrdinalIgnoreCase))
            {
                return sueldo >= 2000 && sueldo <= 4000;
            }
            else if (string.Equals(cargo, "Asistente", StringComparison.OrdinalIgnoreCase))
            {
                return sueldo >= 1500 && sueldo <= 2500;
            }
            else if (string.Equals(cargo, "Operario", StringComparison.OrdinalIgnoreCase))
            {
                return sueldo >= 1000 && sueldo <= 2000;
            }
            // Si el cargo no es válido, el sueldo no es válido
            return false;
        }

        #endregion validaciones 
    }
}
