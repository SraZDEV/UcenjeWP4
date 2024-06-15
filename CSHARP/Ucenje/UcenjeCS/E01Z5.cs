using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01Z5
    {
        public static void Izvedi()
        {
            //Program od korisnika učitava decimalni broj te ispisuje drugi korije učitanog broja.

            double x;
            Console.Write("Unesi DECIMALNI broj: ");
            x = double.Parse(Console.ReadLine());
            x = Math.Sqrt(x);
            Console.WriteLine(x);

            Console.WriteLine("Unesi DECIMALNI broj: ");
            Console.WriteLine(Math.Sqrt(double.Parse(Console.ReadLine())));

        }
    }
}
