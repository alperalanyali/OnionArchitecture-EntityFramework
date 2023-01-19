using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.Language.CreateLanguage
{
    public class CretaLanguageCommandHandle:IRequestHandler<CretaLanguageCommand,ServiceResponse<int>>
    {
        ILanguageRepository _languageRepo;
        IMapper _mapper;
        public CretaLanguageCommandHandle(ILanguageRepository languageRepo, IMapper mapper)
        {
            _languageRepo = languageRepo;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<int>> Handle(CretaLanguageCommand request, CancellationToken cancellationToken)
        {
            var language = _mapper.Map<Domain.Entities.Language>(request);
            await _languageRepo.AddAsync(language);
            return new ServiceResponse<int>(language.Id);

        }
    }
}
