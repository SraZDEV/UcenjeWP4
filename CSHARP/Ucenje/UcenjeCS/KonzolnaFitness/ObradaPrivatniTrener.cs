using UcenjeCS.KonzolnaFitness.Model;

namespace UcenjeCS.KonzolnaFitness
{
    internal class ObradaPrivatniTrener
    {

        public List<PrivatniTrener> PrivatniTreneri { get; set; }

        public ObradaPrivatniTrener()
        {
            PrivatniTreneri = new List<PrivatniTrener>();
            if (Pomocno.DEV)
            {
                UcitajTestnePodatke();
            }
        }

        private void UcitajTestnePodatke()
        {
            PrivatniTreneri.Add(new() { Ime = "Ivan Ivić" });
            PrivatniTreneri.Add(new() { Ime = "Pero Perić" });
            PrivatniTreneri.Add(new() { Ime = "Marko Marko" });
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad sa privatnim trenerima");
            Console.WriteLine("1. Pregled svih trenera");
            Console.WriteLine("2. Unos novog trenera");
            Console.WriteLine("3. Promjena podataka postojećeg trenera");
            Console.WriteLine("4. Brisanje trenera");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 5))
            {
                case 1:
                    PrikaziTrenere();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UnosNovogTrenera();
                    PrikaziIzbornik();
                    break;
                case 3:
                    PromjeniPostojecegTrenera();
                    PrikaziIzbornik();
                    break;
                case 4:
                    ObrisiPostojecegTrenera();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.Clear();
                    break;
            }
        }

        private void ObrisiPostojecegTrenera()
        {
            PrikaziTrenere();
            var odabrani = PrivatniTreneri[Pomocno.UcitajRasponBroja("Odaberi redni broj trenera za BRISANJE",
                1, PrivatniTreneri.Count) - 1];

            if (Pomocno.UcitajBool("Sigurno OBRISATI " + odabrani.Ime + "? (DA/NE)", "da"))
            {
                PrivatniTreneri.Remove(odabrani);
            }
        }

        public void PrikaziTrenere()
        {
            Console.WriteLine("************************");
            Console.WriteLine("Privatni treneri u aplikaciji");
            int rb = 0;
            foreach (var pt in PrivatniTreneri)
            {
                Console.WriteLine(++rb + ". " + pt.Ime);
            }
            Console.WriteLine("************************");
        }

        private void PromjeniPostojecegTrenera()
        {
            PrikaziTrenere();
            var odabrani = PrivatniTreneri[Pomocno.UcitajRasponBroja("Odaberi redni broj privatnog trenera za promjenu",
                1, PrivatniTreneri.Count) - 1];
            odabrani.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru trenera", 1, int.MaxValue);
            odabrani.Ime = Pomocno.UcitajString("Unesi ime trenera", 50, true);
            odabrani.Prezime = Pomocno.UcitajString("Unesi prezime trenera", 50, true);
            odabrani.Email = Pomocno.UcitajString("Unesi email trenera", 100, true);
            odabrani.CijenaSat = Pomocno.UcitajDecimalniBroj("Unesi cijenu po satu trenera", 0, 50);
        }

        private void UnosNovogTrenera()
        {
            Console.WriteLine("************************");
            Console.WriteLine("Unesite tražene podatkeo treneru");
            PrivatniTreneri.Add(new()
            {
                Sifra = Pomocno.UcitajRasponBroja("Unesi šifru trenera", 1, int.MaxValue),
                Ime = Pomocno.UcitajString("Unesi ime trenera", 50, true),
                Prezime = Pomocno.UcitajString("Unesi prezime trenera", 50, true),
                Email = Pomocno.UcitajString("Unesi email trenera", 100, true),
                CijenaSat = Pomocno.UcitajDecimalniBroj("Unesi cijenu po satu trenera", 0, 50)
            });
        }
    }
}
