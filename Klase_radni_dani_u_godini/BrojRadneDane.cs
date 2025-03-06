using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_radni_dani_u_godini
{
    class BrojRadneDane
    {
        public int PronadjiRadneDane(DateTime pocetak, DateTime kraj) 
        {
            int radnih_dana = 0;
            for (DateTime i = pocetak; i <= kraj; i = i.AddDays(1))
            {
                if (JeRadniDan(i)) radnih_dana++;
            }
            return radnih_dana;
        }

        public bool JeRadniDan(DateTime dan)
        {
            if (dan.DayOfWeek == DayOfWeek.Saturday || dan.DayOfWeek == DayOfWeek.Sunday)
            {
                return false;
            }
            DateTime[] praznici = new DateTime[]
            {
                new DateTime(dan.Year, 1, 1),
                new DateTime(dan.Year, 1, 6),
                new DateTime(dan.Year, 5, 1),
                new DateTime(dan.Year, 5, 30),
                new DateTime(dan.Year, 6, 22),
                new DateTime(dan.Year, 8, 5),
                new DateTime(dan.Year, 8, 15),
                new DateTime(dan.Year, 10, 8),
                new DateTime(dan.Year, 11, 1),
                new DateTime(dan.Year, 12, 24),
                new DateTime(dan.Year, 12, 25),
                new DateTime(dan.Year, 12, 26)
            };

            //for (int i = 0; i < praznici.Length; i++)
            //{
            //    if (dan.Month == praznici[i].Month && dan.Day == praznici[i].Day) 
            //        return false;
            //}

            foreach (DateTime praznik in praznici)
            {
                if (dan == praznik) return false;
            }

            //DateTime dan_za_provjeru = new DateTime(1, dan.Month, dan.Day);
            //return !praznici.Contains(dan_za_provjeru);

            return true;
        }
    }
}
