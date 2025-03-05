using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polja_uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] brojevi = new int[5];         //polje od 5 brojeva
            int[] brojevi2 = new int[] { 1, 3, 5, 7, 9 };      //isto dimenzija 5
            int[] brojevi3 = { 1, 2, 3, 4, 5, 6, 7 };     //nije potrebno new int[7]
            //ukoliko ne navedemo vrijednosti, C# će automatski postaviti nule

            //ukoliko mijenjamo definiranu varijablu polja onda moramo koristiti new operator
            brojevi = new int[6];
            //brojevi = { 2, 3, 4, 5, 6, 7, 8, 9 };    neće raditi

            brojevi = new int[5];      //veličina se može promijeniti tek izradom novog polja
            brojevi[0] = 23;
            brojevi[1] = 46 + 87;
            brojevi[2] = brojevi[0];
            brojevi[4] = 100;    //zadnji element
            //brojevi[5] = 200;    neće raditi   *u C++ moguće(ako već taj dio memorije nije rezerviran)

            string[] gradovi = { "Zagreb", "Split", "Rijeka", "Osijek" };
            Console.WriteLine(gradovi[1]);

            Console.WriteLine(gradovi[2]);
            gradovi[2] = "Zadar";
            Console.WriteLine(gradovi[2]);

            Console.WriteLine("Broj elemenata je "+gradovi.Length);

            //višedimenzionalna polja:
            int[,] matrica = new int[8, 8];
            matrica[0, 0] = 3;
            matrica[3, 2] = matrica[0, 0];
            Console.WriteLine(matrica[3, 2]);
            Console.WriteLine(matrica.GetLength(0));    //broj redaka
            Console.WriteLine(matrica.GetLength(1));    //broj stupaca
            Console.WriteLine(matrica.GetLength(0) + " " + matrica.GetLength(1));
            Console.WriteLine(matrica.Length);          //ukupan broj elemenata
;        }
    }
}
