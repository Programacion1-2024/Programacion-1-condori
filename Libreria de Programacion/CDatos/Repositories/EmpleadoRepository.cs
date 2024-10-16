using CDatos.Contexts;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Repositories
{
    public class EmpleadoRepository : Repository<Empleado>, IEmpleadoRepository
    {
        public EmpleadoRepository(LibreriaContext context) : base(context)
        {

        }
        public void CreateEmpleado(Empleado empleado)
        {
            _context.Empleado.Attach(empleado);
        }

        public List<Empleado> ObtenerEmpleados()
        {
            return _context.Empleado.Include(a => a.Persona).ToList();
        }
        public void ActualizarEmpleado(Empleado empleado)
        {
            Update(empleado); // Llama al método Update
            Save(); // Guarda los cambios
        }

    }
}
