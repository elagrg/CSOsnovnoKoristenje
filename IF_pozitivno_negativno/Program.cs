using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_pozitivno_negativno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provjera je li broj pozitivan ili negativan");
            Console.WriteLine("===========================================");
            Console.WriteLine();

            Console.Write("Unesite cijeli broj: ");
            int broj = int.Parse(Console.ReadLine());
            //int broj = Convert.ToInt32(Console.ReadLine());

            if (broj >= 0) Console.WriteLine($"{broj} je pozitivan.");
            else Console.WriteLine($"{broj} je negativan.");
        }
    }
}
