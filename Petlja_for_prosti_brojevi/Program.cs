using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_for_prosti_brojevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int raspon_pocetak, raspon_kraj;
            Console.Write("Unesite početni broj raspona: ");
            raspon_pocetak = int.Parse(Console.ReadLine());
            Console.Write("Unesite krajnji broj raspona: ");
            raspon_kraj = int.Parse(Console.ReadLine());
            if (raspon_kraj < raspon_pocetak)
            {
                int pom = raspon_kraj;
                raspon_kraj = raspon_pocetak;
                raspon_pocetak = pom;
            }

            Console.WriteLine($"Prosti brojevi između {raspon_pocetak} i {raspon_kraj} su: ");

            for (int i = raspon_pocetak; i <= raspon_kraj; i++)
            {
                bool prost = true;
                for (int j = 2; j < i; j++)         //ako je broj djeljiv s bilo čime osim s 1 i samim sobom nije prost
                {
                    if (i % j == 0) prost = false;
                }

                if(prost) Console.Write(i + "  ");
            }

            Console.WriteLine();
        }
    }
}
