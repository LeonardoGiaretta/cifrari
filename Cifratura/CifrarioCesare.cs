using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Cifratura
{
    internal class CifrarioCesare
    {
        private char[] alfabeto = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        char n;
        int posix;
        string result;

        public string Run(string frase, int chiave)
        { 
            foreach(char lettera in frase)
            {
                posix = (int)lettera;
                if ((posix + chiave) > 90)
                {
                    int b = chiave - (90 - posix);
                    n = (char)(65 + b);

                }
                 
                n = (char)(lettera + chiave);
                try
                {
                    result.Append(n);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("NOOOO");
                }
                

            }

            return result;
        }





     



        public void ToString()
        {
            Console.WriteLine(alfabeto[2]);
            return;
        }
       





    }
}
