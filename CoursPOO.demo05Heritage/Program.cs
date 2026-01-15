using CoursPOO.demo05Heritage.Models;

namespace CoursPOO.demo05Heritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Heritage!");

            Personne monsieurToutLeMonde = new Personne();
            monsieurToutLeMonde.Dormir();
            
            Apprenant Krzysztof = new Apprenant();
            Krzysztof.Apprendre("L'heritage");
            Krzysztof.Dormir();

            Formateur phil = new Formateur();
            phil.DonnerCours("C#");
            phil.Dormir();
        }
    }
}
