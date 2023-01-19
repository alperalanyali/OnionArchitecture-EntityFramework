using System;
using MediatR;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.PostComment.CreatePostCommentCommand
{
    public class CreatePostCommentCommand:IRequest<ServiceResponse<int>>
    {
        public int UserId { get; set; }
        public int PostId { get; set; }
        public string Comment { get; set; }
    }
}
