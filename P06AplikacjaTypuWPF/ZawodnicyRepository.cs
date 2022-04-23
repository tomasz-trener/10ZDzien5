using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06AplikacjaTypuWPF
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
               
                if(wynik[i][1] != DBNull.Value) // wartosc null w bazie danych to co innego niz null w programie w c# 
                    ityZawodnik.IdTrenera = (int)wynik[i][1];
                 
                ityZawodnik.Imie = (string)wynik[i][2];
                ityZawodnik.Nazwisko = (string)wynik[i][3];
                ityZawodnik.Kraj = (string)wynik[i][4];
                ityZawodnik.DataUr = (DateTime)wynik[i][5];

                if (wynik[i][6] != DBNull.Value)
                    ityZawodnik.Wzrost = (int)wynik[i][6];
               
                ityZawodnik.Waga = (int)wynik[i][7];

                zawodnicy[i] = ityZawodnik;
            }

            return zawodnicy;
        }


        public void DodajZawodnika(Zawodnik z)
        {
            string szablon = @"insert into zawodnicy 
                         (id_trenera, imie, nazwisko, kraj, data_ur, wzrost, waga)
                         values
                         ({0}, '{1}', '{2}', '{3}', '{4}', {5}, {6})";

            string sql = string.Format(szablon, z.IdTrenera, z.Imie, z.Nazwisko, z.Kraj,
                z.DataUr.ToString("yyyyMMdd"), z.Wzrost, z.Waga);

            PolaczenieZBaza pzb = new PolaczenieZBaza();
            pzb.WyslijPolecenieSQL(sql);
        }

        public void Edytuj(Zawodnik z)
        {
            string szablon = @"update zawodnicy set imie='{0}',nazwisko='{1}', kraj='{2}', data_ur='{3}',wzrost={4},waga={5}
                                where id_zawodnika = {6}";

            string sql = string.Format(szablon,z.Imie,z.Nazwisko,z.Kraj,z.DataUr.ToString("yyyyMMdd"),z.Wzrost,z.Waga,z.Id);

            PolaczenieZBaza pzb = new PolaczenieZBaza();
            pzb.WyslijPolecenieSQL(sql);

        }

        //params - mogę podać jednego lub wielu po przecinku, lub po prostu całą kolekcję 
        public void Usun(params Zawodnik[] zawodnicy)
        {
            // wersja 1 :
            // StringBuilder sb = new StringBuilder();
            //foreach (var z in zawodnicy)
            //    sb.Append("delete zawodnicy where id_zawodnika = " + z.Id + " ");

            // werjsa 2 : z zastosowaniem linq , poznamy na ostatnim zjezie 
            string sql = string.Format("delete zawodnicy where id_zawodnika in ({0})",
                string.Join(" ,", zawodnicy.Select(x => x.Id)));

            PolaczenieZBaza pzb = new PolaczenieZBaza();
            pzb.WyslijPolecenieSQL(sql);
        }
    }
}
