using System;
using System.Security.Cryptography;
using System.Text;

namespace Project001_Final.Application.Helpers
{
    public class PasswordEncryptDecrypt
    {
        public static string EncryptPassword(string password)
        {
            string result = "";
            byte[] data = UTF8Encoding.UTF8.GetBytes(password);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripleDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripleDes.CreateEncryptor();
                    byte[] resultbyte = transform.TransformFinalBlock(data, 0, data.Length);
                    result = Convert.ToBase64String(resultbyte);
                }
            }
            return result;
        }
        public static string hash = "alper342";
        
        public static string DecryptPassword(string password)
        {
            string result = "";
            byte[] data = Convert.FromBase64String(password);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripleDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripleDes.CreateDecryptor();
                    byte[] resultbyte = transform.TransformFinalBlock(data, 0, data.Length);
                    result = UTF8Encoding.UTF8.GetString(resultbyte);
                }
            }
            return result;
        }
    }
}
