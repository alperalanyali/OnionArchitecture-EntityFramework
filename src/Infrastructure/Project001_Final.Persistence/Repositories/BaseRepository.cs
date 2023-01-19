using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Domain.Common;
using Project001_Final.Persistence.Context;

namespace Project001_Final.Persistence.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _dbContext;
        public BaseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;


        }

        public  async Task<List<T>> ListAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> ListAsync(string tableName)
        {
            return await _dbContext.Set<T>().Include(tableName).ToListAsync();
        }

        public async Task<bool> RemoveAsync(T entity)
        {
            var _entity = await _dbContext.Set<T>().FindAsync(entity.Id);
            _dbContext.Set<T>().Remove(_entity);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateAsync(T entity)
        {            
            _dbContext.Set<T>().Update(entity);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public Task<List<T>> ListIncludedAsync()
        {
            throw new NotImplementedException();
        }

    
    }
}
