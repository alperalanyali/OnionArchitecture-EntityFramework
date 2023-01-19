using System;
using MediatR;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.NavigationItem.UpdateNavigationItemCommand
{
    public class UpdateNavigationItemCommand:IRequest<ServiceResponse<bool>>
    {
        public int Id { get; set; }
        public string NavigationName { get; set; }
        public int FormId { get; set; }
        public int TopNavItemId { get; set; }
    }
}
