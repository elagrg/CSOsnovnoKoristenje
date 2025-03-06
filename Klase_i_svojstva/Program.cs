using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_i_svojstva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Osoba o = new Osoba("12345678901");
                o.Ime = "Mirko";       //setter
                string ime = o.Ime;    //getter

                //o.OIB = "111111111111";   //read only!

                o.Starost = 14;
                o.Starost = -3;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Racunalo pc = new Racunalo();
            Racunalo pc2 = new Racunalo("AMD", 2000, 128);
        }
    }
}
