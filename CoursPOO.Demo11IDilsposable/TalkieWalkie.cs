using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Demo11IDisposable
{
    internal class TalkieWalkie: IDisposable
    {
        public string Nom { get; private set; }

        public TalkieWalkie(string nom)
        {
            Nom = nom;
            Console.WriteLine($"{nom} est connecté");
        }

        public void Parler(string message)
        {
            Console.WriteLine($"{Nom} {DateTime.Now.ToShortTimeString()} : {message}");
            Console.WriteLine("A vous!");
        }

        public void Dispose()
        {
            Console.WriteLine($"{Nom} s'est déconnecté");
        }
    }
}
