using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriétés
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne("Jean",new DateTime(2000,5,25));
            Console.WriteLine(p1);
        }
    }
}
class Personne
{
    public string nom { get; set; }
    private DateTime naissance;
    public int age
    {
        get
        {
            var t = DateTime.Now - naissance;
            return t.Days / 365;
        }
    }
    public Personne(String nom, DateTime naissance)
    {
        this.nom = nom;
        this.naissance = naissance;
    }
    public override string ToString()
    {
        return nom + " : " + age + " ans";
    }
}
