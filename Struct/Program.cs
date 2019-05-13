using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p1;
            //  Console.WriteLine(p1);  // erreur, p1 n'est pas initialisée
            p1.nom = "Jean";
            p1.age = 10;
            Console.WriteLine(p1);
            Personne p2 = new Personne("Xavier", 10);
            Console.WriteLine(p2);
        }
    }
    struct Personne
    {
        public string nom;
        public int age;
        public Personne(string nom, int age)
        {
            this.nom = nom;
            this.age = age;
        }
        public override string ToString()
        {
            return nom + " : " + age.ToString();
        }
    }
}
