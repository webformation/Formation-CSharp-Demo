using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int d;
                int.TryParse(args[0], out d);
                int i = 1 / d;
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Code exécuté dans tous les cas");
            }
        }
    }
}
