using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06AplikacjaTypuWPF
{
    public partial class Form1 : Form
    {
        // aplikacja CRUD (Create , Read, Update, Delete)
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            Odswiez();
        }

        private void Odswiez()
        {
            // Wersja 1:
            //PolaczenieZBaza pzb = new PolaczenieZBaza();
            //object[][] wynik= pzb.WyslijPolecenieSQL("select imie, nazwisko, kraj from zawodnicy");

            //lbDane.Items.Clear();
            //foreach (var w in wynik)
            //    lbDane.Items.Add(string.Join(" ", w));
            // Błędna architektura - widok nie moze komunikowac sie bezposrednio z baza danych

            // Wersja 2:
           
            ZawodnicyRepository zr = new ZawodnicyRepository();
            Zawodnik[] zawodnicy = zr.WczytajZawodnikow();
            // poprawna architektura ale brak data bindingu 
            // skutek: nie mamy możłiwości sprwadzenia, któy element jest którym w naszej kontrolce
            //lbDane.Items.Clear();
            //foreach (var z in zawodnicy)
            //{
            //    //  int s = z.Wzrost ?? 80; // ten zapis oznacza, ze s = Z.wwzrost lub 80 gdy z.Wzorst jest null
            //    lbDane.Items.Add(z.Imie + " " + z.Nazwisko + " " + z.Kraj + " " + (z.Wzrost == null ? "(brak)" : Convert.ToString(z.Wzrost)));
            //}

            // Wesja 3
            // tym razem uzyjemy mechanizmu DataBinding 
            lbDane.DataSource = zawodnicy;
            lbDane.DisplayMember = "Wiersz"; // to musi być właściwość (a nie pole)
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            // zzcytaj z kontrolek dane 
            Zawodnik nowy = new Zawodnik();
            ZczytajDaneZKontrolek(nowy);

            ZawodnicyRepository zr = new ZawodnicyRepository();
            zr.DodajZawodnika(nowy);
            Odswiez();
        }

        private void ZczytajDaneZKontrolek(Zawodnik z)
        {
            z.Imie = txtImie.Text;
            z.Nazwisko = txtNazwisko.Text;
            z.Kraj = txtKraj.Text;
            z.DataUr = dtpDataUrodzenia.Value;
            z.Wzrost = Convert.ToInt32(numWzrost.Value);
            z.Waga = Convert.ToInt32(numWaga.Value);
        }

        private void lbDane_SelectedIndexChanged(object sender, EventArgs e)
        {
            // odowlanie sie do wielu zaznaczonych elementow 
            Zawodnik[] zaznaczeni =lbDane.SelectedItems.Cast<Zawodnik>().ToArray();

            // krok 1 : sprawdzenie, który zawodnik jest zaznaczony aktualnie
            // 
            // Zawodnik z= (Zawodnik)lbDane.SelectedItem;
            Zawodnik z = zaznaczeni[0];

            // krok 2: wyswietlnie tego zawodnika w kontrolkach 

            txtImie.Text = z.Imie;
            txtNazwisko.Text = z.Nazwisko;
            txtKraj.Text = z.Kraj;
            dtpDataUrodzenia.Value = z.DataUr;
            numWaga.Value = z.Waga;
            if(z.Wzrost != null)
                numWzrost.Value = (int)z.Wzrost;


        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            Zawodnik z = (Zawodnik)lbDane.SelectedItem;
            ZczytajDaneZKontrolek(z);
            ZawodnicyRepository zr = new ZawodnicyRepository();
            zr.Edytuj(z);
            Odswiez();

        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            Zawodnik[] zaznaczeni = lbDane.SelectedItems.Cast<Zawodnik>().ToArray();

            DialogResult dr =
                MessageBox.Show($"Czy napewno chcesz usunać zaznczonych {zaznaczeni.Length} rekordów", "Pytanie", 
                MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                ZawodnicyRepository zr = new ZawodnicyRepository();
                //  zr.Usun(zaznaczeni[0], zaznaczeni[2]);
                zr.Usun(zaznaczeni);
                Odswiez();
            }


            
        }
    }
}
