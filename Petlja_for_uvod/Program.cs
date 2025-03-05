using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_for_uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 12; i++)
            {
                Console.WriteLine("{0}. mjesec u godini", i + 1);
            }

            Console.WriteLine();

            for (int i = 12; i > 0; i--)
            {
                Console.WriteLine("{0}. mjesec u godini", i);
            }

            Console.WriteLine();

            //parni brojevi do 20, i kao korak prije sljedeće iteracije:
            for (int i = 2; i < 20; i += 2
                )     //isto bi bilo: for (int i = 2; i < 20; i++,i++)  
            {
                Console.Write(i + "   ");
            }

            Console.WriteLine();
            Console.WriteLine();

            int j = 0;
            while (j < 10)
            {
                //blok koda
                //j++;
            }

            for (; j < 10;)      //ekvivalent gornje while petlje
            {
                //blok koda
            }

            //nema razlike u funkcionalnosti petlji, samo je razlika što će biti čitljivije
        }
    }
}
