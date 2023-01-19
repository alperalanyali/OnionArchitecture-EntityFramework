
using System;
using System.Collections.Generic;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.GetStudentById
{
    public class GetStudentByIdQuery:IRequest<ServiceResponse<StudentDto>>
    {
        public int Id { get; set; }


    }
}
