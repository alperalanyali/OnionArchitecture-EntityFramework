using System;
using MediatR;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.NavigationItem.CreateNavigationItem
{
    public class CreateNavigationItemCommand:IRequest<ServiceResponse<int>>
    {
        public string NavigationName { get; set; }
        public int FormId { get; set; }
        public int TopNavItemId { get; set; }
    }
}
