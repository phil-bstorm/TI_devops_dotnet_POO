using Bank.CustomExceptions;
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
                if (value <= 0)
                {
                    throw new InvalidOperationException("La ligne de crédit doit être supérieur ou égale à zéro");
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

        public Courant(string numero, Person titulaire)
            : this(numero, 0, 0, titulaire)
        {

        }

        public Courant(string numero, Person titulaire, double ligneDeCredit)
            : this(numero, 0, ligneDeCredit, titulaire)
        {

        }

        public override void Retrait(double montant)
        {
            if(montant < 0)
            {
                throw new ArgumentOutOfRangeException("Le montant doit être supérieur à zéro.");
            } else if (Solde - montant <= -LigneDeCredit)
            {
                throw new SoldeInsuffisantException(Solde);
            }else
            {
                base.Retrait(montant);
            }
        }
        protected override double CalculerInteret()
        {
            return (Solde > 0) ? (Solde * 0.03) : (Solde * 0.0975);
        }
    }
}
