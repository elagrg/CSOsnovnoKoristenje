using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_foreach_usporedba_polja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] zivotinje = { "Pas", "Mačka", "Zec", "Hrčak", "Kornjača" };

            Console.WriteLine("Originalni redoslijed:");
            foreach (var zivotinja in zivotinje)
            {
                Console.WriteLine(zivotinja);
            }
            Console.WriteLine();

            Console.WriteLine("Obrnuti redoslijed:");
            //for (int i = zivotinje.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(zivotinje[i]);
            //}
            //Console.WriteLine();
            foreach(var z in zivotinje.Reverse()) Console.WriteLine(z);     
        }
    }
}
