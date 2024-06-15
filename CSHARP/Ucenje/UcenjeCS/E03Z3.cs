using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z3
    {
        internal static void Izvedi()
        {
            //Za tri učitana cijela broja od strane korisnika program ispisuje najmanji.

            int b1;
            Console.Write("Upišite prvi cijeli broj: ");
            b1 = int.Parse(Console.ReadLine());
            int b2;
            Console.Write("Upišite drugi cijeli broj: ");
            b2 = int.Parse(Console.ReadLine());
            int b3;
            Console.Write("Upišite treći cijeli broj: ");
            b3 = int.Parse(Console.ReadLine());

            if (b1 < b2 && b1 < b1)
            {
                Console.WriteLine(b1);
            }
            if (b2 < b3 && b2 < b3) ;
            {
                Console.WriteLine(b2);
            }
            if (b3 < b1 && b3 < b2) ;
            {
                Console.WriteLine(b3);
            }

        }
            
}
    }

