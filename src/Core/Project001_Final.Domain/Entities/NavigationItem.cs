using System;
using System.ComponentModel.DataAnnotations;
using Project001_Final.Domain.Common;

namespace Project001_Final.Domain.Entities
{
    public class NavigationItem:BaseEntity
    {
       [Required]
       [StringLength(100)]
        public string NavigationName { get; set; }

        [Required]
        public int FormId { get; set; }

        [Required]
        public int TopNavItemId { get; set; }

        public Form Form { get; set; }

    }
}
