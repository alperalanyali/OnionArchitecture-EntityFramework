using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project001_Final.Application.Features.Queries.NavigationItem.GetAllNavigationItem;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Domain.Entities;
using Project001_Final.Persistence.Context;

namespace Project001_Final.Persistence.Repositories
{
    public class NavigationItemRepository : BaseRepository<NavigationItem>, INavigationItemRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public NavigationItemRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<NavigationItem>> ListAsync()
        {
            return await _dbContext.Set<NavigationItem>().Include("Form").ToListAsync();
        }

        public async Task<List<NavigationItem>> ListAsync(GetAllNavigationItemQuery getAllNavigationItem)
        {
            return await _dbContext.Set<NavigationItem>()
                                                        .Include("Form")
                                                        .Where(x => 
                                                            (getAllNavigationItem.SearchInput != null && (x.NavigationName.ToLower().Contains(getAllNavigationItem.SearchInput.ToLower())
                                                            || x.Form.FormName.ToLower().Contains(getAllNavigationItem.SearchInput.ToLower())
                                                            || x.TopNavItemId.Equals(getAllNavigationItem.SearchInput)
                                                            ))
                                                        && (getAllNavigationItem.IsActive != null && x.IsActive == getAllNavigationItem.IsActive)
                                                        ).ToListAsync();
       }
    }
}
