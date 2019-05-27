using System;
using System.Collections.Generic;
using System.Text;


namespace Delegate
{
    class Program_lambda
    {
        static void Main(string[] args)
        {
            essai e = new essai(f1);
            e(5);
            e = delegate(int j) { Console.WriteLine("Méthode anonyme : {0}", j); };
            e(7);
            e += f1;
            e(3);
            e =  x => Console.WriteLine("anonyme : {0}", x) ;
            e(0);
            essai2 f;
            f = x => { Console.WriteLine("anonyme : {0}", x); return x.ToString(); };
            f(23);
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
            // Console.WriteLine(c(5));
            // erreur lors de l'exécution avec la valeur null
            Console.ReadKey();
        }
        static void f1(int i) { Console.WriteLine("f1 : {0}", i); }

        
    }
    delegate int calcul(int i);
}
