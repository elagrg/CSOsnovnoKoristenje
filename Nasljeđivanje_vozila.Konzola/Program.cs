using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nasljeđivanje_vozila.Model;        //dodano!

namespace Nasljeđivanje_vozila.Konzola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vozilo> vozila = new List<Vozilo>();
            List<Automobil> automobili = new List<Automobil>();
            Automobili auti = new Automobili();

            while (true)
            {
                Console.Write("Želite li unos auta ili broda? (b=brod, a=auto)");
                string unos = Console.ReadLine();
                unos = unos.ToLower();
                switch (unos)
                {
                    case "a":
                        Automobil auto = UcitajAutomobil();
                        vozila.Add(auto);
                        automobili.Add(auto);
                        auti.Add(auto);
                        break;
                    case "b":
                        Brod brod = UcitajBrod();
                        vozila.Add(brod);
                        break;
                    default:
                        Console.WriteLine("Nepoznati odabir!");
                        continue;
                }

                Console.WriteLine();
                Console.Write("Želite li unos još vozila? (d=da, n=ne)");
                if (Console.ReadLine().ToLower() == "n") break;
            }

            Console.WriteLine("U kolekciji vozila: ");
            foreach (var v in vozila)
            {
                Console.WriteLine($"{v.Naziv}, {v.Boja} boje i snage {v.Ks} KS");
            }
            Console.WriteLine();

            Console.WriteLine("U kolekciji automobili: ");
            foreach(var a in automobili) Console.WriteLine(a);
            Console.WriteLine();

            Console.WriteLine("U kolekciji auti: ");
            foreach(var a in auti) Console.WriteLine(a);
        }

        static Automobil UcitajAutomobil()
        {
            Automobil auto = new Automobil();
            Console.Write("Unesite naziv automobila: ");
            auto.Naziv = Console.ReadLine();
            Console.Write("Unesite boju automobila: ");
            auto.Boja = Console.ReadLine();
            Console.Write("Unesite snagu u KS: ");
            auto.Ks = int.Parse(Console.ReadLine());
            Console.Write("Unesite zapremninu/volumen motora: ");
            auto.Ccm = decimal.Parse(Console.ReadLine());

            return auto;
        }

        static Brod UcitajBrod() 
        {
            Brod brod = new Brod();
            Console.Write("Unesite naziv broda: ");
            brod.Naziv = Console.ReadLine();
            Console.Write("Unesite boju broda: ");
            brod.Boja = Console.ReadLine();
            Console.Write("Unesite snagu broda: ");
            brod.Ks = int.Parse(Console.ReadLine());
            Console.Write("Unesite istisninu u kubičnim metrima: ");
            brod.Istisnina = decimal.Parse(Console.ReadLine());

            return brod;
        }
    }
}
