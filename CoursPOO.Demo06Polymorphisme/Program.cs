using CoursPOO.Demo06Polymorphisme.Models;

namespace CoursPOO.Demo06Polymorphisme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Polymorphisme!");

            object phil = new Formateur("Doe", "John", "HTML");
            //phil.Dormir(); <- type object
            Personne philPersonne = (Personne)phil;
            philPersonne.Dormir(); // Personne.Dormir ou Formateur.Dormir?
            // si virtual avec override -> Formateur.Dormir
            // si dissimulation avec new -> Personne.Dormir
            Formateur philFormateur = (Formateur)phil;

            //Apprenant philApprenant = (Apprenant)phil;
            // NE fonctionne pas car la conversion de formateur vers apprenant n'est pas définie.        
        
            List<Personne> salleDeCours = new List<Personne>();
            salleDeCours.Add(philFormateur);
            salleDeCours.Add(new Apprenant("John","Doe","1111"));
            salleDeCours.Add(new Apprenant("Jane", "Doe", "1111"));
            salleDeCours.Add(new Apprenant("Pines", "Dipper", "1111"));
            salleDeCours.Add(new Apprenant("Pines", "Mabel", "1111"));
            salleDeCours.Add(new Formateur("Cypher", "Bill", "Mal"));

            foreach (Personne personne in salleDeCours)
            {
                Console.WriteLine($"Nom complet: {personne.NomComplet}");

                if (personne is Apprenant)
                {
                    Apprenant apprenant = (Apprenant)personne;
                    Console.WriteLine($"Salle {apprenant.Salle}");
                }else if (personne is Formateur formateur)
                {
                    Console.WriteLine($"Spe: {formateur.Specialisation}");
                }else
                {
                    Console.WriteLine("Personne normal.");
                }
            }
        }
    }
}
