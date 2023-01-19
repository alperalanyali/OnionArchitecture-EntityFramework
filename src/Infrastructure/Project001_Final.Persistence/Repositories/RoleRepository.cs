    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project001_Final.Application.Features.Queries.Role.GetAllRoles;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Domain.Entities;
using Project001_Final.Persistence.Context;

namespace Project001_Final.Persistence.Repositories
{
    public class RoleRepository:BaseRepository<Role>,IRoleRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public RoleRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Role>> ListAsync(GetAllRoleQuery getAllRoleQuery)
        {
            return await _dbContext.Set<Role>().Include("Status").Where(x =>
                (getAllRoleQuery.SearchInput != null && (x.Code.ToLower().Contains(getAllRoleQuery.SearchInput.ToLower()) || x.Name.ToLower().Contains(getAllRoleQuery.SearchInput.ToLower())) || x.Status.Name.ToLower().Contains(getAllRoleQuery.SearchInput.ToLower()) )
               && (getAllRoleQuery.IsActive != null && x.IsActive.Equals(getAllRoleQuery.IsActive))
            ).ToListAsync();
        }
    }
}
