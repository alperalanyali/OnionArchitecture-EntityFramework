using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Project001_Final.Application.Features.Commands.Language.UpdateLanguage;
using Project001_Final.Application.Features.Queries.Language.GetAllLanguage;
using Project001_Final.Domain.Entities;

namespace Project001_Final.Application.Interface.Repositories
{
    public interface ILanguageRepository:IBaseRepository<Language>
    {
        public Task<List<Language>> ListAsync(GetAllLanguageQuery getAllLanguageQuery);

        
    }
}
