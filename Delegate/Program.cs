using System;
using System.Collections.Generic;
using System.Text;


namespace Delegate
{
    delegate void essai(int i);
    delegate string essai2(int i);
    delegate int calcul(int i);

    class Program
    {
        static void f1(int i) { Console.WriteLine("f1 : {0}", i); }
        static void Main(string[] args)
        {
            essai e = new essai(f1); // utilisation classique
            e(5);
            e = delegate(int j) { Console.WriteLine("Méthode anonyme : {0}", j); };
            e(7);
            Console.WriteLine("------------ 2 fonctions");
            e += f1;
            e(3);
            Console.WriteLine("------------ Lambda");
            e =  x => Console.WriteLine("Lambda : {0}", x) ;
            e(0);
            essai2 f;
            f = x => { Console.WriteLine("anonyme : {0}", x); return x.ToString(); };
            f(23);
            e = x => Console.WriteLine("anonyme : {0}", x);
            e(0);
            //f = x => { Console.WriteLine("anonyme : {0}", f(x)); return x.ToString(); }; 
            // passe à la compilation, mais stack overflow à l'exécution
            f(32);
            calcul c;
            //c = n => n * ((n <= 0)?1:c(n-1));
            // ne passe pas à la compilation : Use of unassigned local variable 'c'	
            int? i = 5;
            c = n => n + (int)i;
            Console.WriteLine(c(5));
            i = null;
            // erreur lors de l'exécution avec la valeur null
            //Console.WriteLine(c(5));

        }
    }
}
