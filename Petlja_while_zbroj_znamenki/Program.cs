using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_while_zbroj_znamenki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zbroj znamenki unesenog cijelog broja

            int broj, suma = 0;
            
            Console.Write("Unesite cijeli broj: ");
            broj = int.Parse(Console.ReadLine());

            while (broj > 0)
            {
                suma = suma + broj % 10;
                broj = broj / 10;
            }

            Console.WriteLine("Suma znamenki je " + suma);
        }
    }
}
