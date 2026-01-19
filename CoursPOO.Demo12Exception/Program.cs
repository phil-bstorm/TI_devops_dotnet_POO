using CoursPOO.Demo12Exception.CustomExceptions;
using CoursPOO.Demo12Exception.Models;

namespace CoursPOO.Demo12Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Exception!");

            Console.Write("Entrez votre nom: ");
            string input = Console.ReadLine();

            
            try
            {
                // validation
                Validateurs.ValidationDeNom(input);
                Console.WriteLine("Nom valide");
            }
            catch(InvalidNameException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Un imprévu s'est produit...");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Aurevoir");
        }
    }
}
