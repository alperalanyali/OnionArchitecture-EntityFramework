using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.PostLike.CreatePostLike
{
    public class CreatePostLikeCommandHandle : IRequestHandler<CreatePostLikeCommand, ServiceResponse<int>>
    {
        IPostLikeRepository _postLikeRepo;
        IMapper _mapper;
        public CreatePostLikeCommandHandle(IPostLikeRepository postLikeRepo,IMapper mapper)
        {
            _postLikeRepo = postLikeRepo;
            _mapper = mapper;
        }

        public  async Task<ServiceResponse<int>> Handle(CreatePostLikeCommand request, CancellationToken cancellationToken)
        {
            var result = new ServiceResponse<int>(0);
            try
            {
                var postLike = _mapper.Map<Domain.Entities.PostLike>(request);
                await _postLikeRepo.AddAsync(postLike);
                result.Value = postLike.Id;
            }
            catch(Exception ex)
            {
                result.InnerMessage = ex.InnerException.Message;
                result.InnerStackTrace = ex.InnerException.StackTrace;
            }
           
           
            return result;
        }
    }
}
