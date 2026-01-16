using CoursPOO.Demo07Abstract.Models;

namespace CoursPOO.Demo07Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Abstract!");
            List<Animal> animauxDuSalon = new List<Animal>();
            //animauxDuSalon.Add(new Animal()); Ne peut pas fonctioner car Animal est Abstract
            animauxDuSalon.Add(new Chien("Taz"));
            animauxDuSalon.Add(new Chat("Grosminet"));
            animauxDuSalon.Add(new Oiseau("Titi"));

            foreach (Animal a in animauxDuSalon)
            {
                a.Cri();
                if(a is Chien chien)
                {
                    chien.Garder();
                }
            }
        }
    }
}
