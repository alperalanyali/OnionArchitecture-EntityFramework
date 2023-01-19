using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.NavigationItemRole.UpdateNavigationItemRoleCommand
{
    public class UpdateNavigationItemRoleCommandHandle:IRequestHandler<UpdateNavigationItemRoleCommand,ServiceResponse<bool>>
    {
        INavigationItemRoleRepository _navITemRoleRepo;
        IMapper _mapper;

        public UpdateNavigationItemRoleCommandHandle(INavigationItemRoleRepository navITemRoleRepo, IMapper mapper)
        {
            _navITemRoleRepo = navITemRoleRepo;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<bool>> Handle(UpdateNavigationItemRoleCommand request, CancellationToken cancellationToken)
        {
            var navItemRole =_mapper.Map<Domain.Entities.NavigationItemRole>(request);
            var result = await _navITemRoleRepo.UpdateAsync(navItemRole);

            return new ServiceResponse<bool>(result);
        }
    }
}
