﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS.Repositorios.Contracts
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T? GetById(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        bool Save();
    }
}
