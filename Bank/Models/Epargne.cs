using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Models
{
    internal class Epargne : Compte
    {
        public DateTime? DateDernierRetrait { get; private set; }

        public Epargne(string numero, double solde, Person titulaire) : base(numero, solde, titulaire)
        {
        }

        public Epargne(string numero, Person titulaire): base(numero, titulaire)
        {

        }

        public override void Retrait(double montant)
        {
            if (montant <= 0)
            {
                // TODO exception (error)
                Console.WriteLine("Veuillez entrer un montant positif.");
            }
            else if (Solde - montant >= 0)
            {
                //Solde = Solde - montant; Solde est private donc je ne peux pas y accèder...
                base.Retrait(montant);
                DateDernierRetrait = DateTime.Now;
            }
            else
            {
                Console.WriteLine("Solde insufisant");
            }
        }

        protected override double CalculerInteret()
        {
            return Solde * 0.045;
        }
    }
}
