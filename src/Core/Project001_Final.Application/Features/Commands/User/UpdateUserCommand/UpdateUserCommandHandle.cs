using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.User.UpdateUserCommand
{
    public class UpdateUserCommandHandle : IRequestHandler<UpdateUserCommand, ServiceResponse<bool>>
    {
        IUserRepository _userRepo;
        IMapper _mapper;
        public UpdateUserCommandHandle(IUserRepository userRepo,IMapper mapper)
        {
            _userRepo = userRepo;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<bool>> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<Domain.Entities.User>(request);
            var result = await _userRepo.UpdateAsync(user);

            return new ServiceResponse<bool>(result);
        }
    }
}
