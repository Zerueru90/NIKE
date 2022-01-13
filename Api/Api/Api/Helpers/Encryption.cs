using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Api.Helpers
{
    public static class Encryption
    {

        public static byte[] GenerateEncryption(this string encrypt)
        {
            using (var md5 = MD5.Create() ) 
            { 
                var source = Encoding.UTF8.GetBytes(encrypt);
                return md5.ComputeHash(source);
            }
        }






    }
}
