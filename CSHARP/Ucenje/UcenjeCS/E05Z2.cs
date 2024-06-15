using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E05Z2
    {
        internal static void Izvedi()
        {
            //Definirajtee dvodimenzionalni niz od 4 elementa koji su decimalni brojevi
            // DZ: korisnik upisuje vrijednosti
            //Program ispisuje unesene brojeve jedno pokraj drugog odvojeno zarezom

            int[,] niz = new int[,] {
            {2,2 },
            {3,3 }
            };


            Console.WriteLine("{0}, {1}, {2}, {3}", niz[0, 0], niz[0, 1], niz[1, 0], niz[1, 1]);
















        }
    }
}
