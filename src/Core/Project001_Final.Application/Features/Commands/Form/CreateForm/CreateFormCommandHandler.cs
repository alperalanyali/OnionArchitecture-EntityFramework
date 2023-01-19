using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.Form.CreateForm
{
    public class CreateFormCommandHandler : IRequestHandler<CreateFormCommand, ServiceResponse<int>>
    {
        IFormRepository _formRepository;
        IMapper _mapper;

        public CreateFormCommandHandler(IFormRepository formRepository,IMapper mapper)
        {
            _mapper = mapper;
            _formRepository = formRepository;
        }

        public async Task<ServiceResponse<int>> Handle(CreateFormCommand request, CancellationToken cancellationToken)
        {
            var form = _mapper.Map<Domain.Entities.Form>(request);
            await _formRepository.AddAsync(form);
            return new ServiceResponse<int>(form.Id);
        }
    }
}
