using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.Status.GetStatusById
{
    public class GetStatusByIdQueryHandle : IRequestHandler<GetStatusByIdQuery, ServiceResponse<StatusDto>>
    {
        IStatusRepository _statusRepo;
        IMapper _mapper;
        public GetStatusByIdQueryHandle(IStatusRepository statusRepo,IMapper mapper)
        {
            _statusRepo = statusRepo;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<StatusDto>> Handle(GetStatusByIdQuery request, CancellationToken cancellationToken)
        {
            var status = await _statusRepo.GetByIdAsync(request.Id);
            var dto = _mapper.Map<StatusDto>(status);

            return new ServiceResponse<StatusDto>(dto);
        }
    }
}
