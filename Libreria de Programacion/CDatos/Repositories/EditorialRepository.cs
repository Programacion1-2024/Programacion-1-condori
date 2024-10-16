using CDatos.Contexts;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CDatos.Repositories
{
    public class EditorialRepository : Repository<Editorial>, IEditorialRepository
    {
        public EditorialRepository(LibreriaContext context) : base(context)
        {
        }

        // Si necesitas agregar métodos específicos de Editorial, lo haces aquí.
        public List<Editorial> ObtenerEditoriales()
        {
            return _context.Editorial.ToList();
        }
    }
}

