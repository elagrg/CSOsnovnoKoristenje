using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_upis_na_studij
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fizika, matematika, kemija;

            Console.WriteLine("Kriterij prihvatljivosti: ");
            Console.WriteLine("Bodovi iz matematike >=65");
            Console.WriteLine("i bodovi iz fizike >=55");
            Console.WriteLine("i bodovi iz kemije >=50");
            Console.WriteLine("i ukupno iz sva tri predmeta >=180");
            Console.WriteLine("ili ukupno iz matematike i fizike >=140");
            Console.WriteLine("---------------------------------------------");

            Console.Write("Unesite bodove iz fizike: ");
            fizika = int.Parse(Console.ReadLine());
            Console.Write("Unesite bodove iz matematike: ");
            matematika = int.Parse(Console.ReadLine());
            Console.Write("Unesite bodove iz kemije: ");
            kemija = int.Parse(Console.ReadLine());

            Console.WriteLine("Ukupno bodova (matematika+kemija+fizika): " + (matematika + kemija + fizika));
            Console.WriteLine("Bodovi matematika i fizika: " + (matematika + fizika));

            string nista = "Nema uvjeta za upis...";
            if (matematika >= 65)
            {
                if (fizika >= 55)
                {
                    if (kemija >= 50)
                    {
                        if ((matematika + fizika + kemija) >= 180 || (matematika + fizika) >= 140)
                        {
                            Console.WriteLine("Čestitke, možete se upisati ;)");
                        }
                        else Console.WriteLine(nista);
                    }
                    else Console.WriteLine(nista);
                }
                else Console.WriteLine(nista);
            }
            else Console.WriteLine(nista);
        }
    }
}
