using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01Z6
    {
        public static void Izvedi() 
        {
            //Program od korisnika učitava ime grada i broj stanovnika
            //Ispisuje rečenicu: u XXXXXXX živi XXXX ljudi
            
            Console.WriteLine("Upiši ime grada: ");
            string ime = Console.ReadLine();
            Console.WriteLine("Upišu broj stanovnika: ");
            int bs = int.Parse(Console.ReadLine());
            Console.WriteLine("U {0} živi {1} stanovnika.", ime, bs);
            


        }
    }
}
