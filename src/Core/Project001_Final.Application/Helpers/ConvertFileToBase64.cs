using System;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace Project001_Final.Application.Helpers
{
    public class ConvertFileToBas64
    {
        public static string ConvertToBase64(string type,IFormFile form)
        {
            string result = "";
            string base64 = "";
            if(type == "image")
            {
                base64 = "data:image/jpeg;base64,";
            } else if(type == "pdf")
            {
                base64 = "data:application/pdf;base64,";
            }else if(type == "word")
            {
                base64 = "data:application/vnd.openxmlformats-officedocument.wordprocessingml.document;base64,";
            }
    
            if (form.Length > 0)
            {
                using(var ms = new MemoryStream())
                {
                    form.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    result = base64+ Convert.ToBase64String(fileBytes);
                }
            }

            return result;
        }
    }
}
