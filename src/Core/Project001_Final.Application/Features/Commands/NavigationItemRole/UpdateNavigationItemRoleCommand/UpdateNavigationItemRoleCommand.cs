using System;
using MediatR;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.NavigationItemRole.UpdateNavigationItemRoleCommand
{
    public class UpdateNavigationItemRoleCommand:IRequest<ServiceResponse<bool>>
    {
        public int Id { get; set; }
        public int NavigationItemId { get; set; }
        public int RoleId { get; set; }

    }
}
