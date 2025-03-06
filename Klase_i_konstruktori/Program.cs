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
            int drugiBroj = broj;

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

            Osoba osn = os4;
            Console.WriteLine(os4.ImePrezime());
            Console.WriteLine(osn.ImePrezime());

            os4.Ime = "Ban Josip";
            Console.WriteLine(os4.ImePrezime());
            Console.WriteLine(osn.ImePrezime());

            osn.Prezime = "";
            Console.WriteLine(os4.ImePrezime());      // Ban Josip
            Console.WriteLine(osn.ImePrezime());      // Ban Josip
        }
    }
}
