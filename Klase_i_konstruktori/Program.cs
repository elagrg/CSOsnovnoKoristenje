using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_i_konstruktori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broj = 0;
            int drugiBroj = broj;  //npr. int je vrijednosni tip, kopira se vrijednost; promjena jedne varijable ne utječe na drugu

            Osoba os = new Osoba();

            Osoba osBezInstance = new Osoba();
            osBezInstance = null;
            //Console.WriteLine(osBezInstance.Ime);

            Osoba os2 = new Osoba("Marko");
            Osoba os3 = new Osoba("Tesla", true);
            Osoba os4 = new Osoba("Josip", "Jelačić");

            Console.WriteLine(os.ImePrezime());
            Console.WriteLine(os2.ImePrezime());
            Console.WriteLine(os3.ImePrezime());
            Console.WriteLine(os4.ImePrezime());

            //klase su referentni tip, prenose referencu na isti objekt:
            Osoba osn = os4;                       //osn ne stvara novi objekt nego pokazuje na isti objekt na koji pokazuje os4
            Console.WriteLine(os4.ImePrezime());
            Console.WriteLine(osn.ImePrezime());

            os4.Ime = "Ban Josip";
            Console.WriteLine(os4.ImePrezime());
            Console.WriteLine(osn.ImePrezime());

            //mijenjanje bilo koje reference mijenja originalni objekt
            osn.Prezime = "";
            Console.WriteLine(os4.ImePrezime());      // Ban Josip      
            Console.WriteLine(osn.ImePrezime());      // Ban Josip
        }
    }
}
