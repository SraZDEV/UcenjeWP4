using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E05Nizovi
    {
        public static void Izvedi() 
        {

            //eng. "Arrays"
            //još na HR zovu ih "Polja"

            //jednodimenzionalni niz
            //AltGr + F = uglata zagrada [
            int[] godine = new int[17]; //"new" poziv konstruktora

            godine[0] = 43; // Element na indeksu "0" poprima vrijednost "43"
            //...
            godine[godine.Length - 1] = 23; //na zadnji element postavaljam vrijednost "23" (length je cijela tražena dužina)

            Console.WriteLine(godine);
            Console.WriteLine(string.Join(";",godine)); //uzmi svaki pojedini element (join), a razdjelnik će biti ","


            //skraćena sintaksa definiranja niza skupa sa zadanim vrijednostima

            int[] niz = { 2, 3, 4, 5, 6, 7, 5, 4, 3, 4, 5, 5, 5 };

            //ispiši broj 8
            Console.WriteLine(niz[1]);

            string[] gradovi = { "Osijek", "Donji Miholjac", "Valpovo" }; //uvijek ide od 0... 0,1,2 u ovom slučaju

            //dvodimenzionalni niz - se koristi
            //tablica, matrica

            int[,] tablica = {
            {1, 2, 3 },
            {4, 5, 6 },
            {7, 8, 9 }
            };

            //ispiši broj 3
            Console.WriteLine(tablica[0, 2]);



            // zvjezdane staze
            int[,,,,] multiverse = new int[10, 10, 10, 10, 10]; //nećemo koristiti




            //smisao nizova u CSHARP je da budu istog tipa




        }
    }
}
