using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statique
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nombre de personnes : {0}", Personne.nb);
            Personne p1 = new Personne("Jean", 20);
            Console.WriteLine("Nombre de personnes : {0}", Personne.nb);
            using (Personne p2 = new Personne("Marc", 30))
            {
                Console.WriteLine("Nombre de personnes : {0}", Personne.nb);
            }
            Console.WriteLine("Nombre de personnes : {0}", Personne.nb);
        }
    }
}
