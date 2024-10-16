using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Repositories.Contracts
{
    public interface IEmpleadoRepository : IRepository<Empleado>
    {
        void CreateEmpleado(Empleado empelado);

        List<Empleado> ObtenerEmpleados();
        void ActualizarEmpleado(Empleado empleado);

    }
}
