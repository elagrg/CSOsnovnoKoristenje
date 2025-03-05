using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_do_while_uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("Primjer jednostavne do while petlje:");
            Console.WriteLine();

            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);

            Console.WriteLine("=======================================");
            Console.WriteLine("Primjer do while petlje kod unosa imena:");
            Console.WriteLine();

            string ime = "";
            do
            {
                Console.Write("Unesite ime: ");         
                ime = Console.ReadLine();

                Console.WriteLine("Dobar dan " + ime);
                Console.WriteLine();
            } while (ime != "kraj");
        }
    }
}
