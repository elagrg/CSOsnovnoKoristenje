using System;
using System.Collections;          //dodano
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcije_uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista_brojeva = new ArrayList();

            lista_brojeva.Add(10);
            lista_brojeva.Add(15);
            lista_brojeva.Add(11.7);
            lista_brojeva.Add(1234567890123);

            Console.WriteLine(lista_brojeva[0]);
            Console.WriteLine(lista_brojeva[2]);

            Console.WriteLine("");
            Console.WriteLine("");

            var lista_razlicitih_tipova = new ArrayList();   //var - podatkovni tip prvog dodijeljivanja vrijednosti
            lista_razlicitih_tipova.Add(10);
            lista_razlicitih_tipova.Add("Automobil");
            lista_razlicitih_tipova.Add(false);
            lista_razlicitih_tipova.Add(null);
            Console.WriteLine(lista_razlicitih_tipova);      //ispisat će tip, System.Collections.ArrayList

            var razliciti_podaci2 = new ArrayList() { "Nikola", "Tesla", "Teslina ulica bb", 89, 4246646887879, 5.21, null, true };
            razliciti_podaci2.Add("novi podatak");

            Console.WriteLine(razliciti_podaci2[1]);
            Console.WriteLine(razliciti_podaci2[3]);
            Console.WriteLine(razliciti_podaci2[4]);
            Console.WriteLine(razliciti_podaci2[razliciti_podaci2.Count - 1]);

            razliciti_podaci2.Remove(null);
            razliciti_podaci2.RemoveAt(1);
            razliciti_podaci2.RemoveRange(2, 3);

            Console.WriteLine("");
            Console.WriteLine("");

            //ovo su bile negeneričke kolekcije, sada su generičke:

            List<int> brojevi = new List<int>();

            brojevi.Add(1);
            brojevi.Add(12);
            brojevi.Add(123);
            //brojevi.Add("2");   ne može!

            Console.WriteLine(brojevi[0]);
            Console.WriteLine(brojevi[2]);

            List<string> tekstovi = new List<string>();
            List<bool> sudovi = new List<bool>();
        }
    }
}
