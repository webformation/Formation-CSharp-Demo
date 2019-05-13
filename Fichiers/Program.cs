using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fichiers
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime debut;
            TimeSpan fin;
            DirectoryInfo dir = new DirectoryInfo(".");
            debut = DateTime.Now;
            String liste = "";
            String separ = "";
            foreach (FileInfo f in dir.GetFiles("*"))
            {
                liste += separ + f.FullName;
                separ = "\n";
            }
            Console.WriteLine(liste);
            fin = DateTime.Now - debut;
            Console.WriteLine("Temps CPU {0}", fin);
            Console.WriteLine("------------------------------------------------");
            debut = DateTime.Now;
            StringBuilder liste2 = new StringBuilder();
            StringWriter sw = new StringWriter(liste2);
            foreach (FileInfo f in dir.GetFiles("*"))
            {
                sw.WriteLine(f.FullName);
            }
            Console.WriteLine(liste2.ToString());
            fin = DateTime.Now - debut;
            Console.WriteLine("Temps CPU {0}", fin);
            Console.WriteLine("------------------------------------------------");
            StreamWriter stw = File.CreateText("Monfichier.txt");
            stw.WriteLine("Exemple de fichier");
            stw.WriteLine(
               "Ecriture de ints {0} ou de floats {1}", 1, 4.2);
            stw.Close();

            StreamReader sr = File.OpenText("Monfichier.txt");
            String input;
            while ((input = sr.ReadLine()) != null)
            {
                Console.WriteLine(input);
            }
            sr.Close();
            Console.WriteLine(
               "Fin de lecture.");
            sr.Close();
            Console.WriteLine("------------------------------------------------");
            using (FileStream fs = new FileStream("Monfichier.txt", FileMode.Open, FileAccess.Read))
            {
                byte[] tampon = new byte[1024];
                while (fs.Read(tampon, 0, tampon.Length) > 0)
                {
                    foreach (var i in tampon)
                    {
                        if (i == 0) break;
                        Console.WriteLine("{0} : {1}", i, (char)i);
                    }
                }
            }
#if DEBUG
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
#endif
        }
    }
}
