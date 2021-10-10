using System;

namespace BaconCipher
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * This function will accept a string to be encrypted or decrypted
             * Display a menu of options to select from
             * encryption & decryption 
             */

            Encrypt encrypt = new Encrypt();
            Console.WriteLine(encrypt.EncryptText("ABC"));

        }
    }
}
