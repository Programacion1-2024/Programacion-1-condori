using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    public interface IClienteLogic
    {
        List<dynamic> ObtenerClientesParaListado();
        List<Cliente> ObtenerClientes();

        void AltaCliente(string nombre, string apellido, string nacionalidad, string documento, string email, string telefono, string esSocio, string pagaIva);

        void ActualizarCliente(string idCliente, string nombre, string apellido, string nacionalidad, string documento, string email, string telefono, string esSocio, string pagaIva);

        void EliminarCliente(string idCliente);

        Cliente BuscarCliente(int idCliente);

    }
}
