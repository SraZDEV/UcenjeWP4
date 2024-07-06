using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E17Subota
{
    internal class Program
    {

        public Program()
        {
            // u ljetnim mjesecima se čisti svakih mjesec dana ,a zimskim svaka 2 tjedna
            // 09. 07. 2024. - 14. 7. 2024.,Stan 1
            // 15. 07. 2024. - 21. 7. 2024.,Stan 2
            // 22. 07. 2024. - 28. 7. 2024.,Stan 3

            DateTime datumOd = DateTime.Parse("2024-07-08");
            DateTime datumDo = datumOd;
            DateTime Tjedan;
            int broj = 0;

            while (datumOd.Year < 2028)
            {
                if (datumDo.Month >= 4 && datumOd.Month <= 10)
                {
                    datumDo = datumOd.AddDays(27);
                }
                else
                {
                    datumDo = datumOd.AddDays(13);
                }
                Tjedan = datumOd.AddDays(6);


                Console.WriteLine("{0} - {1},{2}",
                    datumOd.ToString("dd.MM.yyyy."),
                    Tjedan.ToString("dd.MM.yyyy."),++broj %3 +1);
                datumOd = datumDo.AddDays(1);
            }
            // DZ


        }

    }
}
