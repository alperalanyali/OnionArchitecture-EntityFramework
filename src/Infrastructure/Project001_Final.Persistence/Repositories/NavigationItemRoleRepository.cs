using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project001_Final.Application.Features.Queries.NavigationItemRole.GetAllUserNavigationItemRole;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Domain.Entities;
using Project001_Final.Persistence.Context;

namespace Project001_Final.Persistence.Repositories
{
    public class NavigationItemRoleRepository : BaseRepository<NavigationItemRole>, INavigationItemRoleRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public NavigationItemRoleRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<NavigationItemRole>> ListAsync()
        {
            return await _dbContext.Set<NavigationItemRole>().Include("Role").Include("NavigationItem").ToListAsync();
        }

        public  async Task<List<NavigationItemRole>> ListAsync(GetAllUserNavigationItemRoleQuery query)
        {
            return await _dbContext.Set<NavigationItemRole>().Include("Role").Include("NavigationItem").Where( x => 
                (query.SearchInput != null && (x.NavigationItem.NavigationName.ToLower().Contains(query.SearchInput.ToLower())
                ||  x.Role.Name.ToLower().Contains(query.SearchInput.ToLower())))

                )
                .ToListAsync();
        }
    } 
}
