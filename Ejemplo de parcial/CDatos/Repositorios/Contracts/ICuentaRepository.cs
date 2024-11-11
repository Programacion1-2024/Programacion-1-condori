using CEntidades.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Repositorios.Contracts
{
    public interface ICuentaRepository : IRepository<CuentaBancaria>
    {
        void CreateCuenta(CuentaBancaria cuentaNueva);
        List<CuentaBancaria> ObtenerCuentas();
        void ActualizarCuenta(CuentaBancaria cuentaModificar);
       // void EliminarCuenta(CuentaBancaria cuentaEliminar);
        CuentaBancaria? BuscarPorId(int IdCuenta);
        IEnumerable<CuentaBancaria> FindByCuenta(string NroCuenta);
    }
}
