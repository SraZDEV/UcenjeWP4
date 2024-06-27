using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E13KlasaObjekt.FitnessKlub
{
    internal class Grupa
    {
        public int? Id { get; set; }
        public string? Naziv { get; set; }
        public PrivatniTrener? PrivatniTrener { get; set; }
        public int? MaxPolaznika { get; set; }
        public int? Cijena { get; set; }




    }
}
