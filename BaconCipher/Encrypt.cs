using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaconCipher
{
    public class Encrypt
    {
        Dictionary<char, string> BaconCodes = new Dictionary<char, string>() { 
            { 'A', "aaaaa" },
            { 'B', "aaaab" },
            { 'C', "aaaba" },
            { 'D', "aaabb" },
            { 'E', "aabaa" },
            { 'F', "aabab" },
            { 'G', "aabba" },
            { 'H', "aabbb" },
            { 'I', "abaaa" },
            { 'J', "abaab" },
            { 'K', "ababa" },
            { 'L', "ababb" },
            { 'M', "abbaa" },
            { 'N', "abbab" },
            { 'O', "abbba" },
            { 'P', "abbbb" },
            { 'Q', "baaaa" },
            { 'R', "baaab" },
            { 'S', "baaba" },
            { 'T', "baabb" },
            { 'U', "babaa" },
            { 'V', "babab" },
            { 'W', "babba" },
            { 'X', "babbb" },
            { 'Y', "bbaaa" },
            { 'Z', "bbabb" },
        };
        public string GetEncodedValue(char letter)
        {
            return BaconCodes[letter];
        }

        public string EncryptText(string text)
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
