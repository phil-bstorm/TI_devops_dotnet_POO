using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Models
{
    internal class Person
    {
        public string Nom { get; private set;  }
        public string Prenom { get; private set; }
        public DateTime DateNaiss { get; private set; }

        public Person(string nom, string prenom, DateTime dateNaiss)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaiss = dateNaiss;
        }

    }
}
