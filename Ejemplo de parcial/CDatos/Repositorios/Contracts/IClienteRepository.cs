    using CEntidades.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Repositorios.Contracts
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        void CreateCliente(Cliente clienteNuevo);
        List<Cliente> ObtenerClientes();
        void ActualizarCliente(Cliente clienteModificar);

        void EliminarCliente(Cliente clienteEliminar);

        Cliente? BuscarPorId(int IdCliente);
    }
}
