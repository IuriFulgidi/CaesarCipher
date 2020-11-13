using System;

namespace CaesarCipherLiibrary
{
    public abstract class CaesarBase
    {
        protected int Key { get; set; }
        private char Cipher(char ch)
        {
            //se il caratte non è una lettera si restituisce così com'è
            if (!char.IsLetter(ch))
                return ch;
            //si crea la variabile che ha il valore il carattere
            char offset;
            //se la lettera è maiuscola si parte dall A maiuscola
            if (char.IsUpper(ch))
                offset = 'A';
            //altrimenti dalla a minuscola
            else
                offset = 'a';
            //il resto tra (la lettera in input meno il valore in base a se sia maiuscola o minuscola
            //più la chiave) diviso 26 più il valore di prima
            return (char)(((ch - offset + Key) % 26) + offset);
        }
    }
}
