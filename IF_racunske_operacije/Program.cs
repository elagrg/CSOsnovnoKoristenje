using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_racunske_operacije
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            char o;

            Console.Write("Unesite prvi broj: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Unesite računsku operaciju: ");
            o = Convert.ToChar(Console.ReadLine());
            Console.Write("Unesite drugi broj: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (o == '+') Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            else if (o == '-') Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            else if (o == '*') Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            else if (o == '/') Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            else if (o == '%') Console.WriteLine("{0} % {1} = {2}", a, b, a % b);
            else Console.WriteLine("Nepoznata operacija, pa se ne može izvršiti");
        }
    }
}
