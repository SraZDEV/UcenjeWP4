using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E13KlasaObjekt.Edunova;

namespace UcenjeCS.E13KlasaObjekt.FitnessKlub
{
    internal class Clan
    {
        public int? Id { get; set; }
        public string? Ime { get; set; }
        public string? Prezime { get; set; }
        public string? Email { get; set; }
        public Grupa? Grupa { get; set; }
        public DateTime? ClanOd { get; set; }
        public bool Verificiran { get; set; }



    }
}
