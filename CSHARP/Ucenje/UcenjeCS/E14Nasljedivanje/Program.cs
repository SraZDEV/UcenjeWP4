namespace UcenjeCS.E14Nasljedivanje
{
    internal class Program
    {

        // konstruktor - posebna vrsta metode koja se poziva prilikom kreiranja instance klase - objekta
        // ključna riječ "new"
        // konstruktor se uvijek naziva kao i klasa
        public Program()
        {

            //Console.WriteLine("Hello!");
            Smjer s = new Smjer();
            s.Naziv = "Web programiranje";
            Console.WriteLine(s); // ovdje se poziva metoda "toString" na objektu "s"


            var p = new Polaznik()
            {
                Ime = "Pero",
                Sifra = 1
            };

            Console.WriteLine(p); // ovdje se poziva metoda "toString" na objektu "p"

            // apstraktna klasa se ne može instancirati
            //var e = new Entitet(); // "e" je isntanca klase "Entitet"


            Obrada[] poslovi = new Obrada[2];
            poslovi[0] = new ObradaIzlazniRacun();
            poslovi[1] = new ObradaUlazniRacun();

            // polimorfizam: predstava (realizacija)
            foreach(Obrada o in poslovi)
            {
                o.Procesuiraj(); // polimorfizam
            }

        }

        // za konstruktor vrijedi pravilo "method overloading"
        public Program(string s)
        {

            Console.WriteLine(s);

        }





    }
}
