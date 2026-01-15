using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.demo05Heritage.Models
{
    internal class Apprenant : Personne
    {
        public void Apprendre(string matiere)
        {
            Console.WriteLine("Apprentissage de " + matiere);
        }
    }
}
