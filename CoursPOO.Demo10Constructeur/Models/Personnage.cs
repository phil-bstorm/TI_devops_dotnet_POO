using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Demo10Constructeur.Models
{
    internal class Personnage
    {
        public string Nom { get; private set; }
        public int CurrentPV { get; private set; }
        public int PVMax { get; private set; }
        public Personnage(string nom, int currentPV, int pVMax)
        {
            Nom = nom;
            CurrentPV = currentPV;
            PVMax = pVMax;
        }

        public Personnage(string nom, int pv) : this(nom, pv, pv) 
        { }

        public Personnage(string nom) : this(nom, 20) 
        { }
        
        // Constructeur par défaut
        //public Personnage()
        //{
        //    Nom = "John Doe";
        //    CurrentPV = 0;
        //    PVMax = 0;
        //}
    }
}
