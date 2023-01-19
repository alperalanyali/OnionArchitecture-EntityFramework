using System;
namespace Project001_Final.Application.Dtos
{
    public class RoleDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public StatusDto Status { get; set; }
        public string StatusName { get; set; } 
        public bool IsActive { get; set; }

    }
}
