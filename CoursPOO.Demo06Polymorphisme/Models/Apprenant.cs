using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Demo06Polymorphisme.Models
{
    internal class Apprenant : Personne
    {
        public string Salle { get; set; }
        public Apprenant(string nom, string prenom, string salle) : base(nom, prenom)
        {
            Salle = salle;
        }

        public void Apprendre(string matiere)
        {
            Console.WriteLine("Apprentissage de " + matiere);
        }
    }
}
