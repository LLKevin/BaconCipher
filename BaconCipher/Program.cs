using System;

namespace BaconCipher
{
    class Program
    {
        static void Main(string[] args)
        {

            int selectionKey = 0;
            string plainText = "";
            string cipherText = "";

            while (selectionKey != 3)
            {
                Console.WriteLine("Press 1 to encrypt text with the bacon cipher\n" +
                                   "Press 2 to decrypt bacon cipher text\n" +
                                   "Press 3 to exit the program");
                selectionKey = int.Parse(Console.ReadLine());

                switch (selectionKey)
                {
                    case 1:
                        Console.WriteLine("Enter text to be encrypted");
                        plainText = Console.ReadLine();
                        Console.WriteLine(Encrypt.EncryptText(plainText));
                        break;
                    case 2:
                        Console.WriteLine("Enter bacon cipher text");
                        cipherText = Console.ReadLine();
                        break;
                }
            }
        }
    }
}
