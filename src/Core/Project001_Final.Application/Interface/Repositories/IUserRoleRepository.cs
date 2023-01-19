using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Project001_Final.Application.Features.Queries.UserRole.GetAllUserRole;
using Project001_Final.Domain.Entities;

namespace Project001_Final.Application.Interface.Repositories
{
    public interface IUserRoleRepository:IBaseRepository<UserRole>
    {
        public  Task<List<UserRole>> ListAsync();
        public Task<List<UserRole>> ListAsync(GetAllUserRoleQuery query);
    }
}
