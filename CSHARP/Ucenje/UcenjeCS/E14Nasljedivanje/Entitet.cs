﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E14Nasljedivanje
{
    // "Apstraktna" klasa je klasa koja nema implementaciju
    // kreira se kako bi sadržavala zajednička svojstva i metode koje će koristiti
    // sve klase koje ju nasljeđuju
    internal abstract class Entitet: object // ne mora se uvijek eksplicitno navoditi "object" (sve klase, htjele one to ili ne nasljeđuju klasu "object")
    {
        public int? Sifra { get; set; }

        protected int VidiSeUPodKlasi = 7;

        private int VidiSeSamoUKlasiUKojojJeDefinirano = 2;

        public override string ToString()
        {
            Console.WriteLine(VidiSeSamoUKlasiUKojojJeDefinirano);
            return Sifra.ToString(); // ukoliko je "int" moramo ga vratiti kao ToString
        }



    }
}