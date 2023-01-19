using System;
using System.ComponentModel.DataAnnotations;
using Project001_Final.Domain.Common;

namespace Project001_Final.Domain.Entities
{
    public class Form:BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string FormCode { get; set; }

        [Required]
        [StringLength(100)]
        public string FormName { get; set; }
    }
}
