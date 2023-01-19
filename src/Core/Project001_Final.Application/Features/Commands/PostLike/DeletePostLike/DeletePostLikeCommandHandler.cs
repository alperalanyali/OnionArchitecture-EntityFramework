using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.PostLike.DeletePostLike
{
    public class DeletePostLikeCommandHandler:IRequestHandler<DeletePostLikeCommand,ServiceResponse<bool>>
    {
        IPostLikeRepository _postLikeRepository;
        IMapper _mapper;
        public DeletePostLikeCommandHandler(IPostLikeRepository postLikeRepository,IMapper mapper)
        {
            _postLikeRepository = postLikeRepository;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<bool>> Handle(DeletePostLikeCommand request, CancellationToken cancellationToken)
        {
            var result = new ServiceResponse<bool>(false);
            try
            {
                var postLike = await _postLikeRepository.GetByIdAsync(request.Id);
                result.Value = await _postLikeRepository.RemoveAsync(postLike);

            } catch(Exception ex)
            {
                result.InnerMessage = ex.InnerException.Message;
                result.InnerStackTrace = ex.InnerException.StackTrace;
            }
            return result;
        }
    }
}
