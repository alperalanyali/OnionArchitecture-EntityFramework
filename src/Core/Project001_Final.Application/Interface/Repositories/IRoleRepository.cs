using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Project001_Final.Application.Features.Queries.Role.GetAllRoles;
using Project001_Final.Domain.Entities;

namespace Project001_Final.Application.Interface.Repositories
{
    public interface IRoleRepository:IBaseRepository<Role>
    {
        public Task<List<Role>> ListAsync(GetAllRoleQuery getAllFormQuery);
    }
}
