using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Primjer provjere dana u tjednu po njegovom broju:");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();

            int dan_u_tjednu = 3;
            switch(dan_u_tjednu)
            {
                case 1:
                    Console.WriteLine("Ponedjeljak");
                    break;
                case 2:
                    Console.WriteLine("Utorak");
                    break;
                case 3:
                    Console.WriteLine("Srijeda");
                    break;
                case 4:
                    Console.WriteLine("Četvrtak");
                    break;
                case 5:
                    Console.WriteLine("Petak");
                    break;
                case 6:
                    Console.WriteLine("Subota");
                    break;
                case 7:
                    Console.WriteLine("Nedjelja");
                    break;
                default:
                    Console.WriteLine("Nepoznati dan!");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Primjer provjere dana u tjednu po njegovom broju (propadanje):");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();

            dan_u_tjednu = 1;
            switch (dan_u_tjednu)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Srijeda");
                    break;
                case 4:
                    Console.WriteLine("Četvrtak");
                    break;
                case 5:
                    Console.WriteLine("Petak");
                    break;
                case 6:
                    Console.WriteLine("Subota");
                    break;
                case 7:
                    Console.WriteLine("Nedjelja");
                    break;
                default:
                    Console.WriteLine("Nepoznati dan!");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Primjer teksta:");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();

            Console.Write("Unesite dan u tjednu (riječima): ");
            string dan = Console.ReadLine();
            switch (dan)
            {
                case "ponedjeljak":                     //case sensitive
                    Console.WriteLine("Vikend je gotov...");
                    break;
                case "utorak":
                    Console.WriteLine("Tek smo ušli u radni tjedan :(");
                    break;
                case "srijeda":
                    Console.WriteLine("Na pola puta smo");
                    break;
                case "četvrtak":
                    Console.WriteLine("Još malo vikend...");
                    break;
                case "petak":
                    Console.WriteLine("Sutra napokon vikend :D");
                    break;
                default:
                    Console.WriteLine("Juhu, neradni dan :)");
                    break;
            }

            //npr. switch kao if:
            if (dan == "ponedjeljak" || dan == "utorak")
            {
                //...
            }

            //obrnuto npr. if u switch: 
            int i = 20;
            if (i > 30 && i < 60) { }

            switch (i > 30 && i < 60)
            {
                case true:
                    Console.WriteLine("U rasponu");
                    break;
                case false:
                    Console.WriteLine("Nije u rasponu");
                    break;
            }
        }
    }
}
