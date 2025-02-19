using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_samoglasnici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Provjera je li uneseno slovo abecede samoglasnik ili suglasnik:

            char slovo;
            Console.Write("Unesite jedno slovo abecede: ");
            slovo = Convert.ToChar(Console.ReadLine().ToLower());

            switch (slovo)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Uneseno slovo je samoglasnik.");
                    break;
                default:
                    Console.WriteLine("Uneseno slovo je suglasnik.");
                    break;
            }
        }
    }
}
