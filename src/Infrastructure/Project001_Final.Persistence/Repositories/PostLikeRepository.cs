using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project001_Final.Application.Features.Queries.PostLike.GetLikesByPostIdQuery;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Domain.Entities;
using Project001_Final.Persistence.Context;

namespace Project001_Final.Persistence.Repositories
{
    public class PostLikeRepository:BaseRepository<PostLike>, IPostLikeRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public PostLikeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<PostLike> GetByIdIncludedAsync(int id)
        {
            return await _dbContext.Set<PostLike>().Include("User").Where(x => x.Id.Equals(id)).FirstOrDefaultAsync();
        }
        public async Task<PostLike> GetByIdAsync(int id)
        {
        
            try
            {
                return await _dbContext.Set<PostLike>().Where(x => x.Id.Equals(id)).FirstOrDefaultAsync();
            }catch(Exception ex)
            {

            }
            return null;
          //  var  posts = await _dbContext
          
        }

      

        public async Task<List<PostLike>> GetLikesByPostId(GetLikesByPostIdQuery query)
        {
            return await _dbContext.Set<PostLike>().Include("User").Include("Post").Where(x => x.Post.Id == query.PostId).ToListAsync();
        }
    }
}
