using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_while_unos_ocjena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unos ocjena, ocjene moraju biti u rasponu od 1 do 5: ");
            Console.WriteLine();

            int ocjena = 0;
            while(ocjena < 1 || ocjena > 5)      //ovo čak bolje napraviti s do while,ne treba inicijalizacija int varijable
            {
                Console.Write("Unesite ocjenu: ");
                ocjena = int.Parse(Console.ReadLine());
                if(ocjena < 1 || ocjena > 5)
                {
                    Console.WriteLine("Neispravan unos, pokušajte ponovno!");
                }
            }

            Console.WriteLine("Ispravan unos, unijeli ste ocjenu " + ocjena);

        }
    }
}
