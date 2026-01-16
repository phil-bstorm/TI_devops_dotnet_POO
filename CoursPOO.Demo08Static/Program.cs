using ConsoleTools;
using CoursPOO.Demo08Static.Models;

namespace CoursPOO.Demo08Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Static!");
            FakeDB.Animals.Add(new Chat("Scampi"));

            Zoo zoo = new();
            zoo.AfficherToutLesAnimauxDeLaDB();

            //Console.Write("Entrez votre nom:");
            //string nom = Console.ReadLine();

            string nom = ConsoleInputs.ReadString("Quel est ton nom? ");
            int entier1 = ConsoleInputs.ReadInt(reessayer: true);
            int entier = ConsoleInputs.ReadInt("Encore un entier: ");

        }
    }
}
