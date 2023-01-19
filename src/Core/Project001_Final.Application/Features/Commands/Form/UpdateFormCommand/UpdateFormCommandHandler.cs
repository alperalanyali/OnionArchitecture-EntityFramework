using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.Form.UpdateFormCommand
{
    public class UpdateFormCommandHandler : IRequestHandler<UpdateFormCommand, ServiceResponse<bool>>
    {
        IFormRepository _formRepo;
        IMapper _mapper;

        public UpdateFormCommandHandler(IFormRepository formRepo, IMapper mapper)
        {
            _formRepo = formRepo;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<bool>> Handle(UpdateFormCommand request, CancellationToken cancellationToken)
        {
            var form = _mapper.Map<Domain.Entities.Form>(request);
            var result = await _formRepo.UpdateAsync(form);
            return new ServiceResponse<bool>(result);
        }
    }
}
