using System;
using System.Collections.Generic;
using Project001_Final.Domain.Common;

namespace Project001_Final.Domain.Entities
{
    public class Post:BaseEntity
    {

        public string ImageUrl { get; set; }
        public string Content { get; set; }       
        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<PostLike> PostLikes { get; set; }
        public ICollection<PostComment> PostComments { get; set; }
        public ICollection<SavedPost> SavedPosts { get; set; }
    }
}
