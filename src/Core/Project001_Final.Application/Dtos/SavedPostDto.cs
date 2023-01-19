using System;
namespace Project001_Final.Application.Dtos
{
    public class SavedPostDto:BaseDto
    {
        public int UserId { get; set; }
        public int PostId { get; set; }

        public PostDto Post { get; set; }

    }
}
