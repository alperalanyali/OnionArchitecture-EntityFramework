using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.PostComment.UpdatePostCommentCommand
{
    public class UpdatePostCommentCommandHandler:IRequestHandler<UpdatePostCommentCommand,ServiceResponse<bool>>
    {
        IPostCommentRepository _postCommentRepo;
        IMapper _mapper;
        public UpdatePostCommentCommandHandler(IPostCommentRepository postCommentRepository,IMapper mapper)
        {
            _postCommentRepo = postCommentRepository;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<bool>> Handle(UpdatePostCommentCommand request, CancellationToken cancellationToken)
        {
            var result = new ServiceResponse<bool>(false);
            try
            {
                var postComment = _mapper.Map<Domain.Entities.PostComment>(request);
                var result2 = await _postCommentRepo.UpdateAsync(postComment);
                result.Value = result2;
            }catch(Exception ex)
            {
                result.InnerMessage = ex.InnerException.Message;
                result.InnerStackTrace = ex.InnerException.StackTrace;
            }


            return result;
        }
    }
}
