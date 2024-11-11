using CDatos.Context;
using CDatos.Repositorios.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Repositorios
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected BancoContext _context { get; set; }

        public Repository(BancoContext context)
        {
            this._context = context;
        }

        public IEnumerable<T> FindAll()
        {
            return this._context.Set<T>().ToList();
        }

        public async Task<IEnumerable<T>> FindAllAsync()
        {
            return await this._context.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> FindByConditionAsync(Expression<Func<T, bool>> expression)
        {
            return await this._context.Set<T>().Where(expression).ToListAsync();
        }

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this._context.Set<T>().Where(expression).ToList();
        }

        public T? GetById(int Id)
        {
            return this._context.Set<T>().Find(Id);
        }

        public async Task<T> GetByIdAsync(int Id)
        {
            return await this._context.Set<T>().FindAsync(Id);
        }

        public void Create (T entity)
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

        public async Task SaveAsync()
        {
            try
            {
                await this._context.SaveChangesAsync();
                return;
            }
            catch
            {
                throw new Exception("Error saving changes.");
            }
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
