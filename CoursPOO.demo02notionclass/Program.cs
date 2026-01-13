using CoursPOO.demo02notionclass.Models;

namespace CoursPOO.demo02notionclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Person phil = new Person("mauvaisemail@mail.com", "UnMotDePasse");
            Person alex = new Person("alex@mail.com", "SuperMotDePasse");

            // on utiliser le setter (du champs public)
            phil.Email = "philippe.haerens@bstorm.be";
            // on utiliser le getter (du champs public)
            Console.WriteLine(phil.Email);

            // ne fonctionne pas car _Password est en privé
            //phil._Password = "Test123=";
            //Console.WriteLine(phil._Password);
            Console.WriteLine(phil.Password);

            string mdp = Console.ReadLine();
            // savoir si j'ai tapé le bon mot de passe de phil
            bool goodPassword = phil.ComparePassword(mdp);
            if (goodPassword)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("KO");
            }
        }
    }
}
