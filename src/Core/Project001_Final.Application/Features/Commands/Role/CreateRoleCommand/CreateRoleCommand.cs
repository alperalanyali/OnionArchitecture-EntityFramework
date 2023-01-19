using System;
using MediatR;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.Role.CreateRoleCommand
{
    public class CreateRoleCommand:IRequest<ServiceResponse<int>>
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int StatusId { get; set; }
    }
}
