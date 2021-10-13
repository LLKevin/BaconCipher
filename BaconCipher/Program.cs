using System;
using System.Text.RegularExpressions;

namespace BaconCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            int selectionKey = 0;
            string plainText = "";
            string cipherText = "";
            bool validMenuSelection = false;

            Regex lettersRegex = new Regex("[a-zA-Z]");
            Regex baconCipherRegex = new Regex(@"([abAB]{5})+");
            Regex whiteSpaceRegex = new Regex(@"\s");
         
            while (selectionKey != 3)
            {
                try
                {
                    Console.WriteLine("Press 1 to encrypt text with the bacon cipher\n" +
                                       "Press 2 to decrypt bacon cipher text\n" +
                                       "Press 3 to exit the program");
                    selectionKey = int.Parse(Console.ReadLine());
                    validMenuSelection = true;
                }
                catch(FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("You must enter a number\n");
                    validMenuSelection = false;
                }
                if(validMenuSelection == true) {

                    switch (selectionKey)
                    {
                        case 1:
                            do
                            {
                                Console.WriteLine("Enter text to be encrypted");
                                plainText = Console.ReadLine();
                                //check the user is only entering text before being sent to the encryption
                                if (!lettersRegex.IsMatch(plainText))
                                {
                                    Console.WriteLine("You can only use letters in the text, please try again");
                                }
                            } while (!lettersRegex.IsMatch(plainText));
                            Console.WriteLine(Encrypt.EncryptText(plainText));
                            break;
                        case 2:
                            Console.WriteLine("Enter bacon cipher text");
                            cipherText = Console.ReadLine();

                            //check the text to ensure the user is entering ciphertext that only contains a's & b's
                            if((cipherText.Length - whiteSpaceRegex.Matches(cipherText.Trim()).Count) % 5 == 0){
                                if (baconCipherRegex.IsMatch(cipherText))
                                {
                                    Console.WriteLine(Decrypt.DecryptText(cipherText));
                                }
                                else
                                {
                                    Console.WriteLine("The bacon ciphertext can only contain A's and B's, please try again\n");
                                }
                            }
                            else
                            {
                                Console.WriteLine("The entered ciphertext is not a valid bacon cipher," +
                                    " please try again using this format : aaaaa");

                            }

                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("You must select an option from the menu\n");
                            break;
                    }
                }
            }
        }
    }
}
