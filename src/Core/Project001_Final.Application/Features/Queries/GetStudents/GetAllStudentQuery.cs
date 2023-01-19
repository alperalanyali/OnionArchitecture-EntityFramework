using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Interface.Repositories;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.GetStudents
{
    public class GetAllStudentQuery:IRequest<ServiceResponse<List<StudentDto>>>
    {
        //public class GetAllStudentsQueryHandler : IRequestHandler<GetAllStudentQuery, ServiceResponse<List<StudentDto>>>
        //{
        //    //private readonly IStudentRepository _studentRepository;
        //    //private readonly IMapper _mapper;
        //    //public GetAllStudentsQueryHandler(IStudentRepository studentRepository,IMapper mapper)
        //    //{
        //    //    _studentRepository = studentRepository;
        //    //    _mapper = mapper;
        //    //}
        //    //public async Task<ServiceResponse<List<StudentDto>>> Handle(GetAllStudentQuery request, CancellationToken cancellationToken)
        //    //{
        //    //    var students = await _studentRepository.GetAllAsync();
        //    //    /*return students.Select(i => new StudentDto()
        //    //    {
        //    //        Id = i.Id,
        //    //        Name=i.Name,
        //    //        FullName = i.Name + " " + i.Surname,
        //    //    }).ToList();*/
        //    //    var viewModel = _mapper.Map<List<StudentDto>>(students);
        //    //    //var dto = students.Select(i => new StudentDto()
        //    //    //{
        //    //    //    Id = i.Id,
        //    //    //    Name = i.Name,
        //    //    //    FullName = i.Name + " " + i.Surname,
        //    //    //}).ToList();
        //    //    return new ServiceResponse<List<StudentDto>>(viewModel); //new ServiceResponse<List<StudentDto>>(dto);
        //    //}

           
        //}
    }
}
