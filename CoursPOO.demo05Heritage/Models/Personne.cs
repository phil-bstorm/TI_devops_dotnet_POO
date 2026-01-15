using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.demo05Heritage.Models
{
    internal class Personne
    {
        public string Nom {  get; set; }
        public string Prenom { get; set; }

        public string NomComplet
        {
            get
            {
                return $"{Nom} {Prenom}"; 
            }
        }

        public virtual void Dormir()
        {
            Console.WriteLine("Zzzzzz");
        }
    }
}
