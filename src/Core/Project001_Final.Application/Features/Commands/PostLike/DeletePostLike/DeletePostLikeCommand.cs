using System;
using MediatR;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.PostLike.DeletePostLike
{
    public class DeletePostLikeCommand:IRequest<ServiceResponse<bool>>
    {
        public int Id { get; set; }
    }
}
