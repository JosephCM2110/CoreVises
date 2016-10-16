using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    public class EncryptionMethod
    {

        public string encrypt(string text, string key)
        {
            String newText = "";
            String alphabet = "abcdefghijklmnopqrstuvwxyz1234567890,.";

            Char[] alphabetChar = alphabet.ToCharArray();
            Char[] textChar = text.ToCharArray();
            Char[] keyChar = key.ToCharArray();

            int keyPosition = 0;
            int letterPosition = 0;
            bool upper = false;
            for(int i = 0; i < text.Length; i++)
            {

            }

            return newText;
        }

        public string decrypting(string text, string key)
        {
            String newText = "";

            return newText;
        }

    }
}
