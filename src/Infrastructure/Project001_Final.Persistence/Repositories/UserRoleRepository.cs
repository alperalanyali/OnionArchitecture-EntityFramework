using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project001_Final.Application.Features.Queries.UserRole.GetAllUserRole;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Domain.Entities;
using Project001_Final.Persistence.Context;

namespace Project001_Final.Persistence.Repositories
{
    public class UserRoleRepository:BaseRepository<UserRole>,IUserRoleRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public UserRoleRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<UserRole>> ListAsync()
        {
            return await _dbContext.Set<UserRole>().Include("Role").Include("User").ToListAsync();
        }

        public Task<List<UserRole>> ListAsync(GetAllUserRoleQuery query)
        {
            throw new NotImplementedException();
        }
    }
}
