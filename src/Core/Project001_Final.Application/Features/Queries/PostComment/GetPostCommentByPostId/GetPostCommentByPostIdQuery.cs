using System;
using System.Collections.Generic;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.PostComment.GetPostCommentByPostId
{
    public class GetPostCommentByPostIdQuery:IRequest<ServiceResponse<List<PostCommentDto>>>
    {
        public int PostId { get; set; }
    }
}
