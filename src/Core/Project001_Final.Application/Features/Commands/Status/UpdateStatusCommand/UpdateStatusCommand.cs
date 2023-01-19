using System;
using MediatR;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.Status.UpdateStatusCommand
{
    public class UpdateStatusCommand:IRequest<ServiceResponse<bool>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Code { get; set; }
        public bool IsActive { get; set; }

    }
}
