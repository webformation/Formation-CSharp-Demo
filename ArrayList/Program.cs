using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> liste = new List<string>(0);
            liste.Add("janvier");
            liste.Add("février");
            Console.WriteLine("Capacité {0}", liste.Capacity);
            Console.WriteLine("Taille {0}", liste.Count);
            foreach (var x in liste) Console.WriteLine("{0} contient {1} lettres",x,x.Length);
            ArrayList aliste = new ArrayList(0);
            aliste.Add("mars");
            aliste.Add("avril");
            Console.WriteLine("Capacité {0}", aliste.Capacity);
            Console.WriteLine("Taille {0}", aliste.Count);
            foreach (var x in aliste)
            {
                string txt = (string)x;
                Console.WriteLine("{0} contient {1} lettres", txt, txt.Length);
            }
        }
    }
}
