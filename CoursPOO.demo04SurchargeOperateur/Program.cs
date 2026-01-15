using CoursPOO.demo04SurchargeOperateur.Models;

namespace CoursPOO.demo04SurchargeOperateur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Surcharge d'operateur!");

            Panier panierA = new Panier();
            // Surcharge de méthode (ce n'est pas le point de théorie actuel, juste un rappel)
            panierA.AjoutFruit("Banane");
            Fruit pomme = new Fruit("Pomme");
            panierA.AjoutFruit(pomme);

            Panier panierB = new Panier();
            panierB.AjoutFruit("Ananas");
            panierB.AjoutFruit("Litchee");

            Panier panierAB = panierA + panierB;
            panierA += pomme;
            panierB += "Poire";

            // Est-ce que mon panierA fait la même taille que panierB grâce
            // à l'opérateur ==
        }
    }
}
