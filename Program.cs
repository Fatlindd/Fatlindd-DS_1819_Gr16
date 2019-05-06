using System;

namespace Beaufort
{
    class Program
    {
        static void Main(string[] args)
        {
            string plaintext = "fakultetiteknik";
            string key = "siguria";

            Console.WriteLine("Projekti Pare ne Siguri!\n");


            string ciphertext = Encrypt(plaintext.ToUpper(), key.ToUpper());
            Console.WriteLine("1. Plaintext :" + plaintext);
            Console.WriteLine("2.Ciphertext :"+ciphertext);

            Console.WriteLine("\n\n");

            string decryptedPlaintext = Decrypt(ciphertext.ToUpper(), key.ToUpper());
            Console.WriteLine("2.Ciphertext :" + ciphertext);
            Console.WriteLine("1. Plaintext :" + plaintext);

            Console.ReadLine();
        }


        public static string Encrypt(string plaintext, string key)
        {
            string ciphertext = " ";
            char[] keys = key.ToCharArray();
            int j = 0;
            foreach (char chr in plaintext)
            {
                int p = chr - 65;
                int c = keys[j] - 65;
                if (c >= p)
                    ciphertext += (char)((c - p) % 26 + 65);
                else
                    ciphertext += (char)((c - p + 26) % 26 + 65);
                j = (j + 1) % key.Length;
            }
            return ciphertext;
        }
        public static string Decrypt(string ciphertext, string key)
        {
            return Encrypt(ciphertext, key);
        }

    }
}
