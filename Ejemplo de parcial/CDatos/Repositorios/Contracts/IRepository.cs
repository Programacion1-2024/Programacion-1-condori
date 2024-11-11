using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using CEntidades.Entitis;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Repositorios.Contracts
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> FindAll();
        Task<IEnumerable<T>> FindAllAsync();
        Task<IEnumerable<T>> FindByConditionAsync(Expression<Func<T, bool>> expression);
        IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression);
        T? GetById(int Id);
        Task<T> GetByIdAsync(int Id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task SaveAsync();
        bool Save();

    }
}
