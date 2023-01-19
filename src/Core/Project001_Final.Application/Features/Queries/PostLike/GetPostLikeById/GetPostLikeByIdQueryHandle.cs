using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.PostLike.GetPostLikeById
{
    public class GetPostLikeByIdQueryHandle:IRequestHandler<GetPostLikeByIdQuery,ServiceResponse<PostLikeDto>>
    {
        IPostLikeRepository _postLikeRepo;
        IMapper _mapper;
        public GetPostLikeByIdQueryHandle(IPostLikeRepository postLikeRepo,IMapper mapper)
        {
            _postLikeRepo = postLikeRepo;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<PostLikeDto>> Handle(GetPostLikeByIdQuery request, CancellationToken cancellationToken)
        {
            var postLike = await _postLikeRepo.GetByIdIncludedAsync(request.Id);
            var dto = _mapper.Map<PostLikeDto>(postLike);

            return new ServiceResponse<PostLikeDto>(dto);
        }
    }
}
