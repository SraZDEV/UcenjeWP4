using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z2
    {
        public static void Izvedi() 
        {
            // Korisnik unosi dva decimalna broja
            // Program ispisuje veći ili jednaki su ako su uneseni brojevi jednaki

            float[] b = new float[2];
            Console.Write("Unesi prvi broj: ");
            b[0] = float.Parse(Console.ReadLine());
            Console.Write("Unesi drugi broj: ");
            b[1] = float.Parse(Console.ReadLine());

            
                Console.WriteLine(
                    b[1] == b[0] ? "Jednaki su" :
                    b[0] b>1);




        }
    }
}
