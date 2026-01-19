using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Demo10Constructeur.Models
{
    internal class Guerrier : Personnage
    {
        public int Force { get; private set; }

        public Guerrier(string nom, int pv, int force = 50) : base(nom, pv)
        {
            Force = force;
        }

        public Guerrier(string nom): this(nom, 20, 70)
        {

        }
    }
}
