using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_i_svojstva
{
    /// <summary>
    /// Klasa koja predstavlja računalo sa svojstvima i metodama za rad s njime...
    /// </summary>
    class Racunalo
    {
        #region Privatni članovi 
        private string markaProcesora;
        private int kapacitetDiska;
        private int radnaMemorija;
        #endregion

        #region Svojstva 

        /// <summary>
        /// Marka procesora
        /// </summary>
        public string MarkaProcesora
        {
            get { return markaProcesora; }
            set { markaProcesora = value; }
        }
        /// <summary>
        /// Kapacitet diska u GB
        /// </summary>
        public int KapacitetDiska
        {
            get { return kapacitetDiska; }
            set { kapacitetDiska = value; }
        }
        /// <summary>
        /// Kapacitet u GB
        /// </summary>
        public int RadnaMemorija
        {
            get { return radnaMemorija; }
        }

        #endregion

        #region Konstruktori 

        public Racunalo() 
        {
            radnaMemorija = 2;
        }

        public Racunalo(int RAM) 
        { 
            radnaMemorija = RAM;
        }

        /// <summary>
        /// Konstruktor klase računalo
        /// </summary>
        /// <param name="procesor">marka procesora</param>
        /// <param name="disk">kapacitet diska u GB</param>
        /// <param name="ram">kapacitet radne memorije u GB</param>
        public Racunalo(string procesor, int disk, int ram) 
        {
            markaProcesora = procesor;
            kapacitetDiska = disk;
            radnaMemorija = ram;
        }

        #endregion

        #region Javne metode
        
        /// <summary>
        /// Povećaj kapacitet radne memorije
        /// </summary>
        /// <param name="dodatak">Dodani kapacitet u GB</param>
        public void DodajMemoriju(int dodatak)
        {
            radnaMemorija += dodatak;
        }

        #endregion
    }
}
