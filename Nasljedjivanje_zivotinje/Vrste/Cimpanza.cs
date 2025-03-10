using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje_zivotinje.Vrste
{
    class Cimpanza : Zivotinja
    {
        public Cimpanza(string naziv, int godine, string spol) : base(naziv, godine, spol)
        {
        }

        public override string KakoSeGlasa()
        {
            return "UuuuuuAaaaa";
        }
    }
}
