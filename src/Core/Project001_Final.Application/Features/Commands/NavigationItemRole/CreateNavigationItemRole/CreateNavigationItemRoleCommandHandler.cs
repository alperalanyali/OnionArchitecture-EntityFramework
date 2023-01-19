using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.NavigationItemRole.CreateNavigationItemRole
{
    public class CreateNavigationItemRoleCommandHandler : IRequestHandler<CreateNavigationItemRoleCommand, ServiceResponse<int>>
    {
        INavigationItemRoleRepository _navRoleRepository;
        IMapper _mapper;

        public CreateNavigationItemRoleCommandHandler(INavigationItemRoleRepository navRoleRepo,IMapper mapper)
        {
            _navRoleRepository = navRoleRepo;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<int>> Handle(CreateNavigationItemRoleCommand request, CancellationToken cancellationToken)
        {
            var navRole = _mapper.Map<Domain.Entities.NavigationItemRole>(request);
            await _navRoleRepository.AddAsync(navRole);
            return new ServiceResponse<int>(navRole.Id);
        }
    }
}
