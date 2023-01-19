using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.PostComment
{
    public class PostCommentQueryHandler : IRequestHandler<GetPostCommentQuery,ServiceResponse<List<PostCommentDto>>>
    {
        IPostCommentRepository _postCommentRepo;
        IMapper _mapper;
        public PostCommentQueryHandler(IPostCommentRepository postCommentRepository,IMapper mapper)
        {
            _postCommentRepo = postCommentRepository;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<PostCommentDto>>> Handle(GetPostCommentQuery request, CancellationToken cancellationToken)
        {
            var postComments = await _postCommentRepo.ListAsyncIncluded(request);
            var dtos = _mapper.Map<List<PostCommentDto>>(postComments);

            return new ServiceResponse<List<PostCommentDto>>(dtos);
        }
    }
}
