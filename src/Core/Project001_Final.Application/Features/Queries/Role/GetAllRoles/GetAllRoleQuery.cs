using System;
using System.Collections.Generic;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.Role.GetAllRoles
{
    public class GetAllRoleQuery:BaseListQuery<RoleDto>
    {
        //public string Code { get; set; }
        //public string Name { get; set; }
        
        //public string StatusName { get; set; }
        //Eski halid
        //public string SearchInput { get; set; }
        //public bool? IsActive { get; set; }

    }
}
