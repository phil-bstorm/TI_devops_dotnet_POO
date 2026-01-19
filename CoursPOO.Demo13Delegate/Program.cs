using CoursPOO.Demo13Delegate.Models;

namespace CoursPOO.Demo13Delegate
{
    internal class Program
    {
        static bool continuerDeTaper = true;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Delegate!");
            Goblin g1 = new Goblin();

            // 4) Abonnement à la propriété
            g1.MortDel += Paillette;
            g1.MortDel += VictoryScreen;
            g1.MortDel += VictoryScreen;
            g1.MortDel += HeroDance;
            g1.MortDel += VictoryScreen;
            g1.MortDel += IlEstMort;

            while (continuerDeTaper)
            {
                Console.WriteLine("Taper le goblin!!!");
                g1.PrendreDegat(3);

                Thread.Sleep(1000);
            }
        }

        public static void Paillette()
        {
            Console.WriteLine("🎊🎊🎊");
        }

        public static void VictoryScreen()
        {
            Console.WriteLine("☆*: .｡. o(≧▽≦)o .｡.:*☆");
        }

        public static void HeroDance()
        {
            Console.WriteLine("🕺🕺🕺🕺🕺🕺");
        }

        public static void IlEstMort()
        {
            continuerDeTaper = false;
        }
    }
}
