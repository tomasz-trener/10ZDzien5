using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04AplikacjaZawodnicy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            //PolaczenieZBaza pzb = new PolaczenieZBaza();
            //object[][] wynik= pzb.WyslijPolecenieSQL("select imie, nazwisko, kraj from zawodnicy");

            //lbDane.Items.Clear();
            //foreach (var w in wynik)
            //    lbDane.Items.Add(string.Join(" ", w));
            // Błędna architektura - widok nie moze komunikowac sie bezposrednio z baza danych

            ZawodnicyRepository zr = new ZawodnicyRepository();
            Zawodnik[] zawodnicy= zr.WczytajZawodnikow();

            lbDane.Items.Clear();
            foreach (var z in zawodnicy)
            {
                //  int s = z.Wzrost ?? 80; // ten zapis oznacza, ze s = Z.wwzrost lub 80 gdy z.Wzorst jest null
                lbDane.Items.Add(z.Imie + " " + z.Nazwisko + " " + z.Kraj + " " + (z.Wzrost == null ? "(brak)" : Convert.ToString(z.Wzrost)));
            }
               
             


        }
    }
}
