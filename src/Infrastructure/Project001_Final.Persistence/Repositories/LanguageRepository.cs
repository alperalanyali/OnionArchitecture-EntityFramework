using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project001_Final.Application.Features.Queries.Language.GetAllLanguage;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Domain.Entities;
using Project001_Final.Persistence.Context;

namespace Project001_Final.Persistence.Repositories
{
    public class LanguageRepository : BaseRepository<Language>, ILanguageRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public LanguageRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Language>> ListAsync(GetAllLanguageQuery getAllLanguageQuery)
        {
            // İlk gali
            //return await _dbContext.Set<Language>().ToListAsync();
            return await _dbContext.Set<Language>()
                .Where(x =>
                (getAllLanguageQuery.SearchInput != null && (x.Code.ToLower().Contains(getAllLanguageQuery.SearchInput.ToLower())              
                ||  x.Name.ToLower().Contains(getAllLanguageQuery.SearchInput.ToLower()))
                ))
                .ToListAsync();

        }

      
    }
}
