using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Project001_Final.Domain.Common;

namespace Project001_Final.Domain.Entities
{
    public class Role:BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int StatusId { get; set; }
        public Status Status { get; set; }

        public IList<UserRole> UserRoles { get; set; }
    }
}
