using CoursPOO.Demo09Interface.Models;
using CoursPOO.Demo09Interface.Models.Interfaces;

namespace CoursPOO.Demo09Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Interface!");

            List<Vehicule> garages = new List<Vehicule>();

            garages.Add(new Avion());
            garages.Add(new Bateau());
            garages.Add(new Hydravion());
            garages.Add(new Voiture());
            garages.Add(new VoitureVolante());

            List<INaviguer> trucQuiVontSurLEau = new();

            foreach (Vehicule v in garages)
            {
                if(v is INaviguer)
                {
                    trucQuiVontSurLEau.Add((INaviguer)v);
                }
            }

            Console.WriteLine();
        }
    }
}
