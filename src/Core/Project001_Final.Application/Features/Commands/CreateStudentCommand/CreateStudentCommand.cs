using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands
{
   /* public class CreateStudentCommand:IRequest<ServiceResponse<int>>
    {
      
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }




        public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, ServiceResponse<int>>
        {
            IStudentRepository _studentRepository;
            IMapper _mapper;
            public CreateStudentCommandHandler(IStudentRepository studentRepository,IMapper mapper)
            {
                _studentRepository = studentRepository;
                _mapper = mapper;
            }
            public async Task<ServiceResponse<int>> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
            {
                var student = _mapper.Map<Domain.Entities.Student>(request);
                await _studentRepository.AddAsync(student);
                return new ServiceResponse<int>(student.Id);
            } 
        }
    }*/
}
