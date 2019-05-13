using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleEnum
{
class Program
{
    static void Main(string[] args)
    {
        jour j = jour.lundi;
        Console.WriteLine(j);
    }
}
enum jour { lundi,mardi,mercredi, jeudi, vendredi, samed,dimanche}
}
