using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.Role.GetAllRoles
{
    public class GetAllUserQueryHandler : IRequestHandler<GetAllRoleQuery, ServiceResponse<List<RoleDto>>>
    {
        IRoleRepository _roleRepository;
        IMapper _mapper;
        public GetAllUserQueryHandler(IRoleRepository roleRepository,IMapper mapper)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<RoleDto>>> Handle(GetAllRoleQuery request, CancellationToken cancellationToken)
        {
            var roles = await _roleRepository.ListAsync(request);

            var dtos = _mapper.Map<List<RoleDto>>(roles);                     
            return new ServiceResponse<List<RoleDto>>(dtos);
        }
    }
}
