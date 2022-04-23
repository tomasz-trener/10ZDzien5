using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05Wlasciwosci
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba o = new Osoba();

            o.Imie = "Jan";
            o.Nazwisko = "Kowalski";

            o.DrugieImie = "Adam";

            Console.WriteLine(o.DrugieImie);// ADAM

            Console.WriteLine(o.ImieNazwisko);
            Console.WriteLine(o.PodajImieINazwisko());

            // teraz imieNazwisko jest tylko do odczytu 
            //o.ImieNazwisko = "Adam nowa";

            StringBuilder sb = new StringBuilder();
            




        }
    }
}
