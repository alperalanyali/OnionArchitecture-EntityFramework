using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Project001_Final.Application.Features.Queries.NavigationItemRole.GetAllUserNavigationItemRole;
using Project001_Final.Domain.Entities;

namespace Project001_Final.Application.Interface.Repositories
{
    public interface INavigationItemRoleRepository:IBaseRepository<NavigationItemRole>
    {
        public Task<List<NavigationItemRole>> ListAsync();
        public Task<List<NavigationItemRole>> ListAsync(GetAllUserNavigationItemRoleQuery query);


    }
}
