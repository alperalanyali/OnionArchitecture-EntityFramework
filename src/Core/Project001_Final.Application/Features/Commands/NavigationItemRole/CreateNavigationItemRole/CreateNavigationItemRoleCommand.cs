using System;
using MediatR;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.NavigationItemRole.CreateNavigationItemRole
{
    public class CreateNavigationItemRoleCommand:IRequest<ServiceResponse<int>>
    {
        public int NavigationItemId { get; set; }
        public int RoleId { get; set; }
    }
}
