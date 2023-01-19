using System;
using System.ComponentModel.DataAnnotations;
using Project001_Final.Domain.Common;

namespace Project001_Final.Domain.Entities
{
    public class UserRole:BaseEntity
    {
        [Required]
        public int UserId { get; set; }

        public User User { get; set; }

        [Required]
        public int RoleId { get; set; }

        public Role Role { get; set; }


    }
}
