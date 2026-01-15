using Bank.Models;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Instance des Person
            Person michelle = new Person("Proforma", "Michelle", new DateTime(1987, 9, 27));
            Person phil = new("Haerens", "Philippe", new(1997, 9, 9));

            // Instance des Courant
            Courant cMichelle = new Courant("a12345", 10_000, 1500, michelle);
            Courant cPhil = new("BE11", 100, 0, phil);
            Courant cPhil2 = new("BE12", 200, 0, phil);
            Courant cPhil3 = new("BE13", 150, 0, phil);

            // Instance d'un Courant avec Person en même temps
            Courant cJohn = new Courant("BE22",
                1_000_000,
                10_000,
                new Person("Doe", "John", new DateTime(1987, 10, 25))
             );

            // UTILISATION DES METHODES
            cMichelle.Depot(-10);
            Console.WriteLine($"Compte de Michelle: {cMichelle.Solde}");
            cMichelle.Depot(100);
            Console.WriteLine($"Compte de Michelle: {cMichelle.Solde}");
            cPhil.Retrait(10);
            Console.WriteLine($"Compte de Phil: {cPhil.Solde}");
            cPhil.Retrait(5_000);
            Console.WriteLine($"Compte de Phil: {cPhil.Solde}");

            // BANQUE et Indexeur
            Banque belfius = new Banque("Belfius");
            Banque bnp = new Banque("BNP");
            
            belfius.Ajouter(cPhil);
            belfius.Ajouter(cPhil2);
            bnp.Ajouter(cPhil3);
            bnp.Ajouter(cMichelle);
            belfius.Ajouter(cJohn);

            belfius.Supprimer("BE22");

            double sommeDePhilBelfius = belfius.AvoirDesComptes(phil);
            Console.WriteLine($"Phil a {sommeDePhilBelfius} chez Belfius.");
            double sommeDePhilBNP = bnp.AvoirDesComptes(phil);
            double total = sommeDePhilBelfius + sommeDePhilBNP;
        }
    }
}
