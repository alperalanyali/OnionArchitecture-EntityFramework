        using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.Form.GetAllForm
{
    public class GetAllFormQueryHandler : IRequestHandler<GetAllFormQuery, ServiceResponse<List<FormDto>>>
    {
        IFormRepository _formRepo;
        IMapper _mapper;

        public GetAllFormQueryHandler(IFormRepository formRepo,IMapper mapper)
        {
            _formRepo = formRepo;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<FormDto>>> Handle(GetAllFormQuery request, CancellationToken cancellationToken)
        {
            var forms = await _formRepo.ListAsync(request);
            var dtos = _mapper.Map<List<FormDto>>(forms);
            return new ServiceResponse<List<FormDto>>(dtos);
        }
    }
}
