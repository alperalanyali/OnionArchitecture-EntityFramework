using System;
using System.Threading;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.UserRole.GetUserRoleById
{
    public class GetUserRoleByIdQueryHandle : IRequestHandler<GetUserRoleByIdQuery, ServiceResponse<UserRoleDto>>
    {
        IUserRoleRepository _userRoleRepo;
        IMapper _mapper;
        public GetUserRoleByIdQueryHandle(IUserRoleRepository userRoleRepo,IMapper mapper)
        {
            _userRoleRepo = userRoleRepo;
            _mapper = mapper;
        }

        public async System.Threading.Tasks.Task<ServiceResponse<UserRoleDto>> Handle(GetUserRoleByIdQuery request, CancellationToken cancellationToken)
        {
            var userRole = await _userRoleRepo.GetByIdAsync(request.Id);
            var dto = _mapper.Map<UserRoleDto>(userRole);

            return new ServiceResponse<UserRoleDto>(dto);
        }
    }
}
