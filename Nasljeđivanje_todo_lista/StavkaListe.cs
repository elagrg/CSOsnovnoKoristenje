using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljeđivanje_todo_lista
{
    class StavkaListe
    {
        //private int broj;
        //public int Broj { get { return broj; } set { broj = value; } }
        public int Broj { get; set; }     // automatski implementirano svojstvo
        public string Naslov { get; set; }
        public string Opis { get; set; }
        public bool Gotovo { get; set; }

        public StavkaListe() { }
        public StavkaListe(string naslov, string opis)
        {
            Naslov = naslov;
            Opis = opis;
        }
        public StavkaListe(int broj, string naslov, string opis, bool gotovo)
        {
            Broj = broj;
            Naslov = naslov;
            Opis = opis;
            Gotovo = gotovo;
        }
    }
}
