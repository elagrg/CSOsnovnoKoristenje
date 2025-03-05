using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_while_prosjek_ocjena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, brojac = 0, ocjena;
            Console.WriteLine("Program za računanje prosjeka ocjena.");
            Console.WriteLine("Ocjene se unose redom, za prekid unosa unesite 0");

            while (true)
            {
                Console.Write("Unesite ocjenu: ");
                ocjena = int.Parse(Console.ReadLine());
                if (ocjena == 0) break;
                if (ocjena < 1 || ocjena > 5)
                {
                    Console.WriteLine("Neispravan unos!");
                    continue;                // preskače ostatak petlje i vraća se na početak
                }
                sum += ocjena;
                brojac++;
            }

            Console.WriteLine("Prosjek ocjena je: " + (float)sum / brojac);
        }
    }
}
