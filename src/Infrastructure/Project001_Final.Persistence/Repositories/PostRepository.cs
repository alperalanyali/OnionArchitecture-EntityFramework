using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Features.Queries.Post.GetPostsQuery;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Domain.Entities;
using Project001_Final.Persistence.Context;

namespace Project001_Final.Persistence.Repositories
{
    public class PostRepository:BaseRepository<Post>,IPostRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public PostRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Post> GetByIdIncludedAsync(int id)
        {
            return await _dbContext.Set<Post>().Include("User").Include("PostLikes").Where(x => x.Id.Equals(id)).FirstOrDefaultAsync();
        }

       

        public async Task<List<Post>> ListAsync(GetPostsQuery query)
        {
            return await _dbContext.Set<Post>().Include("User").Include("PostLikes").Include("PostComments").Where(x=>
                (query.SearchInput != null &&(x.Content.ToLower().Contains(query.SearchInput.ToLower())
               || x.User.Name.ToLower().Contains(query.SearchInput.ToLower())
               || x.User.Surname.ToLower().Contains(query.SearchInput.ToLower())
                ))
            ).ToListAsync();
        }
    
    }
}
