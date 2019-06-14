using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Ami a = new Ami("Jean", "Dupont");
            a.Tel();
            a.Mail();
            Personne p = a;
            p.Mail();
            p.SMS();
            p.Skype();
        }
    }
    public abstract class Personne
    {
        public string nom;
        public Personne(string nom)
        {
            this.nom = nom;
        }
        public void Tel()
        {
            Console.WriteLine("Téléphoner à " + nom);
        }
        public void Mail()
        {
            Console.WriteLine("Envoyer un mail à " + nom);
        }
        public virtual void SMS()
        {
            Console.WriteLine("Envoyer un sms à " + nom);
        }
        public abstract void Skype();
    }
    public class Ami : Personne,Icommmunication
    {
        public string prenom;
        public Ami(string prenom, string nom) : base(nom)
        {            
            this.prenom = prenom;
        }
        public void Mail()
        {
            Console.WriteLine("Envoyer un mail à " + prenom);
        }
        public override  void SMS()
        {
            Console.WriteLine("Envoyer un sms à " + prenom);
        }
        public override void Skype()
        {
            Console.WriteLine("Lancer Skype avec " + prenom);
        }

        public void Courrier()
        {
            Console.WriteLine("Envoyer une lettre à " + prenom);
        }
    }
    interface Icommmunication
    {
        void Skype();
        void Tel();
        void SMS();
        void Courrier();
    }
}


