using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_while_brojanje_znakova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //program za brojanje ukupnog broja slova, znamenki i posebnih znakova u unesenoj rečenici
            string recenica = "";
            int slova = 0, znamenke = 0, spec_znakovi = 0, i, duzina;

            Console.Write("Unesite rečenicu: ");
            recenica = Console.ReadLine();
            duzina = recenica.Length;
            i = 0;

            while (i < duzina)
            {
                if ((recenica[i]>='a' && recenica[i]<='z') || (recenica[i] >= 'A' && recenica[i] <= 'Z'))
                {
                    slova++;
                }
                else if (recenica[i] >= '0' && recenica[i] <= '9')
                {
                    znamenke++;
                }
                else spec_znakovi++;

                i++;
            }

            Console.WriteLine("Broj slova u rečenici: " + slova);
            Console.WriteLine("Broj znamenki u rečenici: " + znamenke);
            Console.WriteLine("Broj specijalnih znakova u rečenici: " + spec_znakovi);
        }
    }
}
