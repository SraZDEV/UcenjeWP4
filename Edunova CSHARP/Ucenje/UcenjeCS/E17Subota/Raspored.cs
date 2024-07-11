﻿
namespace UcenjeCS.E17Subota
{
    internal class Raspored
    {

        public Raspored()
        {

            // u ljetim mjesecima svakih mjesec dana, a u zimskim svaka dva tjedna

            DateTime datumOd = DateTime.Parse("2024-07-15");
            DateTime datumDo = datumOd;
            DateTime tjedan = datumOd;
            int broj = 0;

            while (datumOd.Year < 2028)
            {
                if (tjedan.Month < 10 && tjedan.Month > 4)
                {
                    datumDo = datumOd.AddDays(27);
                }
                else
                {
                    datumDo = datumOd.AddDays(13);
                }
                tjedan = datumOd.AddDays(6);

                Console.WriteLine("{0} - {1}, Stan {2}",
                    datumOd.ToString("dd.MM.yyyy."),
                    tjedan.ToString("dd.MM.yyyy."), Stan(++broj));
                datumOd = datumDo.AddDays(1);
            }
        }
        private int Stan(int broj)
        {
            switch (broj % 3 + 1)
            {
                case 2: return 1;
                case 3: return 2;
                case 1: return 3;
                default: return 1;
            }
        }
    }
}