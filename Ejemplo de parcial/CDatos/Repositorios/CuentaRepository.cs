using CDatos.Context;
using CDatos.Repositorios.Contracts;
using CEntidades.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Repositorios
{
    public class CuentaRepository : Repository<CuentaBancaria>, ICuentaRepository
    {
        public CuentaRepository(BancoContext context) : base(context) 
        { }
        public void CreateCuenta(CuentaBancaria cuentaNueva)
        {
            _context.CuentaBancarias.Attach(cuentaNueva);
        }

        public List<CuentaBancaria> ObtenerCuentas()
        {
            return _context.CuentaBancarias.ToList();
        }

        public void ActualizarCuenta(CuentaBancaria cuentaModificar)
        {
            Update(cuentaModificar); // Llama al método Update
            Save(); // Guarda los cambios
        }
        public CuentaBancaria BuscarPorId(int IdCuenta)
        {
            return _context.CuentaBancarias.Find(IdCuenta);
        }

        public IEnumerable<CuentaBancaria> FindByCuenta(string NroCuenta)
        {
            return FindByCondition(c => c.NroCuenta == NroCuenta);
        }
    }
}
