using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Models.Interfaces
{
    internal interface IBanker : ICustomer
    {
        Person Titulaire {  get; }
        string Numero { get; }
        void AppliquerInteret();
    }
}
