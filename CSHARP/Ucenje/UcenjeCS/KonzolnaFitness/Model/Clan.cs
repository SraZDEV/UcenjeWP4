namespace UcenjeCS.KonzolnaFitness.Model
{
    internal class Clan:Entitet
    {

        public string? Ime { get; set; }
        public string? Prezime { get; set; }
        public string? Email { get; set; }
        public Grupa? Grupa { get; set; }
        public DateTime? ClanOd { get; set; }
        public bool? Verificiran { get; set; }

    }
}
