using System;
using System.Collections.Generic;

namespace Project001_Final.Application.Dtos
{
    public class PostDto:BaseDto
    {
        public int UserId { get; set; }
        public string Content { get; set; }
        public string FullName { get; set; }
        public int Likes { get; set; }
        public List<PostLikeDto> PostLikes { get; set; }
        public List<PostCommentDto> PostComments { get; set; }
        public int PostCommentCount { get; set; }
        public string ImageUrl { get; set; }
        


    }
}
