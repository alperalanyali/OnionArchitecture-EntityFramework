using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.UserRole.UpdateUserRoleCommand
{
    public class UpdateUserRoleCommandHandler : IRequestHandler<UpdateUserRoleCommand, ServiceResponse<bool>>
    {
        IUserRoleRepository _userRoleRepo;
        IMapper _mapper;
        public UpdateUserRoleCommandHandler(IUserRoleRepository userRoleRepo,IMapper mapper)
        {
            _userRoleRepo = userRoleRepo;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<bool>> Handle(UpdateUserRoleCommand request, CancellationToken cancellationToken)
        {
            var userRole = _mapper.Map<Domain.Entities.UserRole>(request);
            var result = await _userRoleRepo.UpdateAsync(userRole);

            return new ServiceResponse<bool>(result);
        }
    }
}
