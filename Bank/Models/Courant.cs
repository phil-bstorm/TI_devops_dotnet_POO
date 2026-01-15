using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Bank.Models
{
    internal class Courant : Compte
    {
        private double _LigneDeCredit;
        public double LigneDeCredit
        {
            get
            {
                return _LigneDeCredit;
            }
            set
            {
                if (value < 0)
                {
                    _LigneDeCredit = 0;
                    // TODO mettre une exception
                }
                else
                {
                    _LigneDeCredit = value;
                }
            }
        }

        public Courant(string numero, double solde, double ligneDeCredit, Person titulaire) : base(numero, solde, titulaire)
        {
            LigneDeCredit = ligneDeCredit;
        }

        public void Retrait(double montant)
        {
            if (montant > 0 && Solde - montant >= -LigneDeCredit)
            {
                base.Retrait(montant);
            }
            else
            {
                // TODO exception
            }
        }


    }
}
