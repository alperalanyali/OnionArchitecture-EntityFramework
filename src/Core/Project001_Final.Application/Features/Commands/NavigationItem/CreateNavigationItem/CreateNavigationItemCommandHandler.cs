using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.NavigationItem.CreateNavigationItem
{
    public class CreateNavigationItemCommandHandler : IRequestHandler<CreateNavigationItemCommand, ServiceResponse<int>>
    {
        INavigationItemRepository _navRepository;
        IMapper _mapper;
        public CreateNavigationItemCommandHandler(INavigationItemRepository navRepository,IMapper mapper)
        {
            _navRepository = navRepository;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<int>> Handle(CreateNavigationItemCommand request, CancellationToken cancellationToken)
        {
            var navItem = _mapper.Map<Domain.Entities.NavigationItem>(request);
            await _navRepository.AddAsync(navItem);

            return new ServiceResponse<int>(navItem.Id);
        }
    }
}
