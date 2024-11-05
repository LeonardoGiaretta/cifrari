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
        private char n;
        private int posix;
        private string result = "";
        private string fraseBassa = "";

        public string Cifra(string frase, int chiave)
        {
            result = "";
            fraseBassa = frase.ToLower();
            foreach(char lettera in fraseBassa)
            {
               
                if ((lettera + chiave) > 122)
                {
                    int b = chiave - (122 - lettera);
                    n = (char)(97 + b);

                }
                 
                n = (char)(lettera + (int)chiave);
                Console.WriteLine($"la lettera {lettera} viene trasformata in {n}");
                try
                {
                    result += n;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROREEEEE : " + ex);
                }
                

            }

            return result;
        }

        public string Decifra(string frase, int chiave)
        {

            result = "";

            fraseBassa = frase.ToLower(); 

            foreach (char lettera in fraseBassa)
            { 
              
                if ((lettera - chiave) < 90)
                {
                    int b = lettera  - chiave + 97;
                    n = (char)(122 - b);
                }

                n = (char)(lettera - chiave);
                Console.WriteLine($"la lettera {lettera} viene trasformata in {n}");
                try
                {
                    result += n;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROREEEEE : " + ex);
                }


            }

            return result;
        }

    }
}
