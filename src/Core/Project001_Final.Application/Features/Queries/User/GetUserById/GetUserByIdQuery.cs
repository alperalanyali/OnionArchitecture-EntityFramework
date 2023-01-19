using System;
using MediatR;
using Project001_Final.Application.Dtos;
using Project001_Final.Application.Wrapper;
using Project001_Final.Application.Features.Queries.Base;
namespace Project001_Final.Application.Features.Queries.User.GetUserById
{
    public class GetUserByIdQuery:BaseQuery<UserDto>
    {
        //Eski hali
        //public int Id { get; set; }
    }
}
