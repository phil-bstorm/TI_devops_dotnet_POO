namespace CoursPOO.Demo11IDisposable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, IDisposable!");
            using (TalkieWalkie tw1 = new TalkieWalkie("Sacha"))
            {
                tw1.Parler("Allo?");
                using (TalkieWalkie tw2 = new TalkieWalkie("Brock"))
                {
                    tw2.Parler("Hello, c'est Brock");
                    tw1.Parler("Hello, c'est Sacha");
                }
            }
        }
    }
}
