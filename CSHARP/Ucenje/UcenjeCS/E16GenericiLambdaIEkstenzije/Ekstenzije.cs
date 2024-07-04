using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16GenericiLambdaIEkstenzije
{
    internal static class Ekstenzije // moraju biti u statičnoj klasi
    {

        public static void OdradiPosao(this ISucelje sucelje)
        {
            Console.WriteLine("Krećem");
            sucelje.OdradiPosao();
            Console.WriteLine("Završio");


        }

    }
}
