using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Project001_Final.Application.Features.Queries.Form.GetAllForm;
using Project001_Final.Domain.Entities;

namespace Project001_Final.Application.Interface.Repositories
{
    public interface IFormRepository:IBaseRepository<Form>
    {
        public Task<List<Form>> ListAsync(GetAllFormQuery getAllFormQuery);
    }
}
