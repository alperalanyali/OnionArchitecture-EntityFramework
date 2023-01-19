using System;
using MediatR;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.Role.UpdateRoleCommand
{
    public class UpdateRoleCommand:IRequest<ServiceResponse<bool>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int? StatusId { get; set; }

    }
}
