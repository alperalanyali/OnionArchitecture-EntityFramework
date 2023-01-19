using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.NavigationItemRole.GetNavigationItemRoleById
{
    public class GetNavigationItemRoleByIdQueryHandle : IRequestHandler<GetNavigationItemRoleByIdQuery, ServiceResponse<NavigationItemRoleDto>>
    {
        INavigationItemRoleRepository _navItemRole;
        IMapper _mapper;

        public GetNavigationItemRoleByIdQueryHandle(INavigationItemRoleRepository navItemRole,IMapper mapper)
        {
            _navItemRole = navItemRole;
            _mapper = mapper;
        }

        
        public async Task<ServiceResponse<NavigationItemRoleDto>> Handle(GetNavigationItemRoleByIdQuery request, CancellationToken cancellationToken)
        {
            var navItemRole = await _navItemRole.GetByIdAsync(request.Id);
            var dto = _mapper.Map<NavigationItemRoleDto>(navItemRole);

            return new ServiceResponse<NavigationItemRoleDto>(dto);
        }
    }
}
