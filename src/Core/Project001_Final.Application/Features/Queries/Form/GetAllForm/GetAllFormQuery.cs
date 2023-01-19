using System;
using System.Collections.Generic;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.Form.GetAllForm
{
    public class GetAllFormQuery : BaseListQuery<FormDto>
    {
        //public int? Id { get; set; }
        //public string FormCode { get; set; }
        //public string FormName { get; set; }
    }
}
