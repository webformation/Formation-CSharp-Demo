using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace ExempleEvenement
{
    class Program
    {
        static void Main(string[] args)
        {
            Client c = new Client();
            Console.WriteLine(c.connexion); // vrai car la connexion a été ouverte dans le constructeur de Client
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(c.connexion); // false car le handler a été activé
            Console.ReadKey();
        }
    }
    class BaseDonnee
    {
        Timer t ;
        public BaseDonnee()
        {
            // connexion à la base de donnée

            //  mise en place d'un timer pour appeler verifConnexion() : 
            // vérification de la connexion, qui va envoyer l'évenement
            t = new Timer();
            t.Interval = 10;
            t.Elapsed += new ElapsedEventHandler(verifConnexion);
            t.Enabled = true;
            t.Start();
        }
        public event EventHandler PerteConnexion;

        public void verifConnexion(Object o, EventArgs e)
        {
            // lors de la vérification de la connexion, 
            // on s'aperçoit que la connexion est perdue
            PerteConnexion(this, new EventArgs());
        }
    }
    class Client
    {
        public BaseDonnee bdd;
        public bool connexion = false;
        public Client()
        {
            bdd = new BaseDonnee();
            connexion = true;         
            bdd.PerteConnexion += new EventHandler(TraitePerteConnexion);
        }
        public void TraitePerteConnexion(Object o, EventArgs e)
        {
            // cette méthode est appelée lorsque la connexion à la base de donnée est perdue
            // grace au mécanisme d'évenement
            connexion = false;
        }
    }
}
