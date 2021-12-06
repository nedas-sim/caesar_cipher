using System;

namespace Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            EncryptingFullCircle();
        }

        static void CheckingEncryption()
        {
            var cipher = new CaesarCipher();
            var message = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
            var result1 = cipher.Encrypt(message);
            var result2 = cipher.Encrypt(message.ToLower());
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }

        static void EncryptingFullCircle()
        {
            var cipher = new CaesarCipher(26);
            var message = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
            var result1 = cipher.Encrypt(message);
            var result2 = cipher.Decrypt(message);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }
}
