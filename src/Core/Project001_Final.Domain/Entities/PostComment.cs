using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Project001_Final.Domain.Common;

namespace Project001_Final.Domain.Entities
{
    public class PostComment:BaseEntity
    {
        public int PostId { get; set; }
        public Post Post { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }


        [Required]
        [StringLength(150)]
        public string Comment { get; set; }
        
      
    }
}
