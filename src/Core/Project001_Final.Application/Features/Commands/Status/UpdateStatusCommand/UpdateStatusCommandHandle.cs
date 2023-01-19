using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.Status.UpdateStatusCommand
{
    public class UpdateStatusCommandHandle:IRequestHandler<UpdateStatusCommand,ServiceResponse<bool>>
    {
        IStatusRepository _statusRepo;
        IMapper _mapper;
        public UpdateStatusCommandHandle(IStatusRepository statusRepository,IMapper mapper)
        {
            _statusRepo = statusRepository;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<bool>> Handle(UpdateStatusCommand request, CancellationToken cancellationToken)
        {
            var status = _mapper.Map<Domain.Entities.Status>(request);
            var result = await _statusRepo.UpdateAsync(status);

            return new ServiceResponse<bool>(result);
        }
    }
}
