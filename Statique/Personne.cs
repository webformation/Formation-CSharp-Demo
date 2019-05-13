using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statique
{
    class Personne : IDisposable
    {
        public string nom;
        public int age;
        static int nombre = 0;
        public Personne(string nom, int age)
        {
            this.nom = nom;
            this.age = age;
            ++nombre;
        }
        public void Dispose()
        {
            --nombre;
        }
        public static int nb
        {
            get
            {
                return nombre;
            }
        }
    }
}
