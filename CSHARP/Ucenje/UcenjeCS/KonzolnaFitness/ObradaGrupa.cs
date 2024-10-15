using System.Threading.Channels;
using UcenjeCS.KonzolnaFitness.Model;

namespace UcenjeCS.KonzolnaFitness
{
    internal class ObradaGrupa
    {

        public List<Grupa> Grupe { get; set; }
        private Izbornik Izbornik;

        public ObradaGrupa()
        {
            Grupe = new List<Grupa>();
        }
        public ObradaGrupa(Izbornik izbornik) : this()
        {
            this.Izbornik = izbornik;
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad s grupama");
            Console.WriteLine("1. Pregled svih grupa");
            Console.WriteLine("2. Unos nove grupe");
            Console.WriteLine("3. Promjena podataka postojeće grupe");
            Console.WriteLine("4. Brisanje grupe");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }
        private void OdabirOpcijeIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 5))
            {
                case 1:
                    PrikaziGrupe();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UnosNoveGrupe();
                    PrikaziIzbornik();
                    break;
                case 3:
                    PromjeniPodatkeGrupe();
                    PrikaziIzbornik();
                    break;
                case 4:
                    ObrisiGrupu();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.Clear();
                    break;
            }
        }
        private void ObrisiGrupu()
        {
            PrikaziGrupe();
            var g = Grupe[
                Pomocno.UcitajRasponBroja("Odaberi redni broj grupe za brisanje", 1, Grupe.Count) - 1
                ];
            if (Pomocno.UcitajBool("Sigurno obrisati " + g.Naziv + "? (DA/NE)", "da"))
            {
                Grupe.Remove(g);
            }
        }

        private void PromjeniPodatkegrupe()
        {
            PrikaziGrupe();
            var g = Grupe[Pomocno.UcitajRasponBroja("Odaberi redni broj grupe za promjenu", 1, Grupe.Count) - 1
                ];
            g.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru grupe", 1, int.MaxValue);
            g.Naziv = Pomocno.UcitajString("Unesi naziv grupe", 50, true);
            // Privatni trener
            Izbornik.ObradaPrivatniTrener.PrikaziTrenere();
            g.PrivatniTrener = Izbornik.ObradaPrivatniTrener.PrivatniTreneri[
                Pomocno.UcitajRasponBroja("Odaberi redni broj trenera", 1, Izbornik.ObradaPrivatniTrener.PrivatniTreneri.Count)];

            g.KolicinaClanova = Pomocno.UcitajRasponBroja("Unesi maksimalni broj članova", 1, 25);
            g.Cijena = Pomocno.UcitajDecimalniBroj("Unesi cijenu grupe", 20, 50);
        }

        private void PrikaziGrupe()
        {
            Console.WriteLine("************************");
            Console.WriteLine("Grupe u aplikaciji");
            int rb = 0;
            foreach (var g in Grupe)
            {
                Console.WriteLine(++rb + ". " + g.Naziv + " (" + g.PrivatniTrener?.Ime + ")");
            }
            Console.WriteLine("************************");
        }
        private void UnosNoveGrupe()
        {
            Console.WriteLine("************************");
            Console.WriteLine("Unesite tražene podatke o grupi");

            Grupa g = new Grupa();
            g.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru grupe", 1, int.MaxValue);
            g.Naziv = Pomocno.UcitajString("Unesi naziv grupe", 50, true);
            // Privatni trener
            Izbornik.ObradaPrivatniTrener.PrikaziTrenere();
            g.PrivatniTrener = Izbornik.ObradaPrivatniTrener.PrivatniTreneri[
                Pomocno.UcitajRasponBroja("Odaberi redni broj trenera", 1, Izbornik.ObradaPrivatniTrener.PrivatniTreneri.Count)];

            g.KolicinaClanova = Pomocno.UcitajRasponBroja("Unesi maksimalni broj članova", 1, 25);
            g.Cijena = Pomocno.UcitajDecimalniBroj("Unesi cijenu grupe", 20, 50);

            Grupe.Add(g);
        }

        private void PromjeniPodatkeGrupe()
        {
            PrikaziGrupe();
            var g = Grupe[
                Pomocno.UcitajRasponBroja("Odaberi redni broj grupe za promjenu", 1, Grupe.Count) - 1
                ];
            g.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru grupe", 1, int.MaxValue);
            g.Naziv = Pomocno.UcitajString("Unesi naziv grupe", 50, true);
            // Privatni trener
            Izbornik.ObradaPrivatniTrener.PrikaziTrenere();
            g.PrivatniTrener = Izbornik.ObradaPrivatniTrener.PrivatniTreneri[
                Pomocno.UcitajRasponBroja("Odaberi redni broj trenera", 1, Izbornik.ObradaPrivatniTrener.PrivatniTreneri.Count)];

            g.KolicinaClanova = Pomocno.UcitajRasponBroja("Unesi maksimalni broj članova", 1, 25);
            g.Cijena = Pomocno.UcitajDecimalniBroj("Unesi cijenu grupe", 20, 50);
        }

    }
}
