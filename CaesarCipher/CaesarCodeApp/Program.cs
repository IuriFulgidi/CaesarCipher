using CaesarCipherLibrary;
using System;

namespace CaesarCodeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //inserimento della parola da cifrare
            Console.WriteLine("inserire la frase da decifrare");
            string s = Console.ReadLine();

            //inserimento della chiave
            Console.WriteLine("inserire la chiave");
            int k = Convert.ToInt32(Console.ReadLine());

            //creazione delle variabili con frase cifrata e decifrata
            Encoder enc = new Encoder(k);
            string codificata = "";
            Decoder dec = new Decoder(k);
            string decodificata = "";

            //cifratura e decifratura
            foreach(char lettera in s)
                codificata+=enc.Encode(lettera);
            foreach (char lettera in codificata)
                decodificata += dec.Decode(lettera);

            //stampa del risultato
            Console.WriteLine("parola cifrata");
            Console.WriteLine(codificata);
            Console.WriteLine("parola decifrata");
            Console.WriteLine(decodificata);
            Console.ReadLine();
        }
    }
}
