using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje_zivotinje
{
    public abstract class Zivotinja
    {
        private string naziv;
        private int godine;
        private string spol;

        public Zivotinja(string naziv, int godine, string spol)
        {
            this.Naziv = naziv;
            this.Godine = godine;
            this.Spol = spol;
        }

        private string Naziv
        {
            set
            {
                if(string.IsNullOrWhiteSpace(value) || value == string.Empty)
                {
                    throw new ArgumentException("Neispravan unos!");
                }
                naziv = value;
            }
        }

        private int Godine
        {
            set
            {
                if (value < 0) throw new ArgumentException("Neispravan unos!");
                godine = value;
            }
        }

        private string Spol
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value == string.Empty)
                {
                    throw new ArgumentException("Neispravan unos!");
                }
                spol = value;
            }
        }

        public abstract string KakoSeGlasa();

        public override string ToString()
        {
            return string.Format("{0}{1}{2} {3} {4}{1}{5}",
                this.GetType().Name,
                Environment.NewLine,
                this.naziv,
                this.godine,
                this.spol,
                this.KakoSeGlasa());
        }
    }
}
