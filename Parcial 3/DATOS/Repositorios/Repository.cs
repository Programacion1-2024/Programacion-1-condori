using DATOS.Context;
using DATOS.Repositorios.Contracts;

namespace DATOS
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DataContext _context;

        public Repository(DataContext context)
        {
            this._context = context;
        }

        public IEnumerable<T> GetAll()
        {
            return this._context.Set<T>().ToList();
        }
        public T? GetById(int id)
        {
            return this._context.Set<T>().Find(id);
        }
        public void Create(T entity)
        {
            this._context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this._context.Set<T>().Update(entity);
        }
        public void Delete(T entity)
        {
            this._context.Set<T>().Remove(entity);
        }
        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
