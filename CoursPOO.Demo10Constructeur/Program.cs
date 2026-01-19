using CoursPOO.Demo10Constructeur.Models;
using System.Runtime.Serialization;

namespace CoursPOO.Demo10Constructeur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Constructeur!");

            Personnage p = new Personnage("Jhon");
            Console.WriteLine($"Nom: {p.Nom}\tPV: {p.CurrentPV} \tpvMax: {p.PVMax}");

            Personnage p2 = new Personnage("Perseval", 21);
            Console.WriteLine($"Nom: {p2.Nom}\tPV: {p2.CurrentPV} \tpvMax: {p2.PVMax}");

            Personnage p3 = new Guerrier("Arthur", 100);

            if(p3 is Guerrier g)
            {
                Console.WriteLine($"Nom: {g.Nom}\tPV: {g.CurrentPV} \tpvMax: {g.PVMax}\t froce {g.Force}");

            }
        }
    }
}
