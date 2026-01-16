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

            // Ajouter des compte épargnes dans la banque
            belfius.Ajouter(new Epargne("E01", 10, phil));

            // Complémentaire: Créer une méthode qui
            // affiche Haerens a 1 compte épargne et 2 compte courant
            // BONUS: faites en sorte que la méthode retourne les 2 valeurs
            // et que ça soit le program.cs qui fait le Console.WriteLine
            // Indice bonus: mot clé utiliser avec "int.TryParse" -> out
            belfius.NombreDeCompteDe("Haerens", out int courants, out int epargnes);
            Console.WriteLine($"Courants {courants} | Epargnes {epargnes}");

            //Compte cE01 = belfius["E01"];
            //cE01.Solde
            Console.WriteLine($"Montant avant interet: {belfius["E01"].Solde}");
            belfius.AppliquerInteretAuxComtpes();
            bnp.AppliquerInteretAuxComtpes();
            Console.WriteLine($"Montant avant interet: {belfius.GetCompteByNumero("E01").Solde}");
        }
    }
}
