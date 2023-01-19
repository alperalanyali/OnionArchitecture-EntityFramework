using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.PostComment.GetPostCommentByPostId
{
    public class GetPostCommentByPostIdQueryHandler:IRequestHandler<GetPostCommentByPostIdQuery, ServiceResponse<List<PostCommentDto>>>
    {
        IPostCommentRepository _postCommentRepo;
        IMapper _mapper;
        public GetPostCommentByPostIdQueryHandler(IPostCommentRepository postCommentRepo,IMapper mapper)
        {
            _postCommentRepo = postCommentRepo;
            _mapper = mapper;
        }



        public async Task<ServiceResponse<List<PostCommentDto>>> Handle(GetPostCommentByPostIdQuery request, CancellationToken cancellationToken)
        {
            var postComments = await _postCommentRepo.GetPostCommentByPostId(request);
            var dtos = _mapper.Map<List<PostCommentDto>>(postComments);

            return new ServiceResponse<List<PostCommentDto>>(dtos);
        }
    }
}
