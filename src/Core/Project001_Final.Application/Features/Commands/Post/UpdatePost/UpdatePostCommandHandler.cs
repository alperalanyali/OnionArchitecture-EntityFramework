using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.Post.UpdatePost
{
    public class UpdatePostCommandHandler:IRequestHandler<UpdatePostCommand,ServiceResponse<bool>>
    {
        IPostRepository _postRepo;
        IMapper _mapper;
        public UpdatePostCommandHandler(IPostRepository postRepo, IMapper mapper)
        {
            _postRepo = postRepo;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<bool>> Handle(UpdatePostCommand request, CancellationToken cancellationToken)
        {
            var result = new ServiceResponse<bool>(false);
            try
            {
                var post = _mapper.Map<Domain.Entities.Post>(request);
                result.Value = await _postRepo.UpdateAsync(post);
                
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
