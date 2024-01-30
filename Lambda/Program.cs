using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = { 1, 2, 3, 4, 5, 6, 7 };
            var pair = tableau.Where(x => x % 2 == 0);
            Console.WriteLine(pair);
            foreach (int i in pair) Console.WriteLine(i);
            List<int> pair2 = tableau.Where(x => x % 2 == 0).ToList();
            /*
             * foreach (int i in pair) liste.Add(i)
             */
            Func<int, bool> e1 = isPair;
            var pair3 = tableau.Where(e1).ToList();
            foreach (int i in pair3) Console.WriteLine(i);
            List<int> pair4 = tableau.Where(x =>  x % 2 == 0 || x % 3 == 0 ).ToList();

            foreach (int i in pair4) Console.WriteLine(i);
        }
        static bool isPair(int i) { return i%2 == 0; } 
    }
}
