using System;
namespace Project001_Final.Application.Wrapper
{
    public class BaseResponse
    {     
        public Guid Id { get; set; }

        public String Message { get; set; }

        public string StackTrace { get; set; }
        public string InnerMessage { get; set; }
        public string InnerStackTrace { get; set; }


        public bool IsSuccess { get; set; } = true;
        
    }
}
