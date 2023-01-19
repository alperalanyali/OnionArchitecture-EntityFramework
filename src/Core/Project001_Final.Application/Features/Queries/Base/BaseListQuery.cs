using System;
using MediatR;
using Project001_Final.Application.Wrapper;
using Project001_Final.Application.Dtos;
using System.Collections.Generic;

namespace Project001_Final.Application.Features.Queries
{
    public class BaseListQuery<BaseDto>: IRequest<ServiceResponse<List<BaseDto>>>
    {
        public string SearchInput { get; set; }
        public bool? IsActive { get; set; }

    }
}
