using System;
using MediatR;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.Status.CreateStatusCommand
{
    public class CreateStatusCommand:IRequest<ServiceResponse<int>>
    {
        public string Code { get; set; }
        public string Name { get; set; }

    }
}
