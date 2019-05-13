using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Bonjour";
            s += " à tous";
            string s1 = s.Insert(7, " à toutes et");
            Console.WriteLine(s);
            Console.WriteLine(s1);
            if (s1.Contains("toutes")) Console.WriteLine("Féminin");
            Console.WriteLine(s1.ToUpper());
        }
    }
}
