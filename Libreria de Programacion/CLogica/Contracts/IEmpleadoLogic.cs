using CDatos.Repositories;
using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    public interface IEmpleadoLogic
    {
        List<dynamic> ObtenerEmpleadosParaListado();
        List<Empleado> ObtenerEmpleados();
        void AltaEmpleado(string nombre, string apellido, string documento, string telefono, string email, string cargo, string sueldo);

        void ActualizarEmpleado(string idEmpleado, string nombre, string apellido, string documento, string telefono, string email, string cargo, string sueldo);

        void EliminarEmpleado(string idEmpleado);

        Empleado BuscarEmpleado(int idEmpleado);

    }
}
