using CoursPOO.Demo09Interface.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Demo09Interface.Models
{
    internal class VoitureVolante : Voiture, IVoler
    {
        public void Voler()
        {
            Console.WriteLine("Voiture volante qui vole.");
        }
    }
}
