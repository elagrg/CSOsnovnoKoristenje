using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_izracun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program koji je vođen izbornikom kako bismo izvršili jednostavan izračun dva broja

            int prvi_broj, drugi_broj, broj_operacije;
            Console.Write("Unesite prvi broj: ");
            prvi_broj = int.Parse(Console.ReadLine());
            Console.Write("Unesite drugi broj: ");
            drugi_broj = int.Parse(Console.ReadLine());

            Console.WriteLine("Popis dostupnih opcija: ");
            Console.WriteLine("1 - Zbrajanje");
            Console.WriteLine("2 - Oduzimanje");
            Console.WriteLine("3 - Množenje");
            Console.WriteLine("4 - Dijeljenje");
            Console.WriteLine("5 - Izlaz iz programa");
            broj_operacije = int.Parse(Console.ReadLine());

            switch (broj_operacije)
            {
                case 1:
                    Console.WriteLine($"{prvi_broj} + {drugi_broj} = {prvi_broj + drugi_broj}");
                    break;
                case 2:
                    Console.WriteLine($"{prvi_broj} - {drugi_broj} = {prvi_broj - drugi_broj}");
                    break;
                case 3:
                    Console.WriteLine($"{prvi_broj} * {drugi_broj} = {prvi_broj * drugi_broj}");
                    break;
                case 4:
                    if(drugi_broj == 0) Console.WriteLine("Dijeljenje s nulom nije moguće!");
                    else
                    {
                        Console.WriteLine($"{prvi_broj} / {drugi_broj} = {(float)prvi_broj / drugi_broj}");
                    }
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Odabir opcije nije ništa od ponuđenog!");
                    break;
            }
        }
    }
}
