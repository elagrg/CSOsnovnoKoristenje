using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_foreach_brojanje_slova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string recenica = "Majmun je ukrao bananu, popeo se na drvo i pojeo je";
            int brojac = 0;
            foreach (var znak in recenica.ToCharArray())     //foreach (var znak in recenica) - isto
            {
                if (znak == 'n') brojac++;
            }
            Console.WriteLine("Ukupno ima " + brojac + " znakova n.");

            foreach (var znak in recenica.ToCharArray())
            {
                if(znak != ' ') Console.WriteLine(znak);
            }
        }
    }
}
