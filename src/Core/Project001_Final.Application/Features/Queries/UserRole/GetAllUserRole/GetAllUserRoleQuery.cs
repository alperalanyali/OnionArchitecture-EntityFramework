using System;
using System.Collections.Generic;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.UserRole.GetAllUserRole
{
    public class GetAllUserRoleQuery:BaseListQuery<UserRoleDto>
    {

    }
}
