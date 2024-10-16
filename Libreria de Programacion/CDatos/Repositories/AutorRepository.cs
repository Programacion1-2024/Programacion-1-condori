using CDatos.Contexts;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace CDatos.Repositories
{
    public class AutorRepository : Repository<Autor>, IAutorRepository
    {

        public AutorRepository(LibreriaContext context) : base(context)
        {
        }

        public void CreateAutor(Autor autor)
        {
            _context.Autor.Attach(autor);
        }

        public List<Autor> ObtenerAutores()
        {
            return _context.Autor.Include(a => a.Persona).ToList();
        }

        public void ActualizarAutor(Autor autor)
        {
            Update(autor); // Llama al método Update
            Save(); // Guarda los cambios
        }
    }
}
