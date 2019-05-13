using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        int i;
        static void Main(string[] args)
        {
            int i;
            unsafe
            {
                int* p = &i;
                *p = 3;
                int* q = p;
                Console.WriteLine(q - p);
                *p = 4;


            }
            Console.WriteLine(i);
            string s1 = "";
            float f = 3.14f;
            int[] table = new int[10];
            foreach (var x in table) { Console.WriteLine(x); }
            int[] tab = { 1, 2, 3 };
            foreach (var x in tab) { Console.WriteLine(x); }
            string[] liste = new string[5];
            foreach (var x in liste) { Console.WriteLine(x); }
            float res = 1.0f / 2;
            Console.WriteLine(res);
        }
    }
}
