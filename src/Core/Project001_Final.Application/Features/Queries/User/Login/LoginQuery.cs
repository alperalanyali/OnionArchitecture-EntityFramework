using System;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Features.Queries.Base;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Queries.User.Login
{
    public class LoginQuery:IRequest<ServiceResponse<bool>>
    {
        public string LoginId { get; set; }
        public string Password { get; set; }

    }
}
