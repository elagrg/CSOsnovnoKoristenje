using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StaticnaKlasa stat = new StaticnaKlasa(); // Error: staticna klasa ne moze biti instancirana

            Console.WriteLine(StaticnaKlasa.Zbroj(11, 4));
            Console.WriteLine(StaticnaKlasa.Kub(3.14));

            //Math m = new Math();  // Error: Math je staticna klasa, ne moze se instancirat

            Console.WriteLine();
            Console.WriteLine("=========================================");
            Console.WriteLine("primjer kada je klasa obična, no ima i statične metode:");
            Console.WriteLine();

            Console.Write("Unesite broj: ");
            int broj = int.Parse(Console.ReadLine());

            if (StaticnaMetoda.Prost(broj))
            {
                Console.WriteLine("Broj je prost :)");
            }
            else
            {
                Console.WriteLine("Broj nije prost :(");
            }

            StaticnaMetoda sm = new StaticnaMetoda();
            if (sm.Savrsen(broj))
            {
                Console.WriteLine("Broj je savršen :)");
            }
            else Console.WriteLine("Broj nije savršen :(");

            //sm.Prost(broj); // Error: metoda Prost je staticna, ne moze se pozvati preko instance
        }
    }
}
