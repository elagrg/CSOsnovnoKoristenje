using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje_zivotinje
{
    class Program
    {
        static void Main(string[] args)
        {
            var zivotinja = DohvatiZivotinje();
            Console.WriteLine(string.Join(Environment.NewLine, zivotinja));
        }

        private static List<Zivotinja> DohvatiZivotinje()
        {
            var zivotinje = new List<Zivotinja>();

            do
            {
                Console.Write("Unesite vrstu životinje (za kraj unosa unesite \"kraj\": ");
                string vrsta = Console.ReadLine();
                if (vrsta == "kraj") break;

                Console.Write("Unesite naziv životinje: ");
                string naziv = Console.ReadLine();
                Console.Write("Unesite godine životinje: ");
                int godine = int.Parse(Console.ReadLine());
                Console.Write("Unesite spol životinje: ");
                string spol = Console.ReadLine();

                try
                {
                    var zivotinja = VrsteZivotinja.PronadjiZivotinju(vrsta.ToLower(),
                        naziv, godine, spol);
                    zivotinje.Add(zivotinja);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            } while (true);

            return zivotinje;
        }
    }
}
