using System;
using MediatR;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.User.CreateUserCommand
{
    public class CreateUserCommand:IRequest<ServiceResponse<int>>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string LoginId { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int StatusId { get; set; }
    }
}
