using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodeExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            String accueil = "Bonjour, il fait beau";
            var longueur = accueil.NbMot();
            Console.WriteLine(String.Format("Length {0}, count {1}", longueur.length, longueur.count));
        }
    }
    static class ExempleExtension
    {
        static public longueurs NbMot(this String s)
        {
            char[] separateurs = { ' ', ',', ';','.','\t' };
            String[] Liste = s.Split(separateurs);
            var l = from x in Liste
                     where x.Trim().Length != 0
                     select x;
            return new longueurs(Liste.Length, l.Count());
        }
    }
    class longueurs
    {
        public int length { get; set; }
        public int count { get; set; }
        public longueurs(int length, int count)
        {
            this.length = length;
            this.count = count;
        }
    }
}
