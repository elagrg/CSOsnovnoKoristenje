using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool voznja_je_zabavna = true;
            bool vrijeme_je_kisno = false;

            Console.WriteLine("Primjer ispisa boolean vrijednosti:");
            Console.WriteLine(voznja_je_zabavna);
            Console.WriteLine(vrijeme_je_kisno);

            Console.WriteLine("========================");
            Console.WriteLine();

            int x = 1, y = 3;
            Console.WriteLine("Primjer rezultata boolean izraza s relacijskim operatorima: ");
            Console.WriteLine(x > y);
            Console.WriteLine(x < y);
            Console.WriteLine(x == y);
            Console.WriteLine(x = y);

            Console.WriteLine("========================");
            Console.WriteLine();

            Console.WriteLine("Negacija");
            Console.WriteLine(!true);
            Console.WriteLine(!false);

            Console.WriteLine();
            Console.WriteLine("I operacija");
            Console.WriteLine(true && true);
            Console.WriteLine(true && false);
            Console.WriteLine(false && true);
            Console.WriteLine(false && false);

            Console.WriteLine();
            Console.WriteLine("ILI operacija");
            Console.WriteLine(true || true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || true);
            Console.WriteLine(false || false);

            Console.WriteLine();    
            int c = 5;
            //c = c + 5;
            c += 5;              //kompozitni operator
            Console.WriteLine(c);
        }
    }
}
