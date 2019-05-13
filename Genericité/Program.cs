using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExempleGenericité
{
    class Program
    {
        static void Main(string[] args)
        {
            mesure<int> m1 = new mesure<int>();
            m1.valeur = 3;
            Console.WriteLine(m1.valeur);
            mesure<double>[] banc1 = new mesure<double>[20];
            banc1[0] = new mesure<double>(3.14);
            Console.WriteLine(banc1[0].valeur);
        }
    }
    class mesure<T>
    {
        private T v;
        public T valeur
        {
            get { return v; }
            set
            {
                if (value != null)
                {
                    v = value;
                }
            }
        }
        public mesure() { }
        public mesure (T x) { valeur = x; }
    }
}
