using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_poslovanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Izračun prihoda i gubitaka:");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();

            decimal trosak, prodaja, ruc;

            Console.Write("Unesite cijenu troškova: ");
            trosak = decimal.Parse(Console.ReadLine());
            Console.Write("Unesite prodajnu cijenu proizvoda: ");
            prodaja = decimal.Parse(Console.ReadLine());
            //prodaja = Convert.ToDecimal(Console.ReadLine());

            if (trosak > prodaja)
            {
                ruc = trosak - prodaja;
                Console.WriteLine("U gubitku smo " + ruc);
            }
            else if (prodaja > trosak)
            {
                ruc = prodaja - trosak;
                Console.WriteLine("Dobit nam je " + ruc);
            }
            else
            {
                Console.WriteLine("Na čistoj nuli smo!");
            }
        }
    }
}
