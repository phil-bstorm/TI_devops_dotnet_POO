using Bank.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Models
{
    internal abstract class Compte: IBanker
    {
        public string Numero { get; private set; }
        public double Solde { get; private set; }
        public Person Titulaire { get; private set; }

        public Compte(string numero, double solde, Person titulaire)
        {
            Numero = numero;
            Solde = solde;
            Titulaire = titulaire;
        }

        public Compte(string numero, Person titulaire) : this(numero, 0, titulaire)
        {

        }

        public virtual void Retrait(double montant)
        {
            if (montant < 0)
            {
                throw new ArgumentOutOfRangeException("Le montant doit être supérieur à zéro.");
            }

            Solde = Solde - montant;
        }

        public void Depot(double montant)
        {
            if (montant > 0)
            {
                Solde += montant;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Le montant doit être supérieur à zéro.");
            }
        }

        // Surcharge d'operateur "+"
        public static double operator +(Compte left, Compte right)
        {
            if (left.Solde >= 0 && right.Solde >= 0)
            {
                return left.Solde + right.Solde;
            }
            else if (left.Solde >= 0)
            {
                return left.Solde;
            }
            else if (right.Solde >= 0)
            {
                return right.Solde;
            }
            else
            {
                return 0;
            }
        }

        protected abstract double CalculerInteret();

        public void AppliquerInteret()
        {
            Solde = Solde + CalculerInteret();
        }

        
    }
}
