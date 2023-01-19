using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.PostComment.CreatePostCommentCommand
{
    public class CreatePostCommentCommandHandler:IRequestHandler<CreatePostCommentCommand,ServiceResponse<int>>
    {
        IPostCommentRepository _postCommentRepo;
        IMapper _mapper;
        public CreatePostCommentCommandHandler(IPostCommentRepository postCommentRepo,IMapper mapper)
        {
            _postCommentRepo = postCommentRepo;
            _mapper = mapper;
        }

     

        public async Task<ServiceResponse<int>> Handle(CreatePostCommentCommand request, CancellationToken cancellationToken)
        {
            var result = new ServiceResponse<int>(0);
            try
            {
                var postComment = _mapper.Map<Domain.Entities.PostComment>(request);
                await _postCommentRepo.AddAsync(postComment);
                result.Value = postComment.Id;
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
