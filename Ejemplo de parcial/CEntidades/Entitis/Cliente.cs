﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entitis
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public ICollection<TarjetaCredito> TarjetaCreditos { get; set; } 
        public ICollection<CuentaBancaria> CuentaBancarias { get; set;  }
    }
}
