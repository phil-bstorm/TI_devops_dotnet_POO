using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.demo03indexeur.Models
{
    internal class Voiture
    {
        public string Plaque { get; set; }
        public string Couleur { get; set; }
        
        public Voiture(string plaque, string couleur)
        {
            Plaque = plaque;
            Couleur = couleur;
        }
    }
}
