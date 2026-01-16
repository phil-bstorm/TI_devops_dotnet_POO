using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Demo08Static.Models
{
    internal class Zoo
    {
        public void AfficherToutLesAnimauxDeLaDB()
        {
            List<Animal> animauxDeLaDB = FakeDB.Animals;

            foreach (Animal animal in animauxDeLaDB)
            {
                Console.WriteLine($"\t- {animal.Nom}");
            }
        }
    }
}
