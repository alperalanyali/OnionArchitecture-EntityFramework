using System;
namespace Project001_Final.Application.Dtos
{
    public class NavigationItemRoleDto
    {
        public int Id { get; set; }
        public int NavigationItemId  { get; set; }
        public int RoleId { get; set; }
        public string NavigationName { get; set; }
        public string RoleName { get; set; }
    }
}
