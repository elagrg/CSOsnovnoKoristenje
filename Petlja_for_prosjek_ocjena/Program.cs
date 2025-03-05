using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_for_prosjek_ocjena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite broj predmeta: ");
            int brojPredmeta = int.Parse(Console.ReadLine());

            bool nedovoljan = false;
            int suma = 0, ocjena;

            for (int i = 0; i < brojPredmeta; i++)
            {
                Console.Write("Unesite ocjenu za {0}. predmet: ", i + 1);
                ocjena = int.Parse(Console.ReadLine());
                if (ocjena < 1 || ocjena > 5)
                {
                    Console.WriteLine("Neispravna ocjena, pokušajte ponovo!");
                    i--;
                }
                else
                {
                    if (ocjena == 1) nedovoljan = true;
                    suma += ocjena;
                }
            }
            
            if (nedovoljan) Console.WriteLine("Uspjeh je nedovoljan!");
            else
            {
                Console.WriteLine("Prosjek za {0} predmeta je {1}", brojPredmeta, Math.Round(((double)suma/brojPredmeta),2));
            }
        }
    }
}
