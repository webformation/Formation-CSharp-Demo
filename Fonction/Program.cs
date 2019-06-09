using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonction
{
    class Program
    {
        static void Main(string[] args)
        {
            int multi(int k)
            {
                k *= 2;
                return k;
            }
            int i = 5;
            multi(i);
            Console.WriteLine(i); // affiche 5
            int refmulti(ref int k)
            {
                k *= 2;
                return k;
            }
            refmulti(ref i);
            Console.WriteLine(i); // affiche 10
            void change(Personne p)
            {
                p.nom = "raz";
            }
            Personne p1 = new Personne();
            p1.nom = "Jean";
            Console.WriteLine(p1.nom);
            change(p1);
            Console.WriteLine(p1.nom);
            void init(out int k)
            {
                k = 3;
            }
            int j;
            init(out j);
            Console.WriteLine(j);
            void nbvar( params int[]  vars)
            { 
               foreach (var x in vars) { Console.WriteLine(x); }
            }
            nbvar(1);
            nbvar(10, 20);
        }
    }
    class Personne
    {
        public string nom { get; set; }
    }
}
