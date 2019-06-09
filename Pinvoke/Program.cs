using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Pinvoke
{
    class Program
    {
        [DllImport("msvcrt.dll", CharSet = CharSet.Ansi)]
        public static extern int puts(String str);
       static void Main(string[] args)
        {
            puts("essai");
        }
    }
}
