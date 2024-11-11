using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entitis
{
    public class TarjetaCredito
    {
        public string IdTarjeta { get; set; }
        public string NroTarjeta { get; set; }
        public string LimiteCredito { get; set; }
        public string SaldoDisponible { get; set; }
        public string Estado { get; set; }
        public int IdCliente { get; set; }
        public Cliente? Cliente { get; set; }

    }
}
