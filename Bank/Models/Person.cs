using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Models
{
    internal class Person
    {
        public string Nom { get; set;  }
        public string Prenom { get; set; }
        public DateTime DateNaiss { get; set; }

        public Person(string nom, string prenom, DateTime dateNaiss)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaiss = dateNaiss;
        }

    }
}
