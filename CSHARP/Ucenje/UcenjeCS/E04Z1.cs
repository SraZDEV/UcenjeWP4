using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E04Z1
    {
        public static void Izvedi()
        {
            //korisnik unosi brojčani iznos ocjene. Program ispisuje tekstualno ocjenu
            Console.Write("Unesite ocjenu: ");
            var ocjena = int.Parse(Console.ReadLine());
            Console.WriteLine(ocjena);


            switch (ocjena)
            {
                case 1:
                    Console.WriteLine("Nedovoljan");
                    break;
                case 2:
                    Console.WriteLine("Dovoljan");
                    break;
                case 3:
                    Console.WriteLine("Dobar");
                    break;
                case 4:
                    Console.WriteLine("Vrlo dobar");
                    break;
                case 5:
                    Console.WriteLine("Odličan");
                    break;
                default:
                    Console.WriteLine("Nije definirano");
                    break;
            }
        }
    }
}
