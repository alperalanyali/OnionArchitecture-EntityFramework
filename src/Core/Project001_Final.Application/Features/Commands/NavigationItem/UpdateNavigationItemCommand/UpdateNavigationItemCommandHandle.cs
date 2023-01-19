using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.NavigationItem.UpdateNavigationItemCommand
{
    public class UpdateNavigationItemCommandHandle:IRequestHandler<UpdateNavigationItemCommand,ServiceResponse<bool>>
    {
        INavigationItemRepository _navItemRepo;
        IMapper _mapper;

        public UpdateNavigationItemCommandHandle(INavigationItemRepository navItemRepo,IMapper mapper)
        {
            _navItemRepo = navItemRepo;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<bool>> Handle(UpdateNavigationItemCommand request, CancellationToken cancellationToken)
        {
            var navItem = _mapper.Map<Domain.Entities.NavigationItem>(request);
            var result = await _navItemRepo.UpdateAsync(navItem);

            return new ServiceResponse<bool>(result);
        }
    }
}
