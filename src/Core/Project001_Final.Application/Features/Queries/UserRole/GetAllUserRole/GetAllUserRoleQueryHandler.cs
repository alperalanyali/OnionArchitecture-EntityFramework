using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.UserRole.GetAllUserRole
{
    public class GetAllUserRoleQueryHandler : IRequestHandler<GetAllUserRoleQuery, ServiceResponse<List<UserRoleDto>>>
    {
        IUserRoleRepository _userRoleRepository;
        IMapper _mapper;
        public GetAllUserRoleQueryHandler(IUserRoleRepository userRoleRepository,IMapper mapper)
        {
            _userRoleRepository = userRoleRepository;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<List<UserRoleDto>>> Handle(GetAllUserRoleQuery request, CancellationToken cancellationToken)
        {
            var userRoles = await _userRoleRepository.ListAsync();

            var dtos = _mapper.Map<List<UserRoleDto>>(userRoles);

            return new ServiceResponse<List<UserRoleDto>>(dtos);
        }
    }
}
