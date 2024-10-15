using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class LjubavniKalkulator
    {
        public static void Izvedi()
        {

            Console.Title = "Ljubavni Kalkulator";
            do
            {
                string ime1 = Pomocno.UcitajString("Unesi svoje ime");
                string ime2 = Pomocno.UcitajString("Unesi ime svoje simpatije");
                int imena = ConvertNumbers(ime1.ToLower(), ime2.ToLower());

                Console.WriteLine();
                if (CalculateLove(imena) > 50)
                {
                    Console.WriteLine(ime1.ToUpper() + " i " + ime2.ToUpper() + " imaju šansu za ljubav: " + CalculateLove(imena) + "%");
                    Console.WriteLine();
                }
                else
                {

                    Console.WriteLine(ime1.ToUpper() + " i " + ime2.ToUpper() + " imaju šansu za ljubav: " + CalculateLove(imena) + "%");
                    Console.WriteLine();
                }

            } while (Pomocno.UcitajString(" Za prekid rada - q") != "q");
        }
        private static int ConvertNumbers(string ime1, string ime2, int index = 0, string combined = "")
        {

            if (index >= Math.Max(ime1.Length, ime2.Length))
            {

                return CompressDigits(combined);

            }
            int z1 = (index < ime1.Length) ? ime1.Count(c => c == ime1[index]) + ime2.Count(c => c == ime1[index]) : 0;
            int z2 = (index < ime2.Length) ? ime1.Count(c => c == ime2[index]) + ime2.Count(c => c == ime2[index]) : 0;
            combined += (z1 + z2).ToString();
            return ConvertNumbers(ime1, ime2, index + 1, combined);
        }
        private static int CompressDigits(string broj, string result = "") 
        {

            if (broj.Length <= 2) 
            {
                return int.Parse(broj);
            }
            for (int i = 0; i < broj.Length / 2; i++) 
            {
                int zbroj = (broj[i] - '0') + (broj[broj.Length - 1 - i] - '0');
                result += zbroj.ToString();
            }
            if (broj.Length % 2 == 1)
            {
                result += broj[broj.Length / 2];
            }
            return CompressDigits(result);
        }
        private static int CalculateLove(int love)
        {
            if (love <= 100)
            {
                return love;
            }
            return CalculateLove(CompressDigits(love.ToString()));
        }
    }
}
