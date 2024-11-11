using CEntidades.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contract
{
    public interface IClienteLogic
    {
        List<Cliente> ObtenerClientes();

        List<dynamic> ObtenerClientesParaListado();

        void AltaCliente(string Nombre, string Apellido, string Dni);
        void ActualizarCliente(string IdCliente, string Nombre, string Apellido, string Dni);
        void EliminarCliente(string IdCliente);
        Cliente BuscarPorId(int idCliente);

    }
}
