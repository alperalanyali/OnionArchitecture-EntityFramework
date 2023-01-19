using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project001_Final.Application.Features.Queries.Status.GetAllStatus;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Domain.Entities;
using Project001_Final.Persistence.Context;

namespace Project001_Final.Persistence.Repositories
{
    public class StatusRepository:BaseRepository<Status>, IStatusRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public StatusRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Status>> ListAsync(GetAllStatusQuery query)
        {
            return await _dbContext.Set<Status>().Where(x =>
                query.SearchInput != null && ( x.Code.ToLower().Contains(query.SearchInput.ToLower()) || x.Name.ToLower().Contains(query.SearchInput.ToLower()))
                && x.IsActive.Equals(query.IsActive)
            ).ToListAsync();
        }   
    }
}
