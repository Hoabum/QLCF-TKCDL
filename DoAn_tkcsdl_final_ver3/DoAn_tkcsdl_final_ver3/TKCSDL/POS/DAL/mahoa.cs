using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace POS.DAL
{
    internal class mahoa
    {
       /* public static string mahoaMK(string input)
        {
            string result = string.Empty;
            using (MD5 md5Hash = MD5.Create())
            {
                result = getMD5Hash(md5Hash, input);
            }
            return result;
        }
        static string getMD5Hash(MD5 md5hash, string input)
        {
            byte[] data = md5hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("x2"));
            }
            return stringBuilder.ToString();
        }*/


        public static string mahoaMK(string input)
        {
            // a b c -> 48 49 50 : 48+ind là 0+(49%2) ; 49+1+(50%2)
            
            char[] char_string = input.ToCharArray(); // CHUYỂN THÀNH MẢNG

            //select val +ind -> ano. type
            var input_index = char_string.Select((value, ind) => new { value, ind }).ToArray();
            // ap dụng ct
           var char_input = input_index.Select(c => c.value + c.ind + (input_index.Length > c.ind + 1 ? input_index[c.ind + 1].value % 2 : 0)).Select(c=>(char)c).ToArray();
            //chuyen về string
            string result = new string(char_input);
            return result;
        }
    }
}
