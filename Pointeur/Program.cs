using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] table = new int[10]; 
            unsafe
            {
                fixed (int* p = table)
                {
                    for (int j = 0; j < 3; j++)*(p+j) = j;
                                          
                }
            }
            foreach (int i in table) Console.WriteLine(i);
        }
    }
}
