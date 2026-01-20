using ExoCarwash.Models;

namespace ExoCarwash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Carwash!");

            Voiture v1 = new Voiture("abc123");
            Voiture v2= new Voiture("def456");

            Carwash cw = new Carwash();
            cw.Traiter(v1);
            cw.Traiter(v2);
        }
    }
}
