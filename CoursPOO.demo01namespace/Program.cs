using CoursPOO.demo01_bis;

namespace CoursPOO.demo01namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            CoursPOO.demo01namespace.sousNamespace.TestNamespace t = new CoursPOO.demo01namespace.sousNamespace.TestNamespace();
            // ou alors utiliser "using CoursPOO.demo01namespace.sousNamespace;"
        
           Class1 c1 = new Class1();
        }
    }
}
