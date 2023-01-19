using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.UserRole
{
    public class CreateUserRoleCommandHandler : IRequestHandler<CreateUserRoleCommand, ServiceResponse<int>>
    {
        IUserRoleRepository _userRoleRepository;
        IMapper _mapper;
        public CreateUserRoleCommandHandler(IUserRoleRepository userRoleRepository,IMapper mapper)
        {
            _userRoleRepository = userRoleRepository;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<int>> Handle(CreateUserRoleCommand request, CancellationToken cancellationToken)
        {
            var userRole = _mapper.Map<Domain.Entities.UserRole>(request);
            await _userRoleRepository.AddAsync(userRole);
            return new ServiceResponse<int>(userRole.Id);
        }
    }
}
