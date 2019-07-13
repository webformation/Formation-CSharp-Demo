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
            p1.prenom = "xx";
            Ami a1 = new Ami("Dupond", "Jean", new DateTime(2000, 5, 25),"natation");
            p1 = a1;
            Console.WriteLine(p1);
            Console.WriteLine(a1);
            p1.m1();
            a1.m1();

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
    public virtual string prenom { get; set; }
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
    public Personne() { }
    public override string ToString()
    {
        return prenom + " " + nom + " : " + age + " ans";
    }
    public virtual  void m1() { Console.WriteLine("dans Personne"); }
    
}
class Ami : Personne
{
    public sealed override void m1() { Console.WriteLine("dans Ami"); }
    String hobby;
    public Ami() : base("", "", DateTime.Now) {
        hobby = "";
    }
    public Ami(String nom, String prenom,DateTime naissance, String hobby) : 
        base(nom, prenom, naissance)
    {     
        this.hobby = hobby;
        this.prenom = 0;
    }
    private int _prenom;
    public new  int prenom
    {
        get { return _prenom; }
        set { _prenom = value; }
    }

}
