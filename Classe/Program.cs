using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p = new Personne(30,"Xavier");
            p.age = 20;
            p.nom = "Jean";
            Console.WriteLine(p);
        }
    }
}
