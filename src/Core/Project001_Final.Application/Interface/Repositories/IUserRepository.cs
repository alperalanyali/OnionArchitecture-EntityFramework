using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Project001_Final.Application.Features.Queries.User.GetUsers;
using Project001_Final.Application.Features.Queries.User.Login;
using Project001_Final.Domain.Entities;

namespace Project001_Final.Application.Interface.Repositories
{
    public interface IUserRepository:IBaseRepository<User>
    {
        public Task<List<User>> ListAsync(GetAllUsersQuery query);
        public Task<User> Login(LoginQuery query);
        public Task<bool> CheckUserExists(LoginQuery query);
    }
}
