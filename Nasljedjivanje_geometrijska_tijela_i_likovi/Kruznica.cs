using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje_geometrijska_tijela_i_likovi
{
    class Kruznica
    {
        private double radijus;

        public double Radijus
        {
            get
            {
                if (radijus < 0) return 0.00;
                return radijus;
            }
            set
            {
                radijus = value;
            }
        }

        public double Promjer
        {
            get { return Radijus * 2; }
        }

        public double Opseg
        {
            get
            {
                return Promjer * Math.PI;
            }
        }

        public double Povrsina
        {
            get { return Radijus * Radijus * Math.PI; }
        }
    }
}
