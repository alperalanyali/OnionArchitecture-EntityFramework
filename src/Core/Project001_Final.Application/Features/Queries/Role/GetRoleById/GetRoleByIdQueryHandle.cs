using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.Role.GetRoleById
{
    public class GetRoleByIdQueryHandle : IRequestHandler<GetRoleByIdQuery, ServiceResponse<RoleDto>>
    {
        IRoleRepository _roleRepo;
        IMapper _mapper;
        public GetRoleByIdQueryHandle(IRoleRepository roleRepo,IMapper mapper)
        {
            _roleRepo = roleRepo;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<RoleDto>> Handle(GetRoleByIdQuery request, CancellationToken cancellationToken)
        {
            var role = await _roleRepo.GetByIdAsync(request.Id);
            var dto = _mapper.Map<RoleDto>(role);

            return new ServiceResponse<RoleDto>(dto);
        }
    }
}
