using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_while_uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("Primjer jednostavne while petlje:");
            Console.WriteLine();

            int x = 1;
            while (x < 10)
            {
                Console.WriteLine("Broj x je: " + x);
                x++;
            }
            Console.WriteLine(x);

            Console.WriteLine();

            int y = 10;
            while (y > 0)
            {
                Console.WriteLine("Broj y je: " + y);
                y--;
            }
            Console.WriteLine(y);

            Console.WriteLine();
        }
    }
}
