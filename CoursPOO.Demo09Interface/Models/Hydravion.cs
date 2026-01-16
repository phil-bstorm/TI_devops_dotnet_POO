using CoursPOO.Demo09Interface.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Demo09Interface.Models
{
    internal class Hydravion : Avion, INaviguer
    {
        public void Naviguer()
        {
            Console.WriteLine("Hydravion qui navigue");
        }

        public override void Voler()
        {
            Console.WriteLine("Hydravion qui vole.");
        }
    }
}
