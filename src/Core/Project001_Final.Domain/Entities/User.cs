using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Project001_Final.Domain.Common;

namespace Project001_Final.Domain.Entities
{
    public class User:BaseEntity
    {
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Surname { get; set; }

        [Required]
        [StringLength(64)]
        public string LoginId { get; set; }

        [StringLength(64)]
        [Required]
        public string Email { get; set; }
         
        [Required]
        [StringLength(64)]

        public string Password { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }


        public virtual ICollection<UserRole> UserRoles { get; set; }
        public ICollection<PostLike> PostLikes { get; set; }
        public ICollection<PostComment> PostComments { get; set; }
        public ICollection<SavedPost> SavedPosts { get; set; }
    }
}
