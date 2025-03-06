using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_i_svojstva
{
    class Osoba
    {
        private string ime;

        public string Ime
        {
            get
            { 
                return ime;
            }
            set
            { 
                ime = value; 
            }
        }

        private string prezime;

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        private int starost;

        public int Starost
        {
            get { return starost; }
            set 
            { 
                if (value > 0) starost = value;
                else
                {
                    throw new Exception("Starost ne smije biti negativna!");
                }
            }
        }

        private string oib;

        public string OIB
        {
            get { return oib; }
        }

        public string BojaKose { get; set; }

        public int BrojCipela { get; private set; }

        public Osoba(string oib)
        {
            this.oib = oib;

            BrojCipela = 37;
        }

        public void PromijeniBrojCipela(int broj)
        {
            BrojCipela = broj;
        }
    }
}
