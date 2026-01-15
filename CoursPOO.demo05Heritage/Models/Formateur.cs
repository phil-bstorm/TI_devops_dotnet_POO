using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.demo05Heritage.Models
{
    internal class Formateur : Personne
    {
        public string Specialisation { get; set; }

        public void DonnerCours(string matiere)
        {
            Console.WriteLine("Donne cours de "+matiere);
        }

        public override void Dormir()
        {
            Console.WriteLine("Zz");
        }
    }
}
