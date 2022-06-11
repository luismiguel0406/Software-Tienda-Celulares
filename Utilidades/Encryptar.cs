using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public static  class Encryptar
    {
        public static string encrypta(string password)
        {
            string result = string.Empty;
            byte[] encryptado = Encoding.Unicode.GetBytes(password);
            result = Convert.ToBase64String(encryptado);
            return result;
        }

        public static string desencrypta(string password)
        {
            string result = string.Empty;
            byte[] desencryptado = Convert.FromBase64String(password);
            result = Encoding.Unicode.GetString(desencryptado);
            return result;


        }
    }
}
