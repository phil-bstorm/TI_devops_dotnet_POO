using System;
using System.Collections.Generic;
using System.Text;

namespace ExoCarwash.Models
{
    internal class Voiture
    {
        public string Plaque { get; private set; }
        public Voiture(string plaque)
        {
            Plaque = plaque;
        }
    }
}
