using System;
using System.Threading.Tasks;
using Project001_Final.Application.Features.Queries.User.Login;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Interface.JWT
{
    public interface IJwtAuthenticationManager
    {
        Task<ServiceResponse<string>> Authencate(IUserRepository userRepo,LoginQuery login);
    }
}
