using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace ders_16032022
{
    public class Sifrele
    {
        public static string HashMD5(string plaintext)
        {
            using (var mdp5provider = new MD5CryptoServiceProvider())
            {
                var hash = mdp5provider.ComputeHash(Encoding.UTF8.GetBytes(plaintext));
                return BitConverter.ToString(hash).Replace("-", "");
            }
        }
    }
}