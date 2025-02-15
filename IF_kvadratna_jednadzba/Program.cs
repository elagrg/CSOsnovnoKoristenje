using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_kvadratna_jednadzba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Računanje rješenja kvadratne jednadžbe (x1 i x2):");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();

            double a, b, c, d, x1, x2;

            Console.Write("Unesite a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Unesite b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Unesite c: ");
            c = double.Parse(Console.ReadLine());

            d = b * b - 4 * a * c;

            if (d == 0)
            {
                Console.WriteLine("Dvostruko rješenje, x1 i x2 su jednaki: ");
                x1 = -b / (2 * a);
                //x2 = x1;
                Console.WriteLine("x1=x2="+x1);
            }
            else if (d > 0)
            {
                d = Math.Sqrt(d);
                x1 = (-b + d) / (2 * a);
                x2 = (-b - d) / (2 * a);
                Console.WriteLine("x1=" + x1);
                Console.WriteLine("x2=" + x2);
            }
            else   //d<0
            {
                Console.WriteLine("Jednadžba nema realnih rješenja!");
            }
        }
    }
}
