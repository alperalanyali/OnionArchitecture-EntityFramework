using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.Role.UpdateRoleCommand
{
    public class UpdateRoleCommandHandler:IRequestHandler<UpdateRoleCommand,ServiceResponse<bool>>
    {
        IRoleRepository _roleRepo;
        IMapper _mapper;

        public UpdateRoleCommandHandler(IRoleRepository roleRepo,IMapper mapper)
        {
            _roleRepo = roleRepo;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<bool>> Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
        {
            var role = _mapper.Map<Domain.Entities.Role>(request);
            var result = await _roleRepo.UpdateAsync(role);

            return new ServiceResponse<bool>(result);

        }
    }
}
