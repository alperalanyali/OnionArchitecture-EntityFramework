using System;
using System.Collections.Generic;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.NavigationItemRole.GetAllUserNavigationItemRole
{
    public class GetAllUserNavigationItemRoleQuery : BaseListQuery<NavigationItemRoleDto>
    {
        //public string NavigationName { get; set; }
        //public string RoleName { get; set; }
        //Eski hali
        //public string SearchInput { get; set; }

    }
}
