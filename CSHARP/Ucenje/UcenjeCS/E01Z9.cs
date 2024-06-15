using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01Z9
    {
        internal static void Izvedi()
        {
            //Program učitava od korisnika tri broja.
            //Program ispisuje razliku druga dva broja pribrojeno prvom broju

            int b1;
            Console.Write("Unesite prvi broj: ");
            b1 = int.Parse(Console.ReadLine());
            int b2;
            Console.Write("Unesite drugi broj: ");
            b2 = int.Parse(Console.ReadLine());
            int b3;
            Console.Write("Unesite treći broj: ");
            b3 = int.Parse(Console.ReadLine());

            Console.WriteLine(b2 - b3 + b1);
        }
    }
}
