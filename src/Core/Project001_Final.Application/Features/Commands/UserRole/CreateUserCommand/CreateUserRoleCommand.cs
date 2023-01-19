using System;
using MediatR;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.UserRole
{
    public class CreateUserRoleCommand:IRequest<ServiceResponse<int>>
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }

    }
}
