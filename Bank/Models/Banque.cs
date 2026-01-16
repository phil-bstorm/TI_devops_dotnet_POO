using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Models
{
    internal class Banque
    {
        private List<Compte> _Comptes = [];

        public string Nom { get; set; }

        public Compte? this[string numero]
        {
            get
            {
                Compte? trouver = null;
                for (int i = 0; i < _Comptes.Count() && trouver is null; i++)
                {
                    if (numero == _Comptes[i].Numero)
                    {
                        trouver = _Comptes[i];
                    }
                }

                return trouver;
            }
        }

        public Banque(string nom)
        {
            Nom = nom;
        }

        public void Ajouter(Compte c)
        {
            _Comptes.Add(c);
        }

        // FAIS LA MEME CHOSE QUE L'INDEXEUR
        public Compte? GetCourantByNumero(string numero)
        {
            Compte? trouver = null;
            for (int i = 0; i < _Comptes.Count() && trouver is null; i++)
            {
                if (numero == _Comptes[i].Numero)
                {
                    trouver = _Comptes[i];
                }
            }

            return trouver;
        }

        public void Supprimer(string numero)
        {
            // Console.WriteLine(Nom);
            // // Le mot clé "this" fait référence à l'instance dans laquelle on est
            // Console.WriteLine(this.Nom);
            // Console.WriteLine(this._Courants);
            Compte? c = this[numero];

            if (c is not null)
            {
                _Comptes.Remove(c);
            }
        }

        public double AvoirDesComptes(Person titulaire)
        {
            double somme = 0;
            foreach (Compte courant in _Comptes)
            {
                if (titulaire == courant.Titulaire)
                {
                    somme += courant.Solde;
                }
            }
            return somme;
        }

        public double AvoirDesComptesVersionCorrectif(Person titulaire)
        {
            // Créer un "faux" compte qui va nous servir à faire la somme
            Compte courantSomme = new Compte("000", 0, new("", "", new()));

            foreach (Compte courant in _Comptes)
            {
                if (titulaire == courant.Titulaire)
                {
                    double solde = courantSomme + courant;
                    // Courant.Solde est privé, donc on est obligé de re-instancier un objet Courant
                    courantSomme = new Compte("000", solde, new("", "", new()));
                }
            }
            return courantSomme.Solde;
        }
    }
}
