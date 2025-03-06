using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_rekurzija_i_permutacije
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rekurzija: generiranje svih mogućih permutacija niza");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();

            Console.Write("Unesite broj elemenata koji će se pohraniti u polje: ");
            int broj_elemenata = int.Parse(Console.ReadLine());
            Console.WriteLine($"Unesite {broj_elemenata} elemenata u polje: ");
            int[] brojevi = new int[broj_elemenata];
            for (int i = 0; i < broj_elemenata; i++)
            {
                Console.Write($"Element - {i + 1} :");
                brojevi[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Permutacije s kombinacijom {broj_elemenata} su: ");

            KlasaPermutacije test = new KlasaPermutacije();
            test.IspisiPermutaciju(brojevi, 0, broj_elemenata - 1);
        }
    }
}
