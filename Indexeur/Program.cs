using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExempleIndexeur
{
    class Program
    {
        static void Main(string[] args)
        {
            Bibliotheque b1 = new Bibliotheque();
            b1[0] = "Le C# c'est simple";
            b1[1] = "Utiliser le Framework.NET";
            Console.WriteLine(b1[1]);
            Console.WriteLine(b1[0]);
            Console.ReadKey();
        }
    }
    class Bibliotheque
    {
        string[] _livres;
        public Bibliotheque()
        {
            _livres = new string[10];
        }
        public string this[int index]
        {
            get { return _livres[index]; }
            set { _livres[index] = value; }
        }
    }
}
