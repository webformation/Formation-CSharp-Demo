using System;
using System.Collections.Generic;
using System.Text;


namespace Delegate
{
    delegate void essai(int i);
    delegate string essai2(int i);

    class Program
    {
        static void f1(int i) { Console.WriteLine("f1 : {0}", i); }
        static void Main(string[] args)
        {
            essai e = new essai(f1); // utilisation classique
            e(5);
            e = delegate(int j) { Console.WriteLine("Méthode anonyme : {0}", j); };
            e(7);
            e += f1;
            e(3);
            e =  x => Console.WriteLine("Lambda : {0}", x) ;
            e(0);
            essai2 f;
            f = x => { Console.WriteLine("anonyme : {0}", x); return x.ToString(); };
            f(23);
            Console.ReadKey();
        }
    }
}
