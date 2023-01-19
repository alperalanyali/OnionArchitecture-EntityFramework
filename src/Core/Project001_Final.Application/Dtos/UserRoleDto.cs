using System;
namespace Project001_Final.Application.Dtos
{
    public class UserRoleDto
    {
        public int  Id { get; set; }
        public UserDto User { get; set; }
        public RoleDto Role { get; set; }
        public string UserName { get; set; }
        public string RoleName { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }

    }
}
