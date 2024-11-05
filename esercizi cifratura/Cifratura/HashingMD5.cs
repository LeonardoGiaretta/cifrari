using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Cifratura
{
    internal class HashingMD5
    {
        string obbiettivo = "5d41402abc4b2a76b9719d911017c592";
        List<string> parole;
        string MD5;
        public HashingMD5() 
        {
            
            parole = new List<string>();
        }


        public bool attack()
        {
            string result = "";
            char c0 = 'a';
            char c1 = 'a';
            char c2 = 'a';
            char c3 = 'a';
            char c4 = 'a';

            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    for (int k = 0; k < 26; k++)
                    {
                        for (int o = 0; o < 26; o++)
                        {
                            for (int p = 0; p < 26; p++)
                            {
                                result = "" + c0 + c1 + c2 + c3 + c4;
                                parole.Add(result);
                                MD5 = CreateMD5(result);
                                if (MD5 == obbiettivo)
                                {
                                    Console.WriteLine($"la password è : {result}");
                                    return true;
                                }
                                c4 = (char)(c4 + 1);                          
                            }
                            c3 = (char)(c3 + 1);
                            c4 = 'a';
                        }
                        c2 = (char)(c2 + 1);
                        c3 = 'a';
                    }
                    c1 = (char)(c1 + 1);
                    c2 = 'a';
                }
                c0 = (char)(c0 + 1);
                c1 = 'a';
            }



        }

        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                return Convert.ToHexString(hashBytes);
            }
        }
    }
}
