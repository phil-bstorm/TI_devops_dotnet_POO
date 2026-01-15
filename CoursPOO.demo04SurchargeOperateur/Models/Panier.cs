using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CoursPOO.demo04SurchargeOperateur.Models
{
    internal class Panier
    {
        private List<Fruit> _Fruits = [];

        public int Count
        {
            get
            {
                return _Fruits.Count; 
            }
        }

        public int AjoutFruit(Fruit fruit)
        {
            _Fruits.Add(fruit);
            return _Fruits.Count();
        }

        public int AjoutFruit(string nom)
        {
            Fruit nouveauFruit = new Fruit(nom);

            // Solution 1
            _Fruits.Add(nouveauFruit);
            return _Fruits.Count();

            // Solution 2
            //return AjoutFruit(nouveauFruit);
        }

        public static Panier operator +(Panier left, Panier right)
        {
            Panier panierCombiner = new Panier();
            foreach(Fruit f in left._Fruits)
            {
                panierCombiner.AjoutFruit(f);
            }

            foreach (Fruit f in right._Fruits)
            {
                panierCombiner.AjoutFruit(f);
            }

            return panierCombiner;
        }

        public static Panier operator +(Panier left, Fruit right)
        {
            left.AjoutFruit(right);
            return left;
        }

        public static Panier operator +(Panier left, string right)
        {
            left.AjoutFruit(right);
            return left;
        }

        public static bool operator ==(Panier left, Panier right)
        {
            return left.Count == right.Count;
        }

        public static bool operator !=(Panier left, Panier right)
        {
            //return left.Count != right.Count;

            // Nous recherchons si les paniers sont différents
            // donc si nos paniers sont égaux (==), on réutilise la surcharge ==
            // on retourne l'inverse (!)
            return !(left == right);
        }
    }
}
