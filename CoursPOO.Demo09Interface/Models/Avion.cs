using CoursPOO.Demo09Interface.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Demo09Interface.Models
{
    internal class Avion : Vehicule, IRouler, IVoler
    {
        public void Rouler(float kmH)
        {
            Console.WriteLine("Avion qui roule.");
        }

        public virtual void Voler()
        {
            Console.WriteLine("Avion qui vole.");
        }
    }
}
