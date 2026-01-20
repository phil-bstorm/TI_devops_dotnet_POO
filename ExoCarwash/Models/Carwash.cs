using System;
using System.Collections.Generic;
using System.Text;

namespace ExoCarwash.Models
{
    delegate void Wash(Voiture v);

    internal class Carwash
    {
        public Wash ProcessusDel;

        public Carwash()
        {
            ProcessusDel += Preparer;
            ProcessusDel += Laver;
            //ProcessusDel += Secher;
            //ProcessusDel += Finaliser;
            
            // Fonction anonyme
            ProcessusDel += delegate (Voiture v)
            {
                Console.WriteLine($"Je sèche la voiture : {v.Plaque}");
            };
            ProcessusDel += (Voiture v) =>
            {
                Console.WriteLine($"Je finalise la voiture : {v.Plaque}");
            };
        }

        private void Preparer(Voiture v)
        {
            Console.WriteLine($"Je prépare la voiture : {v.Plaque}");
        }
        private void Laver(Voiture v)
        {
            Console.WriteLine($"Je lave la voiture : {v.Plaque}");
        }
        private void Secher(Voiture v)
        {
            Console.WriteLine($"Je sèche la voiture : {v.Plaque}");
        }
        private void Finaliser(Voiture v)
        {
            Console.WriteLine($"Je finalise la voiture : {v.Plaque}");
        }

        public void Traiter(Voiture v)
        {
            if (ProcessusDel is not null)
            {
                ProcessusDel(v);
            }
        }
    }
}
