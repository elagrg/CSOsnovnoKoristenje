using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("==================================");
            Console.WriteLine("Primjer jednostavnog if grananja: ");
            Console.WriteLine();

            string vrijeme = "Sunčano";
            if (vrijeme == "Sunčano")
            {
                Console.WriteLine("Danas je lijep i sunčan dan.");
            }

            if (vrijeme == "sunčano") Console.WriteLine("Idemo na plažu. :)");

            Console.WriteLine();
            Console.WriteLine("==================================");
            Console.WriteLine("Primjer if-else grananja: ");
            Console.WriteLine();

            vrijeme = "Kišno";
            if (vrijeme == "Sunčano")
            {
                Console.WriteLine("Danas je lijep i sunčan dan.");
            }
            else
            {
                Console.WriteLine("Kiša je padala.");
            }

            Console.WriteLine();
            Console.WriteLine("==================================");
            Console.WriteLine("Primjer ugnježđivanje if-else: ");
            Console.WriteLine();

            string vremenska_prognoza = "Oblačno";
            bool pada_kisa = false;
            if (vremenska_prognoza == "Oblačno")
            {
                string tekst = "vrijeme je oblačno";
                if (pada_kisa)
                {
                    tekst += ", nemojte zaboraviti kišobran";
                }
                else
                {
                    tekst += ", ali ne pada kiša :)";
                }

                Console.WriteLine(tekst);
            }
            else
            {
                Console.WriteLine("Sunčano :D");
            }

            Console.WriteLine();
            Console.WriteLine("==================================");
            Console.WriteLine("Primjer if-else if: ");
            Console.WriteLine();

            int x = 10;
            int y = 4;

            if (x > y)
            {
                Console.WriteLine(x + " je veći od " + y);
            }
            else if (x < y)
            {
                Console.WriteLine(x + " je manji od " + y);
            }
            else
            {
                Console.WriteLine(x + " je jednak " + y);
            }

            Console.WriteLine();
            Console.WriteLine("==================================");
            Console.WriteLine("Primjer ternarnog if: ");
            Console.WriteLine();

            string veci_od = (x > 5) ? x + " je veći od 5" : x + " je manji od 5";
            bool manji_od = (y < 5) ? true : false;

            Console.WriteLine(veci_od);
            Console.WriteLine(manji_od);
        }
    }
}
