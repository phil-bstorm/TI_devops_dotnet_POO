using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Models.Interfaces
{
    internal interface ICustomer
    {
        double Solde { get; }
        void Depot(double montant);
        void Retrait(double montant);
    }
}
