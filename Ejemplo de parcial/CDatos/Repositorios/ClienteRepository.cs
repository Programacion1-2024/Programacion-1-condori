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
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(BancoContext context) : base(context)
        {
        }

        public void CreateCliente(Cliente clienteNuevo)
        {
            _context.Clientes.Attach(clienteNuevo);
        }

        public List<Cliente> ObtenerClientes()
        {
            return _context.Clientes.ToList();
        }

        public void ActualizarCliente(Cliente clienteModificar)
        {
            Update(clienteModificar); // Llama al método Update
            Save(); // Guarda los cambios
        }
        public Cliente BuscarPorId(int IdCliente)
        {
            return _context.Clientes.Find(IdCliente);
        }

        public void EliminarCliente(Cliente clienteEliminar)
        {
            Delete(clienteEliminar);
            Save();
        }
    }
}
