using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.PostLike.GetLikesByPostIdQuery
{
    public class GetLikesByPostIdQueryHandle:IRequestHandler<GetLikesByPostIdQuery,ServiceResponse<List<PostLikeDto>>>
    {
        IPostLikeRepository _postLikeRepo;
        IMapper _mapper;
        public GetLikesByPostIdQueryHandle(IPostLikeRepository postLikeRepo,IMapper mapper)
        {
            _postLikeRepo = postLikeRepo;
            _mapper = mapper;
        }

     

        public async Task<ServiceResponse<List<PostLikeDto>>> Handle(GetLikesByPostIdQuery request, CancellationToken cancellationToken)
        {
            var postLikes = await _postLikeRepo.GetLikesByPostId(request);
            var dtos = _mapper.Map<List<PostLikeDto>>(postLikes);

            return new ServiceResponse<List<PostLikeDto>>(dtos);
        }
    }
}
