using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.Status.CreateStatusCommand
{
    public class CreateStatusCommandHandler : IRequestHandler<CreateStatusCommand, ServiceResponse<int>>
    {
        IStatusRepository _statusRepository;
        IMapper _mapper;
        public CreateStatusCommandHandler(IStatusRepository statusRepository, IMapper mapper)
        {
            _statusRepository = statusRepository;
            _mapper = mapper;

        }
  
        public async Task<ServiceResponse<int>> Handle(CreateStatusCommand request, CancellationToken cancellationToken)
        {
            var status =  _mapper.Map<Domain.Entities.Status>(request);
            var result = await _statusRepository.AddAsync(status);
            return new ServiceResponse<int>(status.Id);
        }
    }
}
