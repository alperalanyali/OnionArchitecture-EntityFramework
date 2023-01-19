using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.Language.GetLanguageByIdQuery
{
    public class GetLanguageByIdQueryHandle : IRequestHandler<GetLanguageByIdQuery, ServiceResponse<LanguageDto>>
    {
        ILanguageRepository _langRepo;
        IMapper _mapper;
        public GetLanguageByIdQueryHandle(ILanguageRepository langRepo,IMapper mapper)
        {
            _langRepo = langRepo;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<LanguageDto>> Handle(GetLanguageByIdQuery request, CancellationToken cancellationToken)
        {
            var language = await _langRepo.GetByIdAsync(request.Id);
            var dto = _mapper.Map<LanguageDto>(language);

            return new ServiceResponse<LanguageDto>(dto);
        }
    }
}
