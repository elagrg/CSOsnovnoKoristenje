using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje_geometrijska_tijela_i_likovi
{
    class Kugla:Kruznica
    {
        public double Oplosje
        {
            get
            {
                return 4 * base.Povrsina;
            }
        }

        public double Volumen
        {
            get { return 4 * Radijus * base.Povrsina / 3; }
        }
    }
}
