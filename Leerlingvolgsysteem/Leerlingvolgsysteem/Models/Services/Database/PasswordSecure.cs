using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leerlingvolgsysteem.Models.Services.Database
{
    public class PasswordSecure
    {
        public string PasswordEncrypt(string ToEncrypt)
        {
            var returnencrypt = ToEncrypt;
            return returnencrypt;
        }
        public string PasswordDecrypt(string ToDecrypt)
        {
            var returndecrypt = ToDecrypt;
            return returndecrypt;
        }
    }
}