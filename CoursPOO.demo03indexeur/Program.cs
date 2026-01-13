using CoursPOO.demo03indexeur.Models;

namespace CoursPOO.demo03indexeur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Concessionnaire!");

            Concessionnaire concess = new Concessionnaire();

            Voiture v1 = new Voiture("132", "Rose");
            Voiture v2 = new Voiture("456", "Rouge");
            Voiture v3 = new Voiture("789", "Vert");

            concess.Enregistrement(v1);
            concess.Enregistrement(v2);
            concess.Enregistrement(v3);


            Voiture? voitureRecuperee = concess["111"];
            if(voitureRecuperee is not null)
            {
                Console.WriteLine($"{voitureRecuperee.Plaque} - {voitureRecuperee.Couleur}");
            }else
            {
                Console.WriteLine("Pas trouvée...");
            }
        }
    }
}
