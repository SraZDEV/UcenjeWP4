using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z1
    {
        public static void Izvedi() 
        {
            // Program od korisnika traži unos broj godina koje ima korisnik
            // Program ispisuje da li je korisnik punoljetna osoba ili ne

            Console.Write("Unesi broj Vaših godina: ");
            var godine =int.Parse(Console.ReadLine());
            Console.WriteLine(godine);
            if (godine >= 18)
            {
                Console.WriteLine("Vi ste punoljetni.");
            }
            else
            {
                Console.WriteLine("Vi niste punoljetni.");
            }
            //profesor
            Console.Write("Unesi broj godina: ");
            var g = int.Parse(Console.ReadLine());
            Console.WriteLine(g >= 18 ? "Punoljetna" : "Maloljetna"); //vježbati ovo (Ss) - ? oznaka "true" grane, nakon ":" je false


        }
    }
}
