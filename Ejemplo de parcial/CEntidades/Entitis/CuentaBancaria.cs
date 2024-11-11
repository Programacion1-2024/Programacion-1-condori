using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entitis
{
    public class CuentaBancaria
    {
        public int IdCuenta { get; set; }
        public string NroCuenta { get; set; }
        public decimal Saldo { get; set; }
        public int IdEstado { get; set; }
        public Cliente Cliente { get; set; }
        public int IdCliente { get; set; }
    }

    public static class EstadosCuenta
    {
        public static readonly Dictionary<int, string> IdEstado = new Dictionary<int, string>
    {
        { 1, "Activa" },
        { 2, "Inactiva" },
    };

    }
}

