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
    public class CopiaRepository : Repository<Copia>, ICopiaRepository
    {
        private readonly LibreriaContext _context;
        public CopiaRepository (LibreriaContext context) : base(context) 
        {
            _context = context;
        }

        // Método para obtener las copias incluyendo el libro al que pertenecen
        public List<Copia> ObtenerCopiasConLibro()
        {
            return _context.Copia.Include(c => c.Libro).ToList();
        }

        // Método para obtener las copias incluyendo los préstamos asociados
        public List<Copia> ObtenerCopiasConPrestamos()
        {
            return _context.Copia.Include(c => c.Prestamos).ToList();
        }



    }
}
