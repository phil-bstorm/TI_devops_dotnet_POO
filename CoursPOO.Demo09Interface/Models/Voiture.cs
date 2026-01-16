using CoursPOO.Demo09Interface.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Demo09Interface.Models
{
    internal class Voiture : Vehicule, IRouler
    {
        public void Rouler(float kmH)
        {
            Console.WriteLine("Voiture qui roule.");
        }
    }
}
