using System;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Features.Queries.Base;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.PostLike.GetPostLikeById
{
    public class GetPostLikeByIdQuery:BaseQuery<PostLikeDto>
    {
        public GetPostLikeByIdQuery()
        {
        }
    }
}
