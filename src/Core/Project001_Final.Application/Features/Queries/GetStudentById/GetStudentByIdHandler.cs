using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.GetStudentById
{
   /* public class GetStudentByIdHandler : IRequestHandler<GetStudentByIdQuery, ServiceResponse<StudentDto>>
    {
        /*IStudentRepository _studentRepository;
        IMapper _mapper;
        public GetStudentByIdHandler(IStudentRepository studentRepository,IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<StudentDto>> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var student = await _studentRepository.GetByIdAsync(request.Id);
            var studentDto = _mapper.Map<StudentDto>(student);
            return new ServiceResponse<StudentDto>(studentDto);
        }
    }*/
}
