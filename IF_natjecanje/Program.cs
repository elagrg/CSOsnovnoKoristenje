using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_natjecanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hogwards škola: ");
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            double programiranje, fizika, kemija, ukupno;
            double postotak;
            string ime, prezime, rezultat;

            Console.Write("Unesite ime učenika: ");
            ime = Console.ReadLine();
            Console.Write("Unesite prezime učenika: ");
            prezime = Console.ReadLine();

            Console.Write("Unesite ostvarene bodove iz programiranja (0-100): ");
            programiranje = double.Parse(Console.ReadLine());
            Console.Write("Unesite ostvarene bodove iz fizike (0-100): ");
            fizika = double.Parse(Console.ReadLine());
            Console.Write("Unesite ostvarene bodove iz kemije (0-100): ");
            kemija = double.Parse(Console.ReadLine());

            ukupno = programiranje + fizika + kemija;
            postotak = ukupno / 3;

            if (postotak >= 60)
            {
                rezultat = "Slytherin";
            }
            else if (postotak >= 48)
            {
                rezultat = "Ravenclaw";
            }
            else if (postotak >= 36)
            {
                rezultat = "Hufflepuff";
            }
            else
            {
                rezultat = "Gryffindor";
            }

            Console.WriteLine();
            Console.WriteLine("Ime i prezime učenika: {0} {1}", ime, prezime);
            Console.WriteLine("Ukupno ima {0} bodova, odnosno {1} %", ukupno, postotak);
            Console.WriteLine("Dodjeljen je kući " + rezultat);
        }
    }
}
