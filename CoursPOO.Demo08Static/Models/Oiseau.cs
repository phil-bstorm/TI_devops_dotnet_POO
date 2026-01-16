using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Demo08Static.Models
{
    internal class Oiseau : Animal
    {
        public Oiseau(string nom) : base(nom)
        {
        }

        public override void Cri()
        {
            Console.WriteLine("Cui cui");
        }

        public override void Manger()
        {
            Console.WriteLine("pic pic");
        }
    }
}
