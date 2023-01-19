using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Project001_Final.Application.Features.Queries.NavigationItem.GetAllNavigationItem;
using Project001_Final.Domain.Entities;

namespace Project001_Final.Application.Interface.Repositories
{
    public interface INavigationItemRepository:IBaseRepository<NavigationItem>
    {
        public Task<List<NavigationItem>> ListAsync(GetAllNavigationItemQuery getAllNavigationItem);
    }
}
