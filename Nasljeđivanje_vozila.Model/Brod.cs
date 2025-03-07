using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljeđivanje_vozila.Model
{
    public class Brod:Vozilo
    {
        private decimal istisnina;
        public decimal Istisnina
        {
            get { return istisnina; }
            set { istisnina = value; }
        }

        public Brod() { }
        public Brod(int ks) : base(ks) 
        {
        }

        public Brod(decimal istisnina, int ks) : base(ks)
        {
            Istisnina = istisnina;
        }
    }
}
