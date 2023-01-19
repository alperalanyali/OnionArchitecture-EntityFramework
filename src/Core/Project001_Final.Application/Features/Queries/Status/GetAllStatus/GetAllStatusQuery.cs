using System;
using System.Collections.Generic;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.Status.GetAllStatus
{
    public class GetAllStatusQuery:BaseListQuery<StatusDto>
    {
        //public int? Id { get; set; }
        //public string Name { get; set; }
        //public string Code { get; set; }
        public string SearchInput { get; set; }        
    }
}
