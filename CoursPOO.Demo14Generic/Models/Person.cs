using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Demo14Generic.Models
{
    internal class Person: IEquatable<Person>
    {
        public string Nom { get; private set;  }
        public string Prenom { get; private set; }

        public Person(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }

        public bool Equals(Person? other)
        {
            /*
            if (Nom != other?.Nom)
            {
                return false;
            }
            else if (Prenom != other.Prenom)
            {
                return false;
            }
            return true;
            */
            return Nom == other?.Nom && Prenom == other.Prenom;
        }
    }
}
