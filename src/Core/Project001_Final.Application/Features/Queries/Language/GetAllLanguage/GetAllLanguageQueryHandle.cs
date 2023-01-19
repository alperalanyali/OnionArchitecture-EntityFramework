using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.Language.GetAllLanguage
{
    public class GetAllLanguageQueryHandle : IRequestHandler<GetAllLanguageQuery, ServiceResponse<List<LanguageDto>>>
    {
        ILanguageRepository _languageRepo;
        IMapper _mapper;
        public GetAllLanguageQueryHandle(ILanguageRepository languageRepo,IMapper mapper)
        {
            _languageRepo = languageRepo;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<LanguageDto>>> Handle(GetAllLanguageQuery request, CancellationToken cancellationToken)
        {
            var dtos = new List<LanguageDto>();
            var serviceResponse = new ServiceResponse<List<LanguageDto>>(dtos);
            try
            {
                var languages = await _languageRepo.ListAsync(request);
                dtos = _mapper.Map<List<LanguageDto>>(languages);
                serviceResponse.Value = dtos;
             
            }
            catch(Exception ex)
            {
                serviceResponse.Message = ex.Message;
                serviceResponse.StackTrace = ex.StackTrace;
                if(ex.InnerException != null)
                {
                    serviceResponse.InnerMessage = ex.InnerException.Message;
                    serviceResponse.InnerStackTrace = ex.InnerException.StackTrace;
                }                         
            }

            return serviceResponse;
        }
    }
}
