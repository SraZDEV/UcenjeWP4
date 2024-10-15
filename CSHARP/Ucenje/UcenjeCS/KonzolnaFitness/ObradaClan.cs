using UcenjeCS.KonzolnaFitness.Model;

namespace UcenjeCS.KonzolnaFitness
{
    internal class ObradaClan
    {

        public List<Clan> Clanovi { get; set; }
        public ObradaClan()
        {
            Clanovi = new List<Clan>();
            if (Pomocno.DEV)
            {
                UcitajTestnePodatke();
            }
        }

        private void UcitajTestnePodatke()
        {
            for (int i = 0; i < 10; i++)
            {
                Clanovi.Add(new()
                {
                    Ime = Faker.Name.First(),
                    Prezime = Faker.Name.Last()
                });
            }
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad s članovima");
            Console.WriteLine("1. Pregled svih članova");
            Console.WriteLine("2. Unos novog člana");
            Console.WriteLine("3. Promjena podataka postojećeg člana");
            Console.WriteLine("4. Brisanje člana");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 5))
            {
                case 1:
                    PrikaziClanove();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UnosNovogClana();
                    PrikaziIzbornik();
                    break;
                case 3:
                    PromjeniPodatakClana();
                    PrikaziIzbornik();
                    break;
                case 4:
                    ObrisiClana();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.Clear();
                    break;
            }
        }

        private void ObrisiClana()
        {
            PrikaziClanove();
            var odabrani = Clanovi[
                Pomocno.UcitajRasponBroja("Odaberi redni broj člana za brisanje",
                1, Clanovi.Count)
                ];
            if (Pomocno.UcitajBool("Sigurno obrisati " + odabrani.Ime + " " + odabrani.Prezime + "? (DA/NE)", "da"))
            {
                Clanovi.Remove(odabrani);
            }
        }

        public void PrikaziClanove()
        {
            Console.WriteLine("************************");
            Console.WriteLine("Članovi u aplikaciji");
            int rb = 0, rbg;
            foreach (var c in Clanovi)
            {
                Console.WriteLine(++rb + ". "+ c.Ime + c.Prezime + " (" + c.Grupa?.Naziv + "), ");               
            }
        }


    }
}
