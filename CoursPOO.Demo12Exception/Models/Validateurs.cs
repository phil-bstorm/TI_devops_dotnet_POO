using CoursPOO.Demo12Exception.CustomExceptions;

namespace CoursPOO.Demo12Exception.Models
{
    internal static class Validateurs
    {
        public static bool ValidationDeNom(string nomAValider)
        {
            if (nomAValider == "invalide")
            {
                // erreur
                throw new InvalidNameException(nomAValider);
            }
            return true;
        }
    }
}
