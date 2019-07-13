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
            void change(in Personne p)
            {
                p.nom = "raz";
                //change1(ref p);
;               //p = new Personne();
            }
            void change1(ref Personne p) { }
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
            nbvar();
            nbvar(10, 20,30,50);
            
            int f10(int il, float f=10, object o = null)
            {
                string txt = (o == null) ? "null" : "pas null";
                return il + (int)f;
            }
            f10( o: "text",f:50,il:2);
        }
    }
    class Personne
    {
        public string nom { get; set; }
    }
}
