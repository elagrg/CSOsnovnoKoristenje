using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Markup;

namespace Nasljeđivanje_vozila.Model
{
    public class Vozilo        //mora biti public da bi se moglo koristiti u drugom projektu
    {
        private string naziv;
        private string boja;
        private int ks;

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        public string Boja
        {
            get { return boja; }
            set { boja = value; }
        }

        public int Ks
        {
            get { return ks; }
            set { ks = value; }
        }

        public decimal KW 
        {
            get { return ks * (decimal)0.736; }
            set { ks = (int)((decimal)value / (decimal)0.736); }
        }

        public Vozilo() { }
        public Vozilo(int ks) 
        { 
            Ks = ks;
        }
    }
}
