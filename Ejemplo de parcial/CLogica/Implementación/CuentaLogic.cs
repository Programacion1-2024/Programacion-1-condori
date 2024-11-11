using CDatos.Repositorios;
using CDatos.Repositorios.Contracts;
using CEntidades.Entitis;
using CLogica.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CLogica.Implementación
{
    public class CuentaLogic : ICuentaLogic
    {
        private ICuentaRepository _cuentaRepository;
        private IClienteRepository _clienteRepository;


        public CuentaLogic(ICuentaRepository cuentaRepository, IClienteRepository clienteRepository)
        {
            _cuentaRepository = cuentaRepository;
            _clienteRepository = clienteRepository;
        }

        public List<CuentaBancaria> ObtenerCuentas()
        {
            return _cuentaRepository.FindAll().ToList();
        }
        public List<dynamic> ObtenerCuentasParaListado()
        {
            return _cuentaRepository.ObtenerCuentas().Select(a => new { IdCuenta = a.IdCuenta, NroCuenta = a.NroCuenta, Saldo = a.Saldo, IdEstado =a.IdEstado,IdCliente = a.IdCliente }).ToList<dynamic>();
        }
        public void AltaCuenta(string NroCuenta, decimal Saldo,int IdEstado, int IdCliente)
        {
            List<string> CamposErroneos = new List<string>();

            if (string.IsNullOrEmpty(NroCuenta) || !IsValidNroCuenta(NroCuenta))
                CamposErroneos.Add("NroCuenta");

            if (Saldo < 0)
                CamposErroneos.Add("Saldo");

            if (IdCliente < 0)
                CamposErroneos.Add("Cliente vacio");

            
                if (CamposErroneos.Count > 0)
                {
                    throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", CamposErroneos));
                }
            try
            {

                CuentaBancaria cuentaNueva = new CuentaBancaria()
                {
                    NroCuenta = NroCuenta,
                    Saldo = Saldo,
                    IdEstado = IdEstado,
                    IdCliente = IdCliente,

                };

                _cuentaRepository.Create(cuentaNueva);
                _cuentaRepository.Save();

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ActualizarCuenta(string IdCuenta, string NroCuenta, decimal Saldo, int IdEstado, int IdCliente)
        {
            List<string> CamposErroneos = new List<string>();

            if (string.IsNullOrEmpty(NroCuenta) || !IsValidNroCuenta(NroCuenta))
                CamposErroneos.Add("NroCuenta");

            if (Saldo < 0)
                CamposErroneos.Add("Saldo");

            if (IdCliente < 0)
                CamposErroneos.Add("Cliente vacio");
            try
            {
                if (!Int32.TryParse(IdCuenta, out int Id))
                {
                    throw new ArgumentException("No se encontro la Cuenta");
                }

                if (CamposErroneos.Count > 0)
                {
                    throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", CamposErroneos));
                }
                Cliente cliente = _clienteRepository.BuscarPorId(IdCliente); 

                CuentaBancaria cuentaModificar = BuscarPorId(Id);
                {
                    cuentaModificar.NroCuenta = NroCuenta;
                    cuentaModificar.Saldo = Saldo;
                    cuentaModificar.IdEstado = IdEstado;
                    cuentaModificar.Cliente = cliente;
                }

                _cuentaRepository.Update(cuentaModificar);
                _cuentaRepository.Save();

            }
            catch (Exception
            ex)
            {
                throw new Exception("No se pudo modificar el Cliente");
            }
        }

        public CuentaBancaria BuscarPorId(int IdCuenta)
        {
            CuentaBancaria cuenta = _cuentaRepository.GetById(IdCuenta);
            if (cuenta == null)
            {
                throw new ArgumentException("No se encontro la cuenta");
            }
            return cuenta;
        }
        public bool CuentaExiste(string NroCuenta)
        {
            var cuentas = _cuentaRepository.FindByCuenta(NroCuenta);
            return cuentas !=  null;
        }


        #region Validaciones

        private bool ContainsInvalidCharacters(string text)
        {
            char[] caracteres = { '!', '"', '#', '$', '%', '/', '(', ')', '=', '.', ',' };
            return caracteres.Any(c => text.Contains(c));
        }

        private bool IsValidNroCuenta(string NroCuenta)
        {
            return NroCuenta.Length == 10 && !ContainsInvalidCharacters(NroCuenta);
        }
        #endregion Validaciones


    }
}
