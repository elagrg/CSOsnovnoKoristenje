using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_for_beskonacne_petlje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for(int i = 10; i > 0; i++)
            //{
            //    Console.Write(i + ", ");
            //}

            for (int i = 10; i > 0; i++)
            {
                if (i == 100) break;
                Console.Write(i + ", ");
            }
        }
    }
}
