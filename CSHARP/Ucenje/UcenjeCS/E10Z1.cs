using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E10Z1
    {
        public static void Izvedi()
        {
            // Program od korisnika unosi 10 brojeva
            // Program ispisuje prvo zbroj svih unesenih brojeva
            // i nakon toga ispisuje unesene brojeve jedno ispod drugog

            //primjer nakon svih unosa ispisuje se
            //10
            // 1
            // 3
            // 0
            // 0
            // 1
            // 1
            // 1
            // 1
            // 1

            int ub = 10; // ovo može i korisnik unjeti
            int[] brojevi = new int[ub];

            for (int i = 0; i < ub; i++)
            {
                Console.WriteLine("Unesi {0}. broj: ", i+1);
                brojevi[i] = int.Parse(Console.ReadLine());
            }

            int zbroj = 0;
            foreach (var b in brojevi)
            {
                zbroj += b;
            }
            Console.WriteLine(zbroj);
            int index = 0;
            while (index < 10)
            {
                Console.WriteLine(brojevi[index++]);
            }







        }
    }
}
