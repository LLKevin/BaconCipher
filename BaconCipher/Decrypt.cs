using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaconCipher
{
    class Decrypt
    {
        private static char GetEncodedValue(string text)
        {
            BaconDictionary dictionary = new BaconDictionary();
            char foundBaconKey = ' ';

            text = text.ToLower();
            for (int i = 0; i < dictionary.BaconCodes.Count(); i++)
            {
               var baconCodeEntry = dictionary.BaconCodes.ElementAt(i);
                if(baconCodeEntry.Value == text){
                    foundBaconKey = baconCodeEntry.Key;
                }
            }
            return foundBaconKey;
        }

        public static string DecryptText(string text)
        {
            string plainText = "";
            //each space will a separate letter 
            string[] letters = text.Split(" ");

            for (int i = 0; i < letters.Length; i++)
            {
                plainText += GetEncodedValue(letters[i]);
            }

            return plainText;
        }
    }
}

