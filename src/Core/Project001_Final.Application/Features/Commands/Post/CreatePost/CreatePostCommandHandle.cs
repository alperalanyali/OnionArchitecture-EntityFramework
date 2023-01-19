using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;
using Project001_Final.Application.Helpers;

namespace Project001_Final.Application.Features.Commands.Post
{
    public class CreatePostCommandHandle:IRequestHandler<CreatePostCommand,ServiceResponse<int>>
    {

        IPostRepository _postRepo;
        IMapper _mapper;
        public CreatePostCommandHandle(IPostRepository postRepo,IMapper mapper)
        {
            _postRepo = postRepo;
            _mapper = mapper;
        }

    

        public async Task<ServiceResponse<int>> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            request.ImageUrl = ConvertFileToBas64.ConvertToBase64("image", request.UploadFile);

            var post = _mapper.Map<Domain.Entities.Post>(request);
            await _postRepo.AddAsync(post);

            return new ServiceResponse<int>(post.Id);
        }
    }
}
