using System;
using System.Collections.Generic;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.PostLike.GetLikesByPostIdQuery
{
    public class GetLikesByPostIdQuery:IRequest<ServiceResponse<List<PostLikeDto>>>
    {
        public int PostId { get; set; }
    }
}
