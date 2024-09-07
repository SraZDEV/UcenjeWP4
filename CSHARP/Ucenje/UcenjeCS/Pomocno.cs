using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Pomocno
    {

        public static int UcitajCijeliBroj()
        {
            while (true)
            {
                try
                {
                    Console.Write("Unesi cijeli broj: ");
                    return int.Parse(Console.ReadLine());
                }
                catch // i ne mora se staviti exception
                {
                    Console.WriteLine("Pogreška prilikom unosa!");
                }
            }
        }

        public static int UcitajCijeliBroj(string poruka, int v, int v1)
        {
            while (true)
            {
                try
                {
                    Console.Write(poruka + ": ");
                    return int.Parse(Console.ReadLine());
                }
                catch // i ne mora se staviti exception
                {
                    Console.WriteLine("Pogreška prilikom unosa!");
                }
            }
        }

    }
}
