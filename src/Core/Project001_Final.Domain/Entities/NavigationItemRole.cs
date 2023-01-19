using System;
using Project001_Final.Domain.Common;

namespace Project001_Final.Domain.Entities
{
    public class NavigationItemRole: BaseEntity
    {
        public int NavigationItemId { get; set; }

        public int RoleId { get; set; }

        public NavigationItem NavigationItem { get; set; }
        public Role Role { get; set; }
    }
}
