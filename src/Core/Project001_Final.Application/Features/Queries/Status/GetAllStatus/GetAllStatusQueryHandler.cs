using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.Status.GetAllStatus
{
    public class GetAllStatusQueryHandler : IRequestHandler<GetAllStatusQuery, ServiceResponse<List<StatusDto>>>
    {
        IStatusRepository _statusRepository;
        IMapper _mapper;

        public GetAllStatusQueryHandler(IStatusRepository statusRepository,IMapper mapper)
        {
            _statusRepository = statusRepository;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<List<StatusDto>>> Handle(GetAllStatusQuery request, CancellationToken cancellationToken)
        {
            var status =await _statusRepository.ListAsync(request);

            var dtos = _mapper.Map<List<StatusDto>>(status);


            return new ServiceResponse<List<StatusDto>>(dtos);
        }
    }
}
