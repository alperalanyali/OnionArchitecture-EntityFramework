using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.Language.UpdateLanguage
{
    public class UpdateLanguageCommandHandle:IRequestHandler<UpdateLanguageCommand, ServiceResponse<bool>>
    {
        ILanguageRepository _languageRepo;
        IMapper _mapper;

        public UpdateLanguageCommandHandle(ILanguageRepository languageRepo,IMapper mapper)
        {
            _languageRepo = languageRepo;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<bool>> Handle(UpdateLanguageCommand request, CancellationToken cancellationToken)
        {
            var language= _mapper.Map<Domain.Entities.Language>(request);
            var result = await _languageRepo.UpdateAsync(language);
            return new ServiceResponse<bool>(result);
        }
    }
}
