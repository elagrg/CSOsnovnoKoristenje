using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje_geometrijska_tijela_i_likovi
{
    class Program
    {
        static void Main(string[] args)
        {
            var krug = new Kruznica();
            krug.Radijus = 10.25;

            Console.WriteLine("Karakteristike kruga: ");
            Console.WriteLine("Radijus:  " + krug.Radijus);
            Console.WriteLine("Promjer:  " + krug.Promjer);
            Console.WriteLine("Opseg:    " + krug.Opseg);
            Console.WriteLine("Površina: " + krug.Povrsina);
            Console.WriteLine();

            var lopta = new Kugla();
            lopta.Radijus = 10.25;

            Console.WriteLine("Karakteristike lopte: ");
            Console.WriteLine("Radijus:  " + lopta.Radijus);
            Console.WriteLine("Promjer:  " + lopta.Promjer);
            Console.WriteLine("Oplošje:  " + lopta.Oplosje);
            Console.WriteLine("Volumen:  " + lopta.Volumen);
            Console.WriteLine();
        }
    }
}
