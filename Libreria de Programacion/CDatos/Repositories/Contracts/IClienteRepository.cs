﻿using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Repositories.Contracts
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        void CreateCliente(Cliente cliente);

        List<Cliente> ObtenerClientes();


        void ActualizarCliente(Cliente cliente);
    }
}
