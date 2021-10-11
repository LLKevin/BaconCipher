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

            for(int i = 0; i < text.Length; i++)
            {
                baconciphertext += GetEncodedValue(text[i]);
            }

            return baconciphertext; //baconciphertext
        }
    }
}
