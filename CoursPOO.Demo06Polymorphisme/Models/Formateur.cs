using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Demo06Polymorphisme.Models
{
    internal class Formateur : Personne
    {
        public string Specialisation { get; set; }

        public Formateur(string nom, string prenom, string specialisation) : base(nom, prenom)
        {
            Specialisation = specialisation;
        }

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
