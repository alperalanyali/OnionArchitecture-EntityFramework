using System;
using System.Collections.Generic;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.User.GetUsers
{
    public class GetAllUsersQuery:IRequest<ServiceResponse<List<UserDto>>>
    {
        public string SearchInput { get; set; }


    }
}
