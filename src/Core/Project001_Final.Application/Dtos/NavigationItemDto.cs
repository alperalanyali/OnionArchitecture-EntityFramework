using System;
namespace Project001_Final.Application.Dtos
{
    public class NavigationItemDto
    {
        public int Id { get; set; }
        public int FormId { get; set; }
        public string FormName { get; set; }
        public string NavigationName { get; set; }
        public  int TopNavItemId { get; set; }
        public bool IsActive { get; set; }

    }
}
