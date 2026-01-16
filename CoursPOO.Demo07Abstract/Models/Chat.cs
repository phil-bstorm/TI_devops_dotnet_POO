using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Demo07Abstract.Models
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
