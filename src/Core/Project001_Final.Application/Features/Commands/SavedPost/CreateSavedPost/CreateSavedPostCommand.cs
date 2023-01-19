using System;
using MediatR;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.SavedPost.CreateSavedPost
{
    public class CreateSavedPostCommand:IRequest<ServiceResponse<int>>
    {
        public int UserId { get; set; }
        public int PostId { get; set; }
    }
}
