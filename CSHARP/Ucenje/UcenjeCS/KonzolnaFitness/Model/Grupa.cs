namespace UcenjeCS.KonzolnaFitness.Model
{
    internal class Grupa:Entitet
    {

        public string? Naziv { get; set; }
        public PrivatniTrener? PrivatniTrener { get; set; }
        public int? KolicinaClanova { get; set; }
        public float? Cijena { get; set; }

    }
}
