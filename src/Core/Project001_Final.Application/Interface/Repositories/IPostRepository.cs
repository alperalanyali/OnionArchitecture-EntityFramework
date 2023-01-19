using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Features.Queries.Post.GetPostsQuery;
using Project001_Final.Application.Wrapper;
using Project001_Final.Domain.Entities;

namespace Project001_Final.Application.Interface.Repositories
{
    public interface IPostRepository:IBaseRepository<Post>
    {
        public Task<List<Post>> ListAsync(GetPostsQuery query);
        public Task<Post> GetByIdIncludedAsync (int id);
      
    }
}
