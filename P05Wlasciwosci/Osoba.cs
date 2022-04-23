using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05Wlasciwosci
{
    class Osoba
    {
        public string Imie;
        public string Nazwisko { get; set; }

        private string drugieImie; //ADAM
        public string DrugieImie
        {
            get
            {
                return drugieImie.Substring(0,3);
            }
            set
            {
                drugieImie = value.ToUpper();
            }
        }


        public string ImieNazwisko
        {
            get
            {
                string s = "test";
                for (int i = 0; i < 10; i++)
                {

                }
                return Imie + " " + Nazwisko;
            }
        }

        //właściwości nie w kazdym jezyku sa dostepne 

        // tak robia programisci jezykow gdzie 
        // nie ma wlasciwosci 
        public string PodajImieINazwisko()
        {
            return Imie + " " + Nazwisko;
        }

    }
}
