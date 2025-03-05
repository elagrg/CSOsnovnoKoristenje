using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_for_piramida_brojeva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite broj redova: ");
            int redovi = int.Parse(Console.ReadLine());

            int razmak, t = 1;
            razmak = redovi + 4 - 1;
            for(int i = 1; i <= redovi; i++)
            {
                for (int k = razmak; k >= 1; k--) Console.Write(" ");

                for (int j = 1; j <= i; j++) Console.Write("{0} ", t++);  //ne uzima u obzir koliko će mjesta zauzimati određene znamenke
                Console.WriteLine();
                razmak--;
            }
        }
    }
}
