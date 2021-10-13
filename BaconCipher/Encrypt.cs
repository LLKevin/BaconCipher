using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaconCipher
{
    public static class Encrypt
    { 
        private static string GetEncodedValue(char letter)
        {
            BaconDictionary dictionary = new BaconDictionary();
            return dictionary.BaconCodes[letter];
        }

        public static string EncryptText(string text)
        {
            string baconciphertext = "";

            text = text.ToUpper();
            for (int i = 0; i < text.Length; i++)
            {
                //if there is a blank space skip the dictionary check and add it. Assumes the spaces are words
                if (text[i] != ' ')
                {
                    baconciphertext += GetEncodedValue(text[i]);
                }
                else
                {
                    baconciphertext += " ";
                }
            }

            return baconciphertext; //baconciphertext
        }
    }
}
