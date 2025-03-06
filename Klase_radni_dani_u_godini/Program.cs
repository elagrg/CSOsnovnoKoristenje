using System;
using System.Collections.Generic;
using System.Globalization;                  //dodano za CultureInfo
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_radni_dani_u_godini
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BrojRadneDane radni_dani = new BrojRadneDane();

            Console.Write("Unesite početni datum: ");
            DateTime poc = DateTime.ParseExact(Console.ReadLine(),
                "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Console.Write("Unesite završni datum: ");
            DateTime kraj = DateTime.ParseExact(Console.ReadLine(),
                "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine("Broj radnih dana u danom periodu je: " +
                radni_dani.PronadjiRadneDane(poc, kraj));
        }
    }
}
