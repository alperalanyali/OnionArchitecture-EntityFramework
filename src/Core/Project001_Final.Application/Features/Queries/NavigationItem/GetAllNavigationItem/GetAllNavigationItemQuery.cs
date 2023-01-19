using System;
using System.Collections.Generic;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.NavigationItem.GetAllNavigationItem
{
    public class GetAllNavigationItemQuery:BaseListQuery<NavigationItemDto>
    {
        //public int? Id { get; set; }
        //public string NavigationName { get; set; }
        //public string FormName { get; set; }
        //public int? TopNavItemId { get; set; }
        //Eski Hali class a bağlanmadan önceki halidir
        //public string SearchInput { get; set; }
        //public bool? IsActive { get; set; }

    }
}
