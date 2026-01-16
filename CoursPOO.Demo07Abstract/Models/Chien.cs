using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Demo07Abstract.Models
{
    internal class Chien : Animal
    {
        public Chien(string nom) : base(nom)
        {
        }

        public override void Cri()
        {
            Console.WriteLine("Wouaf");
        }

        public void Garder()
        {
            Console.WriteLine("You shall not pass!!!!");
        }
    }
}
