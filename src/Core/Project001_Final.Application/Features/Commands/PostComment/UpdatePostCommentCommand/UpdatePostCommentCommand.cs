using System;
using MediatR;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.PostComment.UpdatePostCommentCommand
{
    public class UpdatePostCommentCommand:IRequest<ServiceResponse<bool>>
    {
        public int UserId { get; set; }
        public int PostId { get; set; }
        public string Comment { get; set; }
    }
}
