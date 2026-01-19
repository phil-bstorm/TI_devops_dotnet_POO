using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Demo12Exception.CustomExceptions
{
    internal class InvalidNameException : Exception
    {
        public InvalidNameException() : base("Ce nom est invalide.")
        {
        }

        public InvalidNameException(string nom) : base($"{nom} est invalide.")
        {
        }
    }
}
