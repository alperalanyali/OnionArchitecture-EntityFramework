using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.SavedPost.CreateSavedPost
{
    public class CreateSavedPostCommandHandler:IRequestHandler<CreateSavedPostCommand,ServiceResponse<int>>
    {
        ISavedPostRepository _savedPostRepository;
        IMapper _mapper;
        
        public CreateSavedPostCommandHandler(ISavedPostRepository savedPostRepository,IMapper mapper)
        {
            _savedPostRepository = savedPostRepository;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<int>> Handle(CreateSavedPostCommand request, CancellationToken cancellationToken)
        {
            var result = new ServiceResponse<int>(0);
            try
            {
                var savedPost = _mapper.Map<Domain.Entities.SavedPost>(request);
                await _savedPostRepository.AddAsync(savedPost);
                result.Value = savedPost.Id;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.StackTrace = ex.StackTrace;
                result.InnerMessage = ex.InnerException.Message;
                result.InnerStackTrace = ex.InnerException.StackTrace;
            }

            return result;
        }
    }
}
