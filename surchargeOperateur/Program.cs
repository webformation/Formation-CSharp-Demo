using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SurchargeOperateur
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne("Dupond");
            Personne p2 = new Personne("Dupond");
            Console.WriteLine(p1 == p2);
            Console.WriteLine(p1.Equals(p2));
            Console.ReadKey();
        }
    }
    class Personne
    {
        string nom;
        public Personne(string nom)
        {
            this.nom = nom;
        }
        public static bool operator ==(Personne p1, Personne p2)
        {
            return p1.Equals(p2);
        }
        public static bool operator !=(Personne p1, Personne p2)
        {
            return ! p1.Equals(p2);
        }
        public override bool Equals(object obj)
        {
            /* écriture récursive qui finit par planter !!!
            Personne p = obj as Personne;
            if (p == null) return false; 
             */
      if (obj is Personne)
            {
                return this.nom == ((Personne)obj).nom;
            }
            else return false;
        }
    }
}
