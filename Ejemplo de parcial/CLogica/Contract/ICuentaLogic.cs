using CEntidades.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contract
{
    public interface ICuentaLogic
    {
        List<CuentaBancaria> ObtenerCuentas();
        List<dynamic> ObtenerCuentasParaListado();
        public void AltaCuenta(string NroCuenta, decimal Saldo, int IdEstado, int IdCliente);
        void ActualizarCuenta(string IdCuenta, string NroCuenta, decimal Saldo, int IdEstado, int IdCliente);
        CuentaBancaria BuscarPorId(int IdCuenta);
        bool CuentaExiste(string NroCuenta);
    }
}
