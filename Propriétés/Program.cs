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
            Personne p1 = new Personne("Dupond","Jean",new DateTime(2000,5,25));
            Console.WriteLine(p1);
        }
    }
}
class Personne
{

    private string _nom;
        public string nom
    {
        get { return _nom; }
        set
        {
            if (value != null && value.Length >= 2) { _nom = value; }
        }
    }
    public string prenom { get; set; }
    private DateTime naissance;
    public int age
    {
        get
        {
            var t = DateTime.Now - naissance;
            return t.Days / 365;
        }
    }
    public Personne(string nom, string prenom,  DateTime naissance)
    {
        this.nom = nom;
        this.prenom = prenom;
        this.naissance = naissance;
    }
    public override string ToString()
    {
        return prenom + " " + nom + " : " + age + " ans";
    }
}
