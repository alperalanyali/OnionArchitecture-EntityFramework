using System;
using MediatR;
using Microsoft.AspNetCore.Http;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.Post.UpdatePost
{
    public class UpdatePostCommand:IRequest<ServiceResponse<bool>>
    {
        public string Content { get; set; }
        public IFormFile UploadFile { get; set; }
        public string ImageUrl { get; set; }
        public int UserId { get; set; }
    }
}
