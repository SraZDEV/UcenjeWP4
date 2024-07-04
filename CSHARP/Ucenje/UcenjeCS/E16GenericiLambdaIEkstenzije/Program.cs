using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16GenericiLambdaIEkstenzije
{
    internal class Program
    {
        // konstruktor se poziva kad se stvara objekt sa riječi "new"
        // kad klasa nema konstruktor, poziva se iz "Object"

        public Program()
        {

            // problem nizova: unaprijed moramo znati koliko će imati elemenata

            // u nastavku nastave i u stvarnom životu koristiti ćemo "List"
            // generička lista "int"-cijelih brojeva
            List<int> brojevi = new List<int>();

            brojevi.Add(1);
            brojevi.Add(2);

            Console.WriteLine(brojevi[0]);

            foreach (int i in brojevi)
            {
                Console.WriteLine(i);
            }

            // generička lista "string"
            List<string> imena = new List<string>();

            imena.Add("Pero");
            imena.Add("Marko");

            Console.WriteLine(imena[0]);

            foreach (string s1 in imena)
            {
                Console.WriteLine(s1);
            }

            // functional programing
            imena.ForEach(Console.WriteLine); // jednostaviniji način od čiste "foreach" petlje

            List<Smjer> smjerovi = new List<Smjer>(); // u listu ako stavimo listu smjerova mora biti smjer, ne može biti int, string, etc.

            smjerovi.Add(new() { Sifra = 1, Naziv = "Web programiranje" });

            smjerovi.ForEach(Console.WriteLine);




            Obrada<Smjer> os = new Obrada<Smjer>();
            os.ObjektObrade = smjerovi[0];
            os.Obradi();

            Obrada<Polaznik> op = new Obrada<Polaznik>();
            op.ObjektObrade = new() { Sifra = 1, Ime = "Marko", Prezime = "Perić" };
            op.Obradi();


            // Lambda expressions(izrazi) - mehanizam da definiramo metodu unutar metode (svaki sa svakim)

            // klasika
            Console.WriteLine(KlasicnaMetoda(2, 2));

            var Zbroj = (int a, int b) => a + b;

            Console.WriteLine(Zbroj(2, 2));

            // malo kompliciranije

            var algoritam = (int x, int y) =>
            {
                var t = ++x - y;
                return t + y;
            };

            Console.WriteLine(algoritam(2,2));
            Console.WriteLine(algoritam(1,1));

            // ekstenzije(dodatci)
            //smjerovi[0].OdradiPosao();
            Smjer s = new Smjer();
            s.Naziv = "WP";

            smjerovi.Add(new() { Sifra = 2, Naziv = "Java programiranje" });

            smjerovi.ForEach(Console.WriteLine);
            smjerovi.Sort();
            Console.WriteLine("*********************");// sortira elemente koristeći sortirni komparator
            smjerovi.ForEach(Console.WriteLine);





            os.Lista = smjerovi;

            os.IspisStavaka(MojIspis);

            os.IspisStavaka(DrugaMetoda);
            Console.WriteLine();

            os.IspisStavaka((s) =>
            {
                Console.WriteLine("Nisam više znao kako nazvati metodu: " + s);
            });

            smjerovi.ForEach(s =>
            {
                Console.WriteLine("Vrtim stavke liste");
            });

            smjerovi.ForEach(MojIspis);


            Console.WriteLine(smjerovi.Sum(s => s.Sifra));

        }

        private void DrugaMetoda(Smjer smjer)
        {
            Console.Write(smjer.Sifra);
        }

        private void MojIspis(Smjer s)
        {
            Console.WriteLine("Prilagođeni ispis " + s.Naziv);
        }

        private int KlasicnaMetoda(int a, int b)
        {
            return a + b;
        }




    }
}
