using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Demo08Static.Models
{
    internal abstract class Animal
    {
        public string Nom {  get; set; }

        public Animal(string nom)
        {
            Nom = nom;
        }

        public abstract void Cri();

        public virtual void Manger()
        {
            Console.WriteLine("Num num.");
        }
    }
}
