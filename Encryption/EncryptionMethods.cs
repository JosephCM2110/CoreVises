using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    public class EncryptionMethods
    {
        private string alphabet;

        private char[] alphabetChar;

        public EncryptionMethods()
        {
            this.alphabet = "abcdefghijklmnopqrstuvwxyz1234567890,.";
            this.alphabetChar = alphabet.ToCharArray();
        }

        public string encrypt(string text, string key)
        {
            string newText = "";

            char[] textChar = text.ToCharArray();
            char[] keyChar = key.ToCharArray();
            int k = 0;
            int keyPosition = 0;
            int letterPosition = 0;
            int newPosition = 0;
            for(int i = 0; i < text.Length; i++)
            {
                letterPosition = findLetter(textChar[i]);
                keyPosition = findLetter(keyChar[k]);
                newPosition = letterPosition + keyPosition;
                if(newPosition > alphabet.Length)
                {
                    newPosition = newPosition - alphabet.Length;
                }
                newText += alphabetChar[newPosition-1];
                k++;
                if (k == key.Length)
                {
                    k = 0;
                }
            }

            return newText;
        }

        public string decrypting(string text, string key)
        {
            string newText = "";

            char[] textChar = text.ToCharArray();
            char[] keyChar = key.ToCharArray();
            int k = 0;
            int keyPosition = 0;
            int letterPosition = 0;
            int newPosition = 0;
            for (int i = 0; i < text.Length; i++)
            {
                letterPosition = findLetter(textChar[i]);
                keyPosition = findLetter(keyChar[k]);
                newPosition = letterPosition - keyPosition;
                if (newPosition < 1)
                {
                    newPosition = alphabet.Length+ newPosition;
                }
                newText += alphabetChar[newPosition - 1];
                k++;
                if (k == key.Length)
                {
                    k = 0;
                }
            }

            return newText;
        }

        private int findLetter(char letter)
        {
            int pos = 0;

            for(int i = 0; i < this.alphabet.Length; i++)
            {
                if(char.ToUpperInvariant(letter) == char.ToUpperInvariant(alphabetChar[i]))
                {
                    pos = i + 1;
                    i = this.alphabet.Length;
                }
            }

            return pos;
        }

    }
}
