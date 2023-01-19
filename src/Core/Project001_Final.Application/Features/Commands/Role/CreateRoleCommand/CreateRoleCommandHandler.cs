using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.Role.CreateRoleCommand
{
    public class CreateRoleCommandHandler : IRequestHandler<CreateRoleCommand, ServiceResponse<int>>
    {
        IRoleRepository _roleRepository;
        IMapper _mapper;
        public CreateRoleCommandHandler(IRoleRepository roleRepository,IMapper mapper)
        {
            _mapper = mapper;
            _roleRepository = roleRepository;
        }
        public async Task<ServiceResponse<int>> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
        {
            var role = _mapper.Map<Domain.Entities.Role>(request);
            await _roleRepository.AddAsync(role);
            return new ServiceResponse<int>(role.Id);
        }
    }
}
