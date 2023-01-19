using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Project001_Final.Domain.Common;

namespace Project001_Final.Application.Interface.Repositories
{
    public interface IBaseRepository<T>where T:BaseEntity
    {
         Task<List<T>> ListAsync();
         //Task<List<T>> ListIncludedAsync();
         Task<T> GetByIdAsync(int id);
         //Task<T> GetByIdIncludedAsync(int id);
         Task<T> AddAsync(T entity);
         Task<bool> RemoveAsync(T entity);
         Task<bool> UpdateAsync(T entity);
         Task<List<T>> ListAsync(string tableName);
    }
}
