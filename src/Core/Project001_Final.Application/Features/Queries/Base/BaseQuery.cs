using System;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.Base
{
    public class BaseQuery<BaseDto>: IRequest<ServiceResponse<BaseDto>>
    {
        public int Id { get; set; }
    }
}
