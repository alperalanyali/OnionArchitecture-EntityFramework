using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Project001_Final.Application.Features.Queries.Status.GetAllStatus;
using Project001_Final.Domain.Entities;

namespace Project001_Final.Application.Interface.Repositories
{
    public interface IStatusRepository : IBaseRepository<Status>
    {
        public Task<List<Status>> ListAsync(GetAllStatusQuery query);
    }
}
