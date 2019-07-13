using System;

namespace Using
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Ressource r = new Ressource())
            {
                //throw new Exception();
                Console.WriteLine("Hello World!");
            }
            Ressource r2  = null;
            try
            {
                r2 = new Ressource();
                Console.WriteLine("Hello World!");
                
            }
            finally {
                r2.Dispose();
            }

            
   
        }
    }
    class Ressource : System.IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Liberation des ressources allouées");
        }
    }
}

