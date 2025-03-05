using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_for_string_s_razmacima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sortiranje slova u stringu
            Console.Write("Unesite rečenicu: ");
            string recenica = Console.ReadLine();
            char[] znakovi = recenica.ToCharArray();

            for (int i = 1; i < znakovi.Length; i++)
                for (int j = 0; j < znakovi.Length - 1; j++)
                    if (znakovi[j] > znakovi[j + 1])
                    {
                        char znak = znakovi[j];
                        znakovi[j] = znakovi[j + 1];
                        znakovi[j + 1] = znak;
                    }

            //Array.Sort(znakovi);
            for (int i = 0; i < znakovi.Length; i++)
            {
                Console.Write(znakovi[i] + " ");
            }
        }
    }
}
