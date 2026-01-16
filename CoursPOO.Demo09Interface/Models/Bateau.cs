using CoursPOO.Demo09Interface.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Demo09Interface.Models
{
    internal class Bateau : Vehicule, INaviguer
    {
        public void Naviguer()
        {
            Console.WriteLine("Bateau qui navigue");
        }
    }
}
