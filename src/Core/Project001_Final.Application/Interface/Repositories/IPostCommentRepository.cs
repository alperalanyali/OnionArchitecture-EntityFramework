using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Project001_Final.Application.Features.Queries.PostComment;
using Project001_Final.Domain.Entities;
using Project001_Final.Application.Features.Queries.PostComment.GetPostCommentByPostId;

namespace Project001_Final.Application.Interface.Repositories
{
    public interface IPostCommentRepository:IBaseRepository<PostComment>
    {
        public Task<List<PostComment>> ListAsyncIncluded(GetPostCommentQuery  query);
        public Task<List<PostComment>> GetPostCommentByPostId(GetPostCommentByPostIdQuery query);
    }
}
