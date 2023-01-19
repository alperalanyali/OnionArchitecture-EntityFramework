using System;
namespace Project001_Final.Application.Dtos
{
    public class PostLikeDto:BaseDto
    {                
        //public string LikedUsername { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        //public PostDto Post { get; set; }        

    }
}
