using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Models
{
    internal class Courant
    {
        public string Numero { get; set; }
        public double Solde { get; private set; }

        private double _LigneDeCredit;
        public double LigneDeCredit {
            get {  
                return _LigneDeCredit; 
            } 
            set {
                if (value < 0)
                {
                    _LigneDeCredit = 0;
                    // TODO mettre une exception
                }else
                {
                    _LigneDeCredit = value;
                }
            }
        }

        public Person Titulaire { get; set; }

        public Courant(string numero, double solde, double ligneDeCredit, Person titulaire)
        {
            Numero = numero;
            Solde = solde;
            LigneDeCredit = ligneDeCredit;
            Titulaire = titulaire;
        }

        public void Depot(double montant) {
            if(montant > 0)
            {
                Solde += montant;
            }
            else
            {
                // TODO exception
            }
        }

        public void Retrait(double montant)
        {
            if(montant > 0 && Solde-montant >= -LigneDeCredit)
            {
                Solde -= montant;
            }
            else
            {
                // TODO exception
            }
        }
    }
}
