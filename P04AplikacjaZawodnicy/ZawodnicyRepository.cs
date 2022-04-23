using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04AplikacjaZawodnicy
{
    class ZawodnicyRepository
    {

        public Zawodnik[] WczytajZawodnikow()
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza();
            object[][] wynik= pzb.WyslijPolecenieSQL("select id_zawodnika, id_trenera, imie, nazwisko, kraj, data_ur, wzrost, waga from zawodnicy");

            //transformacja object[][] na Zawodnik[] 

            Zawodnik[] zawodnicy = new Zawodnik[wynik.Length];

            for (int i = 0; i < wynik.Length; i++)
            {
                Zawodnik ityZawodnik = new Zawodnik();
                ityZawodnik.Id = (int)wynik[i][0];
                ityZawodnik.IdTrenera = (int)wynik[i][1];
                ityZawodnik.Imie = (string)wynik[i][2];
                ityZawodnik.Nazwisko = (string)wynik[i][3];
                ityZawodnik.Kraj = (string)wynik[i][4];
                ityZawodnik.DataUr = (DateTime)wynik[i][5];
                ityZawodnik.Wzrost = (int)wynik[i][6];
                ityZawodnik.Waga = (int)wynik[i][7];

                zawodnicy[i] = ityZawodnik;
            }

            return zawodnicy;
        }

    }
}
