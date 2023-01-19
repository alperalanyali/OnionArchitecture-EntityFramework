using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project001_Final.Application.Features.Queries.PostComment;
using Project001_Final.Application.Features.Queries.PostComment.GetPostCommentByPostId;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Domain.Entities;
using Project001_Final.Persistence.Context;

namespace Project001_Final.Persistence.Repositories
{
    public class PostCommentRepository : BaseRepository<PostComment>, IPostCommentRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public PostCommentRepository(ApplicationDbContext dbContext): base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<PostComment>> GetPostCommentByPostId(GetPostCommentByPostIdQuery query)
        {
            return await _dbContext.Set<PostComment>().Include("Post").Include("User").Where(x =>
                x.PostId.Equals(query.PostId)).ToListAsync();
        }

        public Task<List<PostComment>> ListAsyncIncluded(GetPostCommentQuery  query)
        {
            return _dbContext.Set<PostComment>().Include("Post").Include("User").Where(x=>
                query.SearchInput != null &&( x.Comment.ToLower().Contains(query.SearchInput.ToLower())
                    //|| x.User.LoginId.ToLower().Contains(query.SearchInput.ToLower())
                )                   
                ).ToListAsync();
        }
    }
}
