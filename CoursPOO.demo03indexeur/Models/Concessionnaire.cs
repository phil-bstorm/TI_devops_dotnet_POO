using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.demo03indexeur.Models
{
    internal class Concessionnaire
    {
        private List<Voiture> _Voitures { get; set; } = [];

        public Voiture? this[string plaque]
        {
            get
            {
                Voiture? voiture = null;
                
                for(int i = 0; i < _Voitures.Count() && voiture is null; i++)
                {
                    if (_Voitures[i].Plaque == plaque)
                    {
                        voiture = _Voitures[i];
                    }
                }

                return voiture;
            }
        }

        public void Enregistrement(Voiture v)
        {
            _Voitures.Add(v);
            Console.WriteLine($"Voiture {v.Plaque} ajoutée.");
        }
    }
}
