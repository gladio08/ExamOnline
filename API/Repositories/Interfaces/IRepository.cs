using API.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> Get();
        Task<T> Get(int id);
        Task<int> Post(T entity);
        Task<bool> Put(T entity);
        Task<bool> Delete(int id);
    }
}
