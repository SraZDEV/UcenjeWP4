using System;
using System.Buffers;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E15RadSaStringovima
{
    internal class Program
    {
        // konstruktor
        public Program()
        {
            // string je immutable - nepromjenjiv

            var s = "Edunova"; // s je string zato što je pod dvostrukim navodnicima

            Console.WriteLine(s.GetHashCode());

            s = "Osijek";

            Console.WriteLine(s.GetHashCode());

            var sb = new StringBuilder();

            sb.AppendLine("Edunova");

            Console.WriteLine(sb.GetHashCode());

            sb.Clear();

            sb.AppendLine("Osijek");

            Console.WriteLine(sb.GetHashCode());

            s = "a"; // bolje raditi ovako
            s += " b"; // bolje raditi ovako
            s += "c"; // bolje raditi ovako

            Console.WriteLine(s);

            // u radu sa stringovima se preporuča koristiti "stringbuilder" klasu - komplicira život

            sb = new StringBuilder();
            sb.Append('a');
            sb.Append(" b");
            sb.Append('c'); // radi se da ne moraš svaki puta raditi novu varijablu, a svakako moraš napraviti novu varijablu

            Console.WriteLine(sb); // tu se poziva metoda "ToString"

            // var ce = s.GetEnumerator(); ce = CharEnumerator

            Console.WriteLine(s.ToLower()); // sve ispisuje malo
            Console.WriteLine(s.ToUpper()); // sve ispisuje veliko
            s = "Osijek";
            Console.WriteLine(s.Substring(1));
            Console.WriteLine(s.Substring(1, 2));

            s = "  Ana Marija  ";
            Console.WriteLine(">{0}<", s);
            Console.WriteLine(">{0}<", s.Trim()); // trim metodu koristimo da nam ukloni razmake prije i poslije unesenog podatka - dobar za razmak

            Console.WriteLine(s.Replace('a', 'b'));

            // veliko "A" i malo "a" zamjenjeno na malo "b"
            Console.WriteLine(s.Replace("a", "b", true, CultureInfo.CurrentCulture));

            // var lista = new List<string>(); - generička klasa (predavanje 4.7.)





        }

    }
}
