using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_foreach_uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============================");
            Console.WriteLine("Primjer jednostavne foreach petlje s poljima:");
            Console.WriteLine();

            string[] automobili = { "Ford", "BMW", "Mercedes", "Opel", "Audi" };
            foreach (string auto in automobili)
            {
                Console.WriteLine(auto);
            }

            Console.WriteLine();

            for(int i = 0; i < automobili.Length; i++)     // Isto kao i foreach petlja
            {
                Console.WriteLine(automobili[i]);
            }

            Console.WriteLine("==================================");
            Console.WriteLine("Primjer foreach petlje za brojanje muškaraca i žena:");
            Console.WriteLine();

            char[] spolovi = { 'm', 'ž', 'm', 'm', 'ž', 'ž', 'm', 'ž', 'ž', 'm' };
            int m = 0, z = 0;
            foreach (char spol in spolovi)
            {
                if (spol == 'm') m++;
                if (spol == 'ž') z++;
            }
            Console.WriteLine("Broj muškaraca je " + m);
            Console.WriteLine("Broj žena je " + z);

            Console.WriteLine();
            Console.WriteLine("==================================");
            Console.WriteLine("Primjer foreach petlje s kolekcijom:");
            Console.WriteLine();

            List<int> brojevi = new List<int>() { 5, -8, 3, 13, 9, 17, 0, 4, 37, -25 };
            int sum = 0;
            foreach (int broj in brojevi)
            {
                sum += broj;
            }
            Console.WriteLine("Suma svih brojeva je " + sum);

            Console.WriteLine();
            Console.WriteLine("==================================");
            Console.WriteLine("Primjer foreach petlje s naredbom continue:");
            Console.WriteLine();

            List<string> imena = new List<string>() { "Ivan", "Petar", "Maja", "Ivona" };

            foreach (string ime in imena)
            {
                if (ime == "Maja") continue;
                Console.WriteLine(ime);
            }

            Console.WriteLine();
            Console.WriteLine("==================================");
            Console.WriteLine("Primjer foreach petlje s naredbom break:");
            Console.WriteLine();

            var prezimena = new List<string>() { "Horvat", "Ivić", "Perić", "Majić", "Knežević" };

            foreach (string prezime in prezimena)
            {
                if (prezime == "Majić") break;
                Console.WriteLine(prezime);
            }

            Console.WriteLine("Izašli smo iz petlje.");
            Console.WriteLine();
        }
    }
}
