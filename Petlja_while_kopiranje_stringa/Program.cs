using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_while_kopiranje_stringa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kopiranje jednog stringa u drugi, znak po znak...

            string recenica;
            int i, duzina;
            Console.Write("Unesite recenicu: ");
            recenica = Console.ReadLine();

            duzina = recenica.Length;
            char[] recenica2 = new char[duzina];

            i = 0;
            while (i < duzina)
            {
                recenica2[i] = recenica[i];
                i++;
            }

            Console.WriteLine("Prva rečenica: " + recenica);
            Console.WriteLine("Druga rečenica: " + string.Join("", recenica2));
            Console.WriteLine("Broj kopiranih znakova je " + i);
        }
    }
}
