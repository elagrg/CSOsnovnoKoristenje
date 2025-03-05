using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_for_ponavljanje_brojeva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite broj redaka: ");
            int redovi = int.Parse(Console.ReadLine());

            for (int i = 1; i <= redovi; i++) 
            {
                for (int j = 1; j <= i; j++) 
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
