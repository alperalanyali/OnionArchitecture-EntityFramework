using System;
namespace Project001_Final.Application.Exceptions
{
    public class ValidationException:Exception
    {
        public ValidationException():this("Validation error occured")
        {

        }
        public ValidationException(string message):base(message)
        {

        }
        public ValidationException(Exception ex):this(ex.Message)
        {

        }
    }
}
