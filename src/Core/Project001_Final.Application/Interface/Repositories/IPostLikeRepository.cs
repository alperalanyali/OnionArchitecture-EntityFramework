using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Project001_Final.Application.Features.Queries.PostLike.GetLikesByPostIdQuery;
using Project001_Final.Domain.Entities;

namespace Project001_Final.Application.Interface.Repositories
{
    public interface IPostLikeRepository:IBaseRepository<PostLike>
    {
        public Task<List<PostLike>> GetLikesByPostId(GetLikesByPostIdQuery query);
        public Task<PostLike> GetByIdIncludedAsync(int id);
    }
}
