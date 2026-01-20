using CoursPOO.Demo14Generic.Models;
using CoursPOO.Demo14Generic.Tools;

namespace CoursPOO.Demo14Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Generic!");

            List<Person> ppl = new() { 
                new Person("Cypher", "Bill"),
                new Person("Cypher", "Bill")
            };
            ppl.Add(new Person(prenom: "John", nom: "Doe"));
            ppl.Add(new Person(prenom: "Jane", nom: "Doe"));
            ppl.Add(new Person(prenom: "Harry", nom: "Potter"));

            List<int> ints = new([2, 8, 4]);
            List<string> strings = new(["b", "a", "c"]);

            ints.Sort();
            strings.Sort();
            ppl.Sort();


            Dictionary<string, Person> dicPerson = new();

            dicPerson.Add("RS", new Person("Rogue", "Sevrus"));



            int posA = ArrayUtils.FindPosition(strings, "a");
            int posDeux = ArrayUtils.FindPosition(ints, 2);
            int posJohn = ArrayUtils.FindPosition(ppl, new Person("Doe", "John"));

            int posJane = ArrayUtils.FindPosition(ppl, (e) =>
            {
                return e.Prenom == "Jane";
            });

            int posHarry = ArrayUtils.FindPosition(ppl, (e) => e.Prenom == "Harry");
        }
    }
}
