using System;
using System.ComponentModel.DataAnnotations;

namespace Project001_Final.Domain.Common
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
