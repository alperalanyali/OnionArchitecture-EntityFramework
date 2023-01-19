using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.Post.GetPostById
{
    public class GetPostByIdQueryHandle:IRequestHandler<GetPostByIdQuery,ServiceResponse<PostDto>>
    {
        IPostRepository _postRepo;
        IMapper _mapper;
        public GetPostByIdQueryHandle(IPostRepository repository,IMapper mapper)
        {
            _mapper = mapper;
            _postRepo = repository;
        }

        public async Task<ServiceResponse<PostDto>> Handle(GetPostByIdQuery request, CancellationToken cancellationToken)
        {
            var post = await _postRepo.GetByIdIncludedAsync(request.Id);
            var dto = _mapper.Map<PostDto>(post);
            return new ServiceResponse<PostDto>(dto);
        }
    }
}
