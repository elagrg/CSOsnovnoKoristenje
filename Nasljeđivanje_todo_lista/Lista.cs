using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljeđivanje_todo_lista
{
    class Lista : List<StavkaListe>
    {
        public Lista()
        {
        }

        public void Dodaj(string naslov, string opis) 
        {
            int broj_zadatka = this.Count;
            this.Add(new StavkaListe(broj_zadatka+1, naslov, opis, false));
        }

        public void NovaStavkaListe() 
        { 
            Console.Write("Unesite naslov zadatka: ");
            string naslov = Console.ReadLine();

            Console.Write("Unesite opis zadatka: ");
            string opis = Console.ReadLine();

            Dodaj(naslov, opis);
        }

        public void IspisListe() 
        {
            Console.WriteLine();
            Console.WriteLine("Broj       |          Naslov            |               Opis              |          Gotovo");
            Console.WriteLine("=============================================================================================");
            foreach(var zadatak in this)
            {
                Console.Write($"{zadatak.Broj}          |          {zadatak.Naslov}            |     {zadatak.Opis}     |");
                if (zadatak.Gotovo) Console.Write("          Gotov");
                else Console.Write("          U tijeku");
                Console.WriteLine();
                Console.WriteLine("---------------------------------------------------------------------------------------------");
            }
            Console.WriteLine("Ukupno " + this.Count + " zadataka u listi");
        }
    }
}
