using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.NavigationItem.GetAllNavigationItem
{
    public class GetAllNavigationItemQueryHandler : IRequestHandler<GetAllNavigationItemQuery, ServiceResponse<List<NavigationItemDto>>>
    {
        INavigationItemRepository _navItemRepo;
        IMapper _mapper;
        public GetAllNavigationItemQueryHandler(INavigationItemRepository navItemRepo, IMapper mapper)
        {
            _navItemRepo = navItemRepo;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<NavigationItemDto>>> Handle(GetAllNavigationItemQuery request, CancellationToken cancellationToken)
        {
            var navItems = await _navItemRepo.ListAsync(request);

            var dtos = _mapper.Map<List<NavigationItemDto>>(navItems);

            return new ServiceResponse<List<NavigationItemDto>>(dtos);
        }
    }
}
