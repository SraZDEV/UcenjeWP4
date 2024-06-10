namespace UcenjeCS
{
    internal class E02VarijableTipoviPodatakaOperatori
    {
        //formatiranje koda Ctrl+K+D - sam slaže
        public static void Izvedi()
        {

            //Deklaracija varijabli
            int broj;

            //Dodjeljivanje vrijednosti
            broj = 7;

            Console.WriteLine("Unesi broj: ");
            broj = int.Parse(Console.ReadLine()); //parse = interpretiraj (uzmi to i interpretiraj u moj tip podatka)
            //Korištenje varijable
            Console.WriteLine(broj + 1);

            Console.WriteLine("Unesi decimalni broj: ");
            decimal db = decimal.Parse(Console.ReadLine());

            Console.WriteLine(db/10);

            //modulo: ostatak nakon cjelobrojnog djeljenja
            int modulo = 4 % 2;
            Console.WriteLine(modulo);

            //djeljenje - kad dijeliš 2 cijela broja dobivaš cijeli broj (int)
            int i = 5;
            int j = 3;

            Console.WriteLine(i/(float)j); //"float" je cast(od int prebacuje u float)  


            //bulean
            bool logickaVrijednost = true; // to je u SQL "bit"

            //do sada prikazani operatori:
            //= - dodjeljivanje
            //& - modulo
            //različitost - !=
            //== - provjera jednakosti

            Console.WriteLine(i==j);

            //ne mora se ići u dva reda za deklariranje varijabli
            int k = 5, l = 3; //istovjetno linijam 30 i 31

            var ime = "Edunova"; //desna strana određuje tip (edunova = var) 

            // increment, decrement

            int b = 0;
            //uvećati za 1
            b = b + 1; //1
            b += 1; //2
            b++; //3
            ++b; //4

            Console.WriteLine(++b); //5
            Console.WriteLine(b++); //5
            Console.WriteLine(b); //6

            //isto vrijedi i za decrement --b b--

            //Primjeri zadataka

            int x = 1, y = 2;
            Console.WriteLine("****************");
            x = ++y; //x = 3, y = 3
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            Console.WriteLine("{0}, {1}", x,y);
            Console.WriteLine("****************");


            y = x - --y; // x = 3 - (--y je umanjilo za 1 ukupnu vrijednost)y=1, x=3
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            Console.WriteLine("{0}, {1}", x, y);
            Console.WriteLine("****************");

            Console.WriteLine(x + y); //4

            
        }

    }
}
