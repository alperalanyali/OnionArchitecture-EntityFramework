using System;
namespace Project001_Final.Application.Wrapper
{
    public class ServiceResponse<T>:BaseResponse
    {
        public T Value{ get; set; }        
        public ServiceResponse(T value)
        {
            Value = value;
            
        }
    }
}
