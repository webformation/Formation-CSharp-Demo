using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            jour j = jour.lundi;
            Console.WriteLine(j);
            foreach (var x in Enum.GetValues(typeof(jour)))
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
    enum jour { lundi, mardi, mercredi, jeudi, vendredi, samed, dimanche }
}
