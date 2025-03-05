using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //provjera korisničkog imena i lozinke, kombinacija je abcd i 1234
            string korisnik, lozinka;
            int pokusaja = 0;
            
            do
            {
                Console.Write("Unesite korisničko ime: ");
                korisnik = Console.ReadLine();
                Console.Write("Unesite lozinku: ");
                lozinka = Console.ReadLine();
                if (korisnik != "abcd" || lozinka != "1234") pokusaja++;
            } while ((korisnik != "abcd" || lozinka != "1234") && pokusaja != 3);     //<3

            if(pokusaja == 3) Console.WriteLine("Previše pokušaja prijave, probajte kasnije.");
            else Console.WriteLine("Uspješna prijava :)");
        }
    }
}
