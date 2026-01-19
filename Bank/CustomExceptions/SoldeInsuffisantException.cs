using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.CustomExceptions
{
    internal class SoldeInsuffisantException : Exception
    {
        public SoldeInsuffisantException(double soldeRestant) 
            : base($"Solde insufisant, il reste {soldeRestant}")   
        { 
        }
    }
}
