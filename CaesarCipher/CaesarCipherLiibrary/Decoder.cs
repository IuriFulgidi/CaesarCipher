using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarCipherLibrary
{
    public class Decoder:CaesarBase
    {
        public char Decode(char ch)
        {
            return Cipher(ch);
        }

        public Decoder(int key)
        {
            Key = -key;
        }
    }
}
