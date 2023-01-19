using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.Form.GetFormById
{
    public class GetFormByIdHandler:IRequestHandler<GetFormByIdQuery,ServiceResponse<FormDto>>
    {
        IFormRepository _formRepo;
        IMapper _mapper;
        public GetFormByIdHandler(IFormRepository formRepo,IMapper mapper)
        {
            _formRepo = formRepo;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<FormDto>> Handle(GetFormByIdQuery request, CancellationToken cancellationToken)
        {
            var form = await _formRepo.GetByIdAsync(request.Id);
            var dto = _mapper.Map<FormDto>(form);

            return new ServiceResponse<FormDto>(dto);
        }
    }
}
