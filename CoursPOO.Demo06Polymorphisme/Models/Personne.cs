using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Demo06Polymorphisme.Models
{
    internal class Personne
    {
        public string Nom {  get; private set; }
        public string Prenom { get; set; }

        public string NomComplet
        {
            get
            {
                return $"{Nom} {Prenom}"; 
            }
        }

        public Personne(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }

        public virtual void Dormir()
        {
            Console.WriteLine("Zzzzzz");
        }
    }
}
