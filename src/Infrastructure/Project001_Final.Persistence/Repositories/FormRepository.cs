using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project001_Final.Application.Features.Queries.Form.GetAllForm;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Domain.Entities;
using Project001_Final.Persistence.Context;

namespace Project001_Final.Persistence.Repositories
{
    public class FormRepository : BaseRepository<Form>, IFormRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public FormRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Form>> ListAsync(GetAllFormQuery getAllFormQuery)
        {
            return await _dbContext.Set<Form>().Where(x =>
                  (getAllFormQuery.SearchInput != null && (x.FormCode.ToLower().Contains(getAllFormQuery.SearchInput.ToLower()))
                 
                  || (getAllFormQuery.SearchInput != null && x.FormName.ToLower().Contains(getAllFormQuery.SearchInput.ToLower())))
                  && (getAllFormQuery.IsActive != null && x.IsActive.Equals(getAllFormQuery.IsActive))
          )
          .ToListAsync();
        }
    }
}
