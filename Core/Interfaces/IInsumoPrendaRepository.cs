using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IInsumoPrendaRepository<T>
    {
        Task<(int totalRegistros, IEnumerable<T> registros)> GetAllAsync(int pageindex, int pageSize);
        IEnumerable<T> Find(Func<T, bool> predicate);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Update(T entity);
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entities);
    }
}

