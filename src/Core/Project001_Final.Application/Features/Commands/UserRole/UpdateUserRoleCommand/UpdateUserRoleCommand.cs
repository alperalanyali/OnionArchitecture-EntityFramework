using System;
using MediatR;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.UserRole.UpdateUserRoleCommand
{
    public class UpdateUserRoleCommand:IRequest<ServiceResponse<bool>>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public bool IsActive { get; set; }
    }
}
