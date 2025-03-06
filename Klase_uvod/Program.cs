using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_uvod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primjer jednostavne klase i instanciranje objekata:");
            Console.WriteLine("======================================================");
            Console.WriteLine();

            Osoba o1 = new Osoba();
            o1.Ime = "Nikola";
            o1.Prezime = "Tesla";
            o1.Starost = 32;

            Osoba o2 = new Osoba();
            o2.Ime = "Albert";
            o2.Prezime = "Einstein";
            o2.Starost = 44;

            Osoba o3 = new Osoba();

            Console.WriteLine("{0} {1}", o1.Ime, o1.Prezime);
            Console.WriteLine(o2.ImePrezime());

            Console.WriteLine();
            Console.WriteLine("Broj osoba je " + Osoba.BrojOsoba);
        }
    }


    class Osoba
    {
        public static int BrojOsoba = 0;

        public string Ime;
        public string Prezime;
        public int Starost;

        public Osoba()
        {
            BrojOsoba++;
        }

        public string ImePrezime()
        {
            return Ime + " " + Prezime;
        }

    }
}
