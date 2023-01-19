using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.Post.GetPostsQuery
{
    public class GetPostsQueryHandle : IRequestHandler<GetPostsQuery, ServiceResponse<List<PostDto>>>
    {
        IMapper _mapper;
        IPostRepository _postRepo;

        public GetPostsQueryHandle(IPostRepository postRepo,IMapper mapper)
        {
            _postRepo = postRepo;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<PostDto>>> Handle(GetPostsQuery request, CancellationToken cancellationToken)
        {
                var result = new ServiceResponse<List<PostDto>>(null);
            try
            {
                var posts = await _postRepo.ListAsync(request);
                var dtos = _mapper.Map<List<PostDto>>(posts);
                result.Value = dtos;
            }
            catch(Exception ex)
            {
                result.Message = ex.Message;
                result.StackTrace = ex.StackTrace;
                result.InnerMessage = ex.InnerException.Message;
                result.InnerStackTrace = ex.InnerException.StackTrace;
            }
          

            
            return  result;
        }
    }
}
