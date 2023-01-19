using System;
using System.ComponentModel.DataAnnotations;
using Project001_Final.Domain.Common;

namespace Project001_Final.Domain.Entities
{
    public class Language:BaseEntity
    {
        [Required]
        [StringLength(10)]
        public string Code { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
