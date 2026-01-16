using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Demo08Static.Models
{
    internal class Chat : Animal
    {
        public Chat(string nom) : base(nom)
        {
        }

        public override void Cri()
        {
            Console.WriteLine("Miaou");
        }
    }
}
