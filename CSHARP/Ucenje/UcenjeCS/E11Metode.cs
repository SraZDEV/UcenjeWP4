﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E11Metode
    {
        public static void Izvedi()
        {
            // Poziv metode
            Tip1();
            Tip1();

            for (int i = 0; i < 55; i++)
            {
                Tip1();
            }

            Tip2("Edunova");
            Console.WriteLine("Unesi ime: ");
            Tip2(Console.ReadLine());

            Tip2("Pero", "Perić");


            int broj = Tip3();
            Console.WriteLine(broj);

            for (int i = 0; i < 55; i++)
            {
                Console.WriteLine(Tip3());
            }

            Console.WriteLine(Tip4(2, 8));
        }

        // Tip 1. Metoda ne prima parametre i ne vraća vrijednost
        // ovdje je deklarirana, napisana
        // private se vidi samo u trenutnoj klasi
        private static void Tip1()
        {
            Console.WriteLine("Hello iz metode koja ne prima parametre i ne vraća vrijednost");
            Console.WriteLine("Drugi red");
            Console.WriteLine("Treći red");
        }

        // Tip 2. prima parametar, a ne vraća vrijednost
        // kada ispred [static] void nema načina pristupa tada je private

        static void Tip2(string ime)
        {
            Console.WriteLine("Hello {0}", ime);
        }

        // naziv metode ne mora biti jedinstven

        // potpis metode: naziv + lista parametara
        // method signature, ili
        // method overloading

        static void Tip2(string ime, string prezime)
        {
            Console.WriteLine("Hello {0} {1}", ime, prezime);
        }

        

        // Tip 3. metoda ne prima parametre i vraća vrijednost
        static int Tip3()
        {

            return new Random().Next(20, 30);

            return 0;

            return '7'; //"return" vraća vrijednost onome tko je pozvao metodu
            // vraća prema ACSII tablici...
        }
        
        // Tip 4. NAJBITNIJI metoda prima parametre, metoda vraća vrijednost
        // protected je vidljiv u ovoj klasi u svim podklasama (OOP - kasnije)

        /// <summary>
        /// dokumentiranje koda sa "///"
        /// Metoda za dva primljena cijela broja vraća zbroj svih brojeva između njih
        /// </summary>
        /// <param name="odBroja">Broj od kojeg se kreće uključujući taj broj</param>
        /// <param name="doBroja">Broj do kojeg se ide uključujući taj broj</param>
        /// <returns>Zbroj brojeva između dva primljena broja</returns>
        protected static int Tip4(int odBroja, int doBroja)
        {
            int suma = 0;
            for (int i = odBroja; i <= doBroja; i++)
            {
                suma += i;
            }

            return suma;
            // throw new NotImplementedException(); - može i ovako

        }



    }
}