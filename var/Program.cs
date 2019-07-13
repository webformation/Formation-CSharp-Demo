using System;

namespace var
{
    class Program
    {
        static void Main(string[] args)
        {
            var txt = "Bonjour";
            /*var txt;
            txt = "Bonjour"; */
            Console.WriteLine(txt);
            Console.WriteLine(txt.GetType());
            //txt = 3;
            var v = new { nom = "Jean", age = 20 };
            Console.WriteLine(v.GetType());
            Console.WriteLine(v.nom + " " + v.age);
            var v1 = new { nom1 = "Jeanne", age1 = 25 };
            Console.WriteLine(v1.GetType());
            Console.WriteLine(v1.nom1 + " " + v1.age1);
        }
    }
}
