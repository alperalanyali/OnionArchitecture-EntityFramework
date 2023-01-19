using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.NavigationItem.GetNavigationItemById
{
    public class GetNavigationItemByIdQueryHandle:IRequestHandler<GetNavigationItemByIdQuery,ServiceResponse<NavigationItemDto>>
    {

        INavigationItemRepository _navItemRepo;
        IMapper _mapper;
        public GetNavigationItemByIdQueryHandle(INavigationItemRepository navItemRepo,IMapper mapper)
        {
            _navItemRepo = navItemRepo;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<NavigationItemDto>> Handle(GetNavigationItemByIdQuery request, CancellationToken cancellationToken)
        {
            var navItem = await _navItemRepo.GetByIdAsync(request.Id);
            var dto = _mapper.Map<NavigationItemDto>(navItem);

            return new ServiceResponse<NavigationItemDto>(dto);
        }
    }
}
