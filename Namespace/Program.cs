//using premier;
using second;
using System;

namespace Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            premier.essai e1 = new premier.essai(3);
            second.essai e2 = new second.essai(5);
            Console.WriteLine(e1.fonction());
            Console.WriteLine(e2.fonction());
            essai e3 = new essai(6);
            Console.WriteLine(e2.fonction());
        }
    }
}
namespace premier
{
    public class essai
    {
        public int i;
        public int fonction() { return i; }
        public essai(int k) { i = k; }
    }
}
namespace second
{
    public class essai
    {
        public int j;
        public int fonction() { return j * 2; }
        public essai(int k) { j = k; }
    }
}
