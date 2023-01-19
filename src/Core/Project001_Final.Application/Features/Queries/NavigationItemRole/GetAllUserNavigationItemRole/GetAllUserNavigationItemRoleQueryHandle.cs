using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.NavigationItemRole.GetAllUserNavigationItemRole
{
    public class GetAllUserNavigationItemRoleQueryHandle : IRequestHandler<GetAllUserNavigationItemRoleQuery, ServiceResponse<List<NavigationItemRoleDto>>>
    {
        INavigationItemRoleRepository _navItemRoleRepo;
        IMapper _mapper;
        public GetAllUserNavigationItemRoleQueryHandle(INavigationItemRoleRepository navItemRoleRepo,IMapper mapper)
        {
            _navItemRoleRepo = navItemRoleRepo;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<List<NavigationItemRoleDto>>> Handle(GetAllUserNavigationItemRoleQuery request, CancellationToken cancellationToken)
        {
            var navItemRoles = await _navItemRoleRepo.ListAsync(request);
            var dtos = _mapper.Map<List<NavigationItemRoleDto>>(navItemRoles);
            return new ServiceResponse<List<NavigationItemRoleDto>>(dtos);
        }
    }
}
