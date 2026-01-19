using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Demo13Delegate.Models
{
    //1) Créer le type de notre delegate "Mort"
    delegate void Mort();

    internal class Goblin
    {
        private int _Pv = 10;

        // 2) On prépare la propriété qui stock les événements
        public Mort MortDel;

        public Goblin()
        {
            MortDel += TombeAuSol;
        }

        public void PrendreDegat(int montant)
        {
            _Pv -= montant;

            if (_Pv <= 0)
            {
                if (MortDel is not null)
                {
                    // 3) Appel la delegate
                    MortDel();
                }
            }
        }

        public void TombeAuSol()
        {
            Console.WriteLine("Aiiiiiiiie");
        }
    }
}
