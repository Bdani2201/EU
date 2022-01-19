using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eu
{
    class Unioallamai
    {
        public Unioallamai(string sor)
        {
            string[] sorelemek = sor.Split(';');
            this.Orszag = sorelemek[0];
            this.Datum = Convert.ToDateTime(sorelemek[1]);

        }

        public string Orszag { get; set; }
        public DateTime Datum { get; set; }
    }
    class Program
    {
        public static List<Unioallamai> adatok = new List<Unioallamai>();
        static void Main(string[] args)
        {
            StreamReader olvas = new StreamReader("EUcsatlakozas.txt", Encoding.UTF8);
            
            while (!olvas.EndOfStream)
            {
                adatok.Add(new Unioallamai(olvas.ReadLine()));
            }
            int i, j;
            int adatokszama = adatok.Count;
            
            //3.
            Console.WriteLine("3. feladat: EU tagállamainak száma: {0} db",adatokszama);
            
            //4.	
            int db = 0;
            for (i = 0; i < adatokszama; i++)
                if (adatok[i].Datum.Year == 2007)
                    db++;
            Console.WriteLine("4. feladat: 2007-ben {0} ország csatlakozott.", db);

            
            Console.ReadKey();


        }
    }
}
