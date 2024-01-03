using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleAlgorithm
{
    internal class Program
    {
        static string Encrypt(string input, int shift)
        {
            char[] chars = input.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                char c = chars[i];

                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    chars[i] = (char)(((c + shift - offset) % 26) + offset);
                }
            }

            return new string(chars);
        }
        static string Decrypt(string input, int shift)
        {
            return Encrypt(input, 26 - shift);
        }

        static void Main()
        {
            string originalMessage = "Hello, World!";
            int shiftAmount = 3;

            string encryptedMessage = Encrypt(originalMessage, shiftAmount);
            Console.WriteLine("Encrypted message: " + encryptedMessage);

            // Decrypt the encrypted message
            string decryptedMessage = Decrypt(encryptedMessage, shiftAmount);
            Console.WriteLine("Decrypted message: " + decryptedMessage);
        }
    }
}
