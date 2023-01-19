using System;
using System.IO;
using MediatR;
using Microsoft.AspNetCore.Http;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.Post
{
    public class CreatePostCommand:IRequest<ServiceResponse<int>>
    {
        public string Content { get; set; }
        public IFormFile UploadFile { get; set; }
        public string ImageUrl { get; set; }
        public int UserId { get; set; }
    }
}
