using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;


namespace Project001_Final.Application.Features.Queries.User.Login
{
    public class LoginQueryHandle : IRequestHandler<LoginQuery, ServiceResponse<bool>>
    {
        IUserRepository _userRepo;
        public LoginQueryHandle(IUserRepository userRepository)
        {
            _userRepo = userRepository;
        }
        public async Task<ServiceResponse<bool>> Handle(LoginQuery request, CancellationToken cancellationToken)
        {
            var result = await _userRepo.Login(request);
            return new ServiceResponse<bool>(true);
        }
    }
}
