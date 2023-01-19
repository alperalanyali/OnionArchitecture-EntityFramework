using System;
using MediatR;
using Project001_Final.Application.Wrapper;

namespace Project001_Final.Application.Features.Commands.User.UpdateUserCommand
{
    public class UpdateUserCommand:IRequest<ServiceResponse<bool>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string LoginId { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }

    }
}
