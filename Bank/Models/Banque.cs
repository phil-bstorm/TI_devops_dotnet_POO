using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Models
{
    internal class Banque
    {
        private List<Courant> _Courants = [];

        public string Nom { get; set; }

        public Courant? this[string numero]
        {
            get
            {
                Courant? trouver = null;
                for (int i = 0; i < _Courants.Count() && trouver is null; i++)
                {
                    if (numero == _Courants[i].Numero)
                    {
                        trouver = _Courants[i];
                    }
                }

                return trouver;
            }
        }

        public Banque(string nom)
        {
            Nom = nom;
        }

        public void Ajouter(Courant c)
        {
            _Courants.Add(c);
        }

        // FAIS LA MEME CHOSE QUE L'INDEXEUR
        public Courant? GetCourantByNumero(string numero)
        {
            Courant? trouver = null;
            for (int i = 0; i < _Courants.Count() && trouver is null; i++)
            {
                if (numero == _Courants[i].Numero)
                {
                    trouver = _Courants[i];
                }
            }

            return trouver;
        }

        public void Supprimer(string numero)
        {
            Console.WriteLine(Nom);
            // Le mot clé "this" fait référence à l'instance dans laquelle on est
            Console.WriteLine(this.Nom);
            Console.WriteLine(this._Courants);
            Courant? c = this[numero];

            if (c is not null)
            {
                _Courants.Remove(c);
            }
        }
    }
}
