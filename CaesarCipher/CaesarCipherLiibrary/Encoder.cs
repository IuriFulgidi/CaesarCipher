using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarCipherLibrary
{
    public class Encoder:CaesarBase
    {
        public char Encode(char ch)
        {
            return Cipher(ch);
        }

        public Encoder( int key)
        {
            Key = key;
        }

    }
}
