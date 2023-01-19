using System;
using Project001_Final.Domain.Common;

namespace Project001_Final.Domain.Entities
{
    public class SavedPost:BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }

    }
}
